using ClothingStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ClothingStore.Admin.Permissions;

public class ClothingStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ClothingStorePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ClothingStorePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ClothingStoreResource>(name);
    }
}
