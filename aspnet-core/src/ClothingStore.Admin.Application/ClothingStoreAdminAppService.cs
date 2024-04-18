using System;
using System.Collections.Generic;
using System.Text;
using ClothingStore.Localization;
using Volo.Abp.Application.Services;

namespace ClothingStore.Admin;

/* Inherit your application services from this class.
 */
public abstract class ClothingAdminStoreAppService : ApplicationService
{
    protected ClothingAdminStoreAppService()
    {
        LocalizationResource = typeof(ClothingStoreResource);
    }
}
