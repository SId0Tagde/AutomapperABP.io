using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Automapping;

[Dependency(ReplaceServices = true)]
public class AutomappingBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Automapping";
}
