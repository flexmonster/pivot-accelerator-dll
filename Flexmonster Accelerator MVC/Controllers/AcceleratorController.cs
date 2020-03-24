using Flexmonster_Accelerator_MVC.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace Flexmonster_Accelerator_MVC.Controllers
{
    [AuthAttribute]
    public class AcceleratorController : Flexmonster.Accelerator.Controllers.FlexmonsterProxyController
    {

        public IHttpActionResult Test()
        {
            return Ok("Test");
        }
    }

    class AuthAttribute : AuthorizeAttribute
    {

        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            AcceleratorController.AuthHelper = new WindowsAuthHelper(actionContext.RequestContext.Principal.Identity.Name.ToString().Replace("//", "\\"));
            return true;
        }

    }
}
