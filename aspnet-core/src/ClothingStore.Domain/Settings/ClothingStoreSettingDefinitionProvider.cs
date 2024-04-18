using Volo.Abp.Settings;

namespace ClothingStore.Settings;

public class ClothingStoreSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ClothingStoreSettings.MySetting1));
    }
}
