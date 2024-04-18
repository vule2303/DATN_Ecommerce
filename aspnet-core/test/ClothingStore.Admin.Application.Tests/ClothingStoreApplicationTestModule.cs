using Volo.Abp.Modularity;

namespace ClothingStore.Admin;

[DependsOn(
    typeof(ClothingStoreAdminApplicationModule),
    typeof(ClothingStoreDomainTestModule)
    )]
public class ClothingStoreApplicationTestModule : AbpModule
{

}
