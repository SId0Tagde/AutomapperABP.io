using Automapping.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Automapping.Permissions;

public class AutomappingPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AutomappingPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AutomappingPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AutomappingResource>(name);
    }
}
