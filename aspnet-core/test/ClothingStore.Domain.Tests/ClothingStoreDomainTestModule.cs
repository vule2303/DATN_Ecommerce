using ClothingStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ClothingStore;

[DependsOn(
    typeof(ClothingStoreEntityFrameworkCoreTestModule)
    )]
public class ClothingStoreDomainTestModule : AbpModule
{

}
