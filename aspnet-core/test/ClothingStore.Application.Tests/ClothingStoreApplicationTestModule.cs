using Volo.Abp.Modularity;

namespace ClothingStore;

[DependsOn(
    typeof(ClothingStoreApplicationModule),
    typeof(ClothingStoreDomainTestModule)
    )]
public class ClothingStoreApplicationTestModule : AbpModule
{

}
