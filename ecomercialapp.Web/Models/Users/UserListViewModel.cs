using System.Collections.Generic;
using ecomercialapp.Roles.Dto;
using ecomercialapp.Users.Dto;

namespace ecomercialapp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}