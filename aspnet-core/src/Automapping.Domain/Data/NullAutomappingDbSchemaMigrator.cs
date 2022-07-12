using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Automapping.Data;

/* This is used if database provider does't define
 * IAutomappingDbSchemaMigrator implementation.
 */
public class NullAutomappingDbSchemaMigrator : IAutomappingDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
