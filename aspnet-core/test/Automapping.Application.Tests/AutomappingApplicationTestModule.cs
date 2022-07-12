using Volo.Abp.Modularity;

namespace Automapping;

[DependsOn(
    typeof(AutomappingApplicationModule),
    typeof(AutomappingDomainTestModule)
    )]
public class AutomappingApplicationTestModule : AbpModule
{

}
