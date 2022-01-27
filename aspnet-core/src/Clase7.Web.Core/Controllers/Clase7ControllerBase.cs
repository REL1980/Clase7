using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Clase7.Controllers
{
    public abstract class Clase7ControllerBase: AbpController
    {
        protected Clase7ControllerBase()
        {
            LocalizationSourceName = Clase7Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
