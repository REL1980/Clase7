using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using Clase7.Authorization.Roles;
using Clase7.Authorization.Users;
using Clase7.MultiTenancy;
using Microsoft.Extensions.Logging;
using Abp.Domain.Uow;

namespace Clase7.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory,
            IUnitOfWorkManager unitOfWorkManager)
            : base(options, signInManager, systemClock, loggerFactory, unitOfWorkManager)
        {
        }
    }
}
