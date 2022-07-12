using Automapping.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Automapping;

[DependsOn(
    typeof(AutomappingEntityFrameworkCoreTestModule)
    )]
public class AutomappingDomainTestModule : AbpModule
{

}
