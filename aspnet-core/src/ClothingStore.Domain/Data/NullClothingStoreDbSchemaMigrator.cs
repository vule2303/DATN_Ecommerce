using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ClothingStore.Data;

/* This is used if database provider does't define
 * IClothingStoreDbSchemaMigrator implementation.
 */
public class NullClothingStoreDbSchemaMigrator : IClothingStoreDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
