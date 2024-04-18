using System.Threading.Tasks;

namespace ClothingStore.Data;

public interface IClothingStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
