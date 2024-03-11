using Abp.Authorization;
using Box.FKs.Authorization.Roles;
using Box.FKs.Authorization.Users;

namespace Box.FKs.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
