using Abp.Authorization;
using ecomercialapp.Authorization.Roles;
using ecomercialapp.Authorization.Users;

namespace ecomercialapp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
