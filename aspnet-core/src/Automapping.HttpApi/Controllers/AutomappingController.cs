using Automapping.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Automapping.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AutomappingController : AbpControllerBase
{
    protected AutomappingController()
    {
        LocalizationResource = typeof(AutomappingResource);
    }
}
