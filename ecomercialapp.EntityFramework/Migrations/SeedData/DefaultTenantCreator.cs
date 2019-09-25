using System.Linq;
using ecomercialapp.EntityFramework;
using ecomercialapp.MultiTenancy;

namespace ecomercialapp.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ecomercialappDbContext _context;

        public DefaultTenantCreator(ecomercialappDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
