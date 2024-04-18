using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ClothingStore.Data;
using Volo.Abp.DependencyInjection;

namespace ClothingStore.EntityFrameworkCore;

public class EntityFrameworkCoreClothingStoreDbSchemaMigrator
    : IClothingStoreDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreClothingStoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ClothingStoreDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ClothingStoreDbContext>()
            .Database
            .MigrateAsync();
    }
}
