using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Clase7.Configuration;

namespace Clase7.Web.Host.Startup
{
    [DependsOn(
       typeof(Clase7WebCoreModule))]
    public class Clase7WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Clase7WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Clase7WebHostModule).GetAssembly());
        }
    }
}
