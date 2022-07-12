using System.Collections.Generic;
using Volo.Abp.Account;
using Volo.Abp.Auditing;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;


namespace Automapping;

[DependsOn(
    typeof(AutomappingDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(AutomappingApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class AutomappingApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<AutomappingApplicationModule>();
        });


    //Needed to install nuget package (Volo.Abp.AspNetCore.Mvc) 
    //For handling custom routing.
        //Configure<Volo.Abp.AspNetCore.Mvc.AbpAspNetCoreMvcOptions>(opts =>
        //{
        //    opts.ConventionalControllers.Create(
        //        typeof(AutomappingApplicationModule).Assembly,
        //        op =>
        //        {
        //            op.RootPath = "SSSS/AAAA";
        //        });
        //});

        Configure<AbpAuditingOptions>(options =>
        {
            options.IsEnabled = true;
            options.IsEnabledForGetRequests = true;
            options.IsEnabledForAnonymousUsers = true;
            //options.IgnoredTypes.;
            options.AlwaysLogOnException = true;
            options.IsEnabled = true;
            //options.AlwaysLogSelectors;
            options.ApplicationName = "WritingAuditingLogs";
            //options.EntityHistorySelectors; 
            options.HideErrors = true;
        });
    }
}
