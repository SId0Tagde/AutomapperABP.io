using Automapping.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Automapping.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AutomappingEntityFrameworkCoreModule),
    typeof(AutomappingApplicationContractsModule)
    )]
public class AutomappingDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
