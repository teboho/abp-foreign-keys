using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Box.FKs.Authorization;

namespace Box.FKs
{
    [DependsOn(
        typeof(FKsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FKsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FKsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FKsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
