using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using ecomercialapp.EntityFramework;

namespace ecomercialapp
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(ecomercialappCoreModule))]
    public class ecomercialappDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ecomercialappDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
