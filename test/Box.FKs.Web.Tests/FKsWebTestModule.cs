using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Box.FKs.EntityFrameworkCore;
using Box.FKs.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Box.FKs.Web.Tests
{
    [DependsOn(
        typeof(FKsWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class FKsWebTestModule : AbpModule
    {
        public FKsWebTestModule(FKsEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FKsWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(FKsWebMvcModule).Assembly);
        }
    }
}