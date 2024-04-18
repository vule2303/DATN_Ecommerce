using ClothingStore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ClothingStore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ClothingStoreEntityFrameworkCoreModule),
    typeof(ClothingStoreApplicationContractsModule)
    )]
public class ClothingStoreDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
