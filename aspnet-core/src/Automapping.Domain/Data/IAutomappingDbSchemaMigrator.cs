using System.Threading.Tasks;

namespace Automapping.Data;

public interface IAutomappingDbSchemaMigrator
{
    Task MigrateAsync();
}
