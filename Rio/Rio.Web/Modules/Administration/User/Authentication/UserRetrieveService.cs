using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using System;
using System.Data;
using System.Globalization;
using System.Security.Claims;
using System.Security.Principal;
using MyRow = Rio.Administration.UserRow;

namespace Rio.Administration
{
    public class UserRetrieveService : IUserRetrieveService
    {
        private static MyRow.RowFields Fld { get { return MyRow.Fields; } }

        protected ITwoLevelCache Cache { get; }
        protected ISqlConnections SqlConnections { get; }

        public UserRetrieveService(ITwoLevelCache cache, ISqlConnections sqlConnections)
        {
            Cache = cache;
            SqlConnections = sqlConnections;
        }

        private static UserDefinition GetFirst(IDbConnection connection, BaseCriteria criteria)
        {
            var user = connection.TrySingle<MyRow>(criteria);

            if (user != null)
            {
                UserDefinition userDefinition = new UserDefinition();
                var userpermission = connection.TryFirst<UserRoleRow>(UserRoleRow.Fields.UserId == user.UserId.Value);
                if (userpermission != null)
                {
                    if (userDefinition.RoleId != 0)
                    {
                        userDefinition.RoleId = userpermission.RoleId.Value;
                        var role = connection.TryFirst<RoleRow>(RoleRow.Fields.RoleId == userpermission.RoleId.Value);
                        userDefinition.RoleName = role.RoleName;
                    }
                }


                userDefinition.UserId = user.UserId.Value;
                userDefinition.Username = user.Username;
                userDefinition.Email = user.Email;
                userDefinition.MobilePhoneNumber = user.MobilePhoneNumber;
                userDefinition.MobilePhoneVerified = user.MobilePhoneVerified ?? false;
                userDefinition.TwoFactorAuth = user.TwoFactorAuth;
                userDefinition.UserImage = user.UserImage;
                userDefinition.DisplayName = user.DisplayName;
                userDefinition.IsActive = user.IsActive.Value;
                userDefinition.Source = user.Source;
                userDefinition.PasswordHash = user.PasswordHash;
                userDefinition.PasswordSalt = user.PasswordSalt;
                userDefinition.UpdateDate = user.UpdateDate;
                userDefinition.LastDirectoryUpdate = user.LastDirectoryUpdate;
                userDefinition.TenantId = user.TenantId.Value;
            
                return userDefinition;
            }
           
            return null;
        }

        public IUserDefinition ById(string id)
        {
            return Cache.Get("UserByID_" + id, TimeSpan.Zero, TimeSpan.FromDays(1), Fld.GenerationKey, () =>
            {
                using var connection = SqlConnections.NewByKey("Default");
                return GetFirst(connection, new Criteria(Fld.UserId) == int.Parse(id, CultureInfo.InvariantCulture));
            });
        }

        public IUserDefinition ByUsername(string username)
        {
            if (username.IsEmptyOrNull())
                return null;

            return Cache.Get("UserByName_" + username.ToLowerInvariant(),
                TimeSpan.Zero, TimeSpan.FromDays(1), Fld.GenerationKey, () =>
            {
                using var connection = SqlConnections.NewByKey("Default");
                return GetFirst(connection, new Criteria(Fld.Username) == username);
            });
        }

        public static void RemoveCachedUser(ITwoLevelCache cache, int? userId, string username)
        {
            if (userId != null)
                cache.Remove("UserByID_" + userId);

            if (username != null)
                cache.Remove("UserByName_" + username.ToLowerInvariant());
        }

        public static ClaimsPrincipal CreatePrincipal(IUserRetrieveService userRetriever, string username,
            string authType)
        {
            if (userRetriever is null)
                throw new ArgumentNullException(nameof(userRetriever));

            if (username is null)
                throw new ArgumentNullException(nameof(username));

            var user = (UserDefinition)userRetriever.ByUsername(username);
            if (user == null)
                throw new ArgumentOutOfRangeException(nameof(username));

            if (authType == null)
                throw new ArgumentNullException(nameof(authType));

            var identity = new GenericIdentity(username, authType);
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id));
            identity.AddClaim(new Claim("TenantId", user.TenantId.ToInvariant())); // add tenant id claim

            return new ClaimsPrincipal(identity);
        }
    }
}