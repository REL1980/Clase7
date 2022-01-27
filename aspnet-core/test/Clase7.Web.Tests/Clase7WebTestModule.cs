using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Clase7.EntityFrameworkCore;
using Clase7.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Clase7.Web.Tests
{
    [DependsOn(
        typeof(Clase7WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class Clase7WebTestModule : AbpModule
    {
        public Clase7WebTestModule(Clase7EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Clase7WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(Clase7WebMvcModule).Assembly);
        }
    }
}