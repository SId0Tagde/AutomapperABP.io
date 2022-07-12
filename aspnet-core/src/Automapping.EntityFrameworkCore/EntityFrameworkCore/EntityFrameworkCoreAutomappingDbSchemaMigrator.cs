using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Automapping.Data;
using Volo.Abp.DependencyInjection;

namespace Automapping.EntityFrameworkCore;

public class EntityFrameworkCoreAutomappingDbSchemaMigrator
    : IAutomappingDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAutomappingDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AutomappingDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AutomappingDbContext>()
            .Database
            .MigrateAsync();
    }
}
