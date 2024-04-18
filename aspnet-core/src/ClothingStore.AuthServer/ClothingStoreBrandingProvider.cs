using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ClothingStore;

[Dependency(ReplaceServices = true)]
public class ClothingStoreBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ClothingStore";
}
