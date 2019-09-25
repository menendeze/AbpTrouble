﻿using System.Collections.Generic;
using ecomercialapp.Roles.Dto;

namespace ecomercialapp.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}