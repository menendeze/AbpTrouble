﻿using ecomercialapp.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ecomercialapp.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ecomercialappDbContext _context;

        public InitialHostDbBuilder(ecomercialappDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
