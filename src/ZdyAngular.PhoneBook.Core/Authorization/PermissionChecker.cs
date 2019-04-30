using Abp.Authorization;
using ZdyAngular.PhoneBook.Authorization.Roles;
using ZdyAngular.PhoneBook.Authorization.Users;

namespace ZdyAngular.PhoneBook.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
