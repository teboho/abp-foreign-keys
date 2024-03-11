using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Box.FKs.Controllers
{
    public abstract class FKsControllerBase: AbpController
    {
        protected FKsControllerBase()
        {
            LocalizationSourceName = FKsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
