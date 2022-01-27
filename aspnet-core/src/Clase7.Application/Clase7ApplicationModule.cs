using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Clase7.Authorization;

namespace Clase7
{
    [DependsOn(
        typeof(Clase7CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Clase7ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Clase7AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Clase7ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
