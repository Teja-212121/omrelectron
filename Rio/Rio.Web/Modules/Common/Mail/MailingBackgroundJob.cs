
namespace Rio.Common.Services
{
   
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Rio.Common;
    using Serenity;
    using Serenity.Abstractions;
    using Serenity.Data;
    using Serenity.Extensions;
    using Serenity.Pro.EmailQueue;
    using Serenity.Pro.Extensions;
    using System;

    public class MailingBackgroundJob : PeriodicBackgroundJob
    {
        private readonly ISqlConnections connections;
        private readonly IEmailSender emailSender;
        private readonly EmailQueueJobSettings config;

        public MailingBackgroundJob(ISqlConnections connections,
            IEmailSender emailSender, IOptions<EmailQueueJobSettings> options,
            ILogger<MailingBackgroundJob> log = null, IExceptionLogger exceptionLog = null)
            : base(log, exceptionLog)
        {
            this.connections = connections ?? throw new ArgumentNullException(nameof(connections));
            this.emailSender = emailSender ?? throw new ArgumentNullException(nameof(emailSender));
            config = (options ?? throw new ArgumentNullException(nameof(options))).Value;
        }

        protected override TimeSpan GetInterval()
        {
            return TimeSpan.FromSeconds(config.Interval);
        }

        protected override void InternalRun()
        {

            if (!config.Enabled)
                return;

            using var connection = connections.NewFor<MailRow>();
            var m = MailRow.Fields;

            var mailList = connection.List<MailRow>(q => q
                .Take(config.BatchSize)
                .Select(m.MailId)
                .Select(m.LockExpiration)
                .Where(
                    m.Status == (int)MailStatus.InQueue &
                    m.RetryCount < config.RetryLimit &
                    m.LockExpiration < DateTime.Now)
                .OrderBy(m.Priority)
                .OrderBy(m.RetryCount)
                .OrderBy(m.MailId));

            var lockDuration = TimeSpan.FromSeconds(config.LockDuration);

            foreach (var mail in mailList)
            {
                try
                {
                    using (var uow = new UnitOfWork(connection))
                    {
                        //if (SqlApplicationLock.Get(uow, "BackgroundJob_EmailQueueSend_" + mail.MailId.Value) < 0)
                        //    continue;

                        if (new SqlUpdate(m.TableName)
                            .Set(m.LockExpiration, DateTime.Now.Add(lockDuration))
                            .Where(
                                m.MailId == mail.MailId.Value &
                                m.LockExpiration >= mail.LockExpiration.Value.AddMilliseconds(-5) &&
                                m.LockExpiration <= mail.LockExpiration.Value.AddMilliseconds(5))
                            .Execute(connection, ExpectedRows.ZeroOrOne) == 1)
                        {
                            uow.Commit();
                        }
                        else
                            continue;
                    }

                    new MailingService().SendById(connection, mail.MailId.Value);
                }
                catch (Exception ex)
                {
                    ex.Log(ExceptionLog);
                }
            }
        }
    }
}