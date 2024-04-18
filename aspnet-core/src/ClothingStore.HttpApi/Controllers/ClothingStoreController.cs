using ClothingStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ClothingStore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ClothingStoreController : AbpControllerBase
{
    protected ClothingStoreController()
    {
        LocalizationResource = typeof(ClothingStoreResource);
    }
}
