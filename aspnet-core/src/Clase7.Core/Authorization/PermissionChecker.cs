using Abp.Authorization;
using Clase7.Authorization.Roles;
using Clase7.Authorization.Users;

namespace Clase7.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
