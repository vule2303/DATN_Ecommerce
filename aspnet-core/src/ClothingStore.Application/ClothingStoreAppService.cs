using System;
using System.Collections.Generic;
using System.Text;
using ClothingStore.Localization;
using Volo.Abp.Application.Services;

namespace ClothingStore;

/* Inherit your application services from this class.
 */
public abstract class ClothingStoreAppService : ApplicationService
{
    protected ClothingStoreAppService()
    {
        LocalizationResource = typeof(ClothingStoreResource);
    }
}
