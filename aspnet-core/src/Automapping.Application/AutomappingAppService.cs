using System;
using System.Collections.Generic;
using System.Text;
using Automapping.Localization;
using Volo.Abp.Application.Services;

namespace Automapping;

/* Inherit your application services from this class.
 */
public abstract class AutomappingAppService : ApplicationService
{
    protected AutomappingAppService()
    {
        LocalizationResource = typeof(AutomappingResource);
    }
}
