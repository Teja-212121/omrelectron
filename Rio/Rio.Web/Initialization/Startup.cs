using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyModel.Resolution;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Serialization;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;
using Rio.AppServices;
using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Extensions.DependencyInjection;
using Serenity.Localization;
using Serenity.Navigation;
using Serenity.Pro.Extensions;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data.Common;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Rio
{
    public partial class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment hostEnvironment)
        {
            Configuration = configuration;
            HostEnvironment = hostEnvironment;
            SqlSettings.AutoQuotedIdentifiers = true;
            RegisterDataProviders();
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment HostEnvironment { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ITypeSource>(new DefaultTypeSource(new[]
            {
                typeof(LocalTextRegistry).Assembly,
                typeof(ISqlConnections).Assembly,
                typeof(IRow).Assembly,
                typeof(SaveRequestHandler<>).Assembly,
                typeof(IDynamicScriptManager).Assembly,
                typeof(Startup).Assembly,
                typeof(Serenity.Extensions.EnvironmentSettings).Assembly,
                typeof(Serenity.Pro.Extensions.BackgroundJobManager).Assembly,
                typeof(Serenity.Pro.DataAuditLog.DataAuditLogController).Assembly,
                typeof(Serenity.Pro.DataExplorer.DataExplorerController).Assembly,
                typeof(Serenity.Pro.EmailClient.MailboxController).Assembly,
                typeof(Serenity.Pro.EmailQueue.EmailQueueController).Assembly,
            }));

            services.Configure<ConnectionStringOptions>(Configuration.GetSection(ConnectionStringOptions.SectionKey));
            services.Configure<CssBundlingOptions>(Configuration.GetSection(CssBundlingOptions.SectionKey));
            services.Configure<LocalTextPackages>(Configuration.GetSection(LocalTextPackages.SectionKey));
            services.Configure<ScriptBundlingOptions>(Configuration.GetSection(ScriptBundlingOptions.SectionKey));
            services.Configure<UploadSettings>(Configuration.GetSection(UploadSettings.SectionKey));
            services.Configure<Serenity.Extensions.EnvironmentSettings>(
                Configuration.GetSection(Serenity.Extensions.EnvironmentSettings.SectionKey));
            services.Configure<Serenity.Pro.Extensions.BackgroundJobSettings>(
                Configuration.GetSection(Serenity.Pro.Extensions.BackgroundJobSettings.SectionKey));
            services.Configure<Serenity.Extensions.SmtpSettings>(
                Configuration.GetSection(Serenity.Extensions.SmtpSettings.SectionKey));
            services.Configure<Serenity.Pro.EmailQueue.EmailQueueJobSettings>(
                Configuration.GetSection(Serenity.Pro.EmailQueue.EmailQueueJobSettings.SectionKey));
            services.Configure<Serenity.Pro.DataExplorer.DataExplorerConfig>(
                Configuration.GetSection(Serenity.Pro.DataExplorer.DataExplorerConfig.SectionKey));

            var dataProtectionKeysFolder = Configuration?["DataProtectionKeysFolder"];
            if (!string.IsNullOrEmpty(dataProtectionKeysFolder))
            {
                dataProtectionKeysFolder = Path.Combine(HostEnvironment.ContentRootPath, dataProtectionKeysFolder);
                if (Directory.Exists(dataProtectionKeysFolder))
                    services.AddDataProtection()
                        .PersistKeysToFileSystem(new DirectoryInfo(dataProtectionKeysFolder));
            }

            services.AddAntiforgery(options =>
            {
                options.HeaderName = "X-CSRF-TOKEN";
            });

            services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            var builder = services.AddControllersWithViews(options =>
            {
                options.Filters.Add(typeof(AutoValidateAntiforgeryTokenAttribute));
                options.Filters.Add(typeof(AntiforgeryCookieResultFilterAttribute));
                options.ModelBinderProviders.Insert(0, new ServiceEndpointModelBinderProvider());
                options.Conventions.Add(new ServiceEndpointActionModelConvention());
            }).AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });

            if (HostEnvironment.IsDevelopment())
                builder.AddRazorRuntimeCompilation();

            Serenity.Pro.Extensions.ExceptionLog.Initialize(services, HostEnvironment.ApplicationName,
                Configuration["Data:Default:ConnectionString"], Configuration["Data:Default:ProviderName"], Configuration["Data:Default:Dialect"]);

            services.AddAuthentication(o =>
            {
                o.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                o.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                o.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(o =>
            {
                o.Cookie.Name = ".AspNetAuth";
                o.LoginPath = new PathString("/Account/Login/");
                o.AccessDeniedPath = new PathString("/Account/AccessDenied");
                o.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                o.SlidingExpiration = true;
            }).AddJwtBearer(cfg =>
            {
                cfg.RequireHttpsMetadata = false;
                cfg.SaveToken = true;

                cfg.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                {
                    ValidIssuer = "https://omrapp.azurewebsites.net",
                    ValidAudience = "https://omrapp.azurewebsites.net",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6LftZ6gUAAAAAD1Ken7Eep9Wv3Z_WISb9lrxh_QN"))
                };
            }); 

            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.AddConfiguration(Configuration.GetSection("Logging"));
                loggingBuilder.AddConsole();
                loggingBuilder.AddDebug();
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<Serenity.Extensions.IEmailSender, Serenity.Extensions.EmailSender>();
            services.AddSingleton<Serenity.Pro.Extensions.IBackgroundJobManager, Serenity.Pro.Extensions.BackgroundJobManager>();
            services.AddServiceHandlers();
            services.AddDynamicScripts();
            services.AddCssBundling();
            services.AddScriptBundling();
            services.AddUploadStorage();
            services.AddSingleton<Administration.IUserPasswordValidator, Administration.UserPasswordValidator>();
            services.AddSingleton<IHttpContextItemsAccessor, HttpContextItemsAccessor>();
            services.AddSingleton<IUserAccessor, Administration.UserAccessor>();
            services.AddSingleton<IUserRetrieveService, Administration.UserRetrieveService>();
            services.AddSingleton<IPermissionService, Administration.PermissionService>();
            services.AddSingleton<INavigationModelFactory, Common.NavigationModelFactory>();
            services.AddSingleton<Administration.ISMSService, Administration.FakeSMSService>();
            services.AddSingleton<IReportRegistry, ReportRegistry>();
            services.AddExcelExporter();
            services.AddSingleton<IDataMigrations, DataMigrations>();
        }

        public static void InitializeLocalTexts(IServiceProvider services)
        {
            var env = services.GetRequiredService<IWebHostEnvironment>();

            services.AddAllTexts(new[]
            {
                Path.Combine(env.WebRootPath, "Scripts", "serenity", "texts"),
                Path.Combine(env.WebRootPath, "Scripts", "site", "texts"),
                Path.Combine(env.ContentRootPath, "App_Data", "texts")
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            RowFieldsProvider.SetDefaultFrom(app.ApplicationServices);
            InitializeLocalTexts(app.ApplicationServices);

            var reqLocOpt = new RequestLocalizationOptions
            {
                SupportedUICultures = UserCultureProvider.SupportedCultures,
                SupportedCultures = UserCultureProvider.SupportedCultures
            };
            reqLocOpt.RequestCultureProviders.Clear();
            reqLocOpt.RequestCultureProviders.Add(new UserCultureProvider());
            app.UseRequestLocalization(reqLocOpt);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            if (!string.IsNullOrEmpty(Configuration["UsePathBase"]))
                app.UsePathBase(Configuration["UsePathBase"]);

            app.UseHttpsRedirection();
            app.UseExceptional();

            if (!env.IsDevelopment())
            {
                app.UseSourceMapSecurity(new()
                {
                    SkipPermission = Configuration["SourceMapSkipPermission"]
                });
            }

            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                RequestPath = "/esm",
                FileProvider = new Serenity.Extensions.NodeLikeModuleResolver(
                    new PhysicalFileProvider(Path.Combine(env.WebRootPath, "esm"))),
                ServeUnknownFileTypes = true,
                DefaultContentType = "text/javascript"
            });

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            ConfigureTestPipeline?.Invoke(app);

            app.UseDynamicScripts();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            var backgroundJobManager = app.ApplicationServices
                .GetRequiredService<Serenity.Pro.Extensions.IBackgroundJobManager>();
            backgroundJobManager.Register(ActivatorUtilities
                .CreateInstance<Serenity.Pro.EmailQueue.EmailQueueJob>(app.ApplicationServices));
            backgroundJobManager.Initialize();

            app.ApplicationServices.GetRequiredService<IDataMigrations>().Initialize();
        }

        public static Action<IApplicationBuilder> ConfigureTestPipeline { get; set; }

        public static void RegisterDataProviders()
        {
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", SqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory("Microsoft.Data.SqlClient", SqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory("Microsoft.Data.Sqlite", Microsoft.Data.Sqlite.SqliteFactory.Instance);

            // to enable FIREBIRD: add FirebirdSql.Data.FirebirdClient reference, set connections, and uncomment line below
            // DbProviderFactories.RegisterFactory("FirebirdSql.Data.FirebirdClient", FirebirdSql.Data.FirebirdClient.FirebirdClientFactory.Instance);

            // to enable MYSQL: add MySql.Data reference, set connections, and uncomment line below
            // DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySql.Data.MySqlClient.MySqlClientFactory.Instance);

            // to enable POSTGRES: add Npgsql reference, set connections, and uncomment line below
            // DbProviderFactories.RegisterFactory("Npgsql", Npgsql.NpgsqlFactory.Instance);
        }
    }
}
