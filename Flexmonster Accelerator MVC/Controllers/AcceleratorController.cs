using Flexmonster.Accelerator.Models;
using System.Web.Http;

namespace Flexmonster_Accelerator_MVC.Controllers
{
    [Authorize]
    public class AcceleratorController : Flexmonster.Accelerator.Controllers.FlexmonsterProxyController
    {

        [HttpGet]
        public IHttpActionResult Test()
        {
            return Ok(User.Identity.Name);
        }

        override public void OnRequest(BaseArgs args)
        {
            args.identity = User.Identity;
        }
    }
}
