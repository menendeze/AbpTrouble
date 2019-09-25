using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ecomercialapp.EntityFramework;

namespace ecomercialapp.Migrator
{
    [DependsOn(typeof(ecomercialappDataModule))]
    public class ecomercialappMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ecomercialappDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}