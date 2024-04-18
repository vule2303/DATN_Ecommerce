using ClothingStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ClothingStore.Admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ClothingStoreController : AbpControllerBase
{
    protected ClothingStoreController()
    {
        LocalizationResource = typeof(ClothingStoreResource);
    }
}
