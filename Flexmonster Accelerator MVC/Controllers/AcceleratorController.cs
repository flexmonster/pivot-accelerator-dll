using Flexmonster.Accelerator.Models;
using System.Security.Principal;

namespace Flexmonster_Accelerator_MVC.Controllers
{
    public class AcceleratorController : Flexmonster.Accelerator.Controllers.FlexmonsterProxyController
    {
        protected override void SetPrincipal(BaseArgs args, IPrincipal principal)
        {
            if (principal != null)
            {
                // set user name/email here
                // should be Base64 encoded string in "<usrename>:<password>" fromat
                args.credentials = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("xxx"));
            }
            base.SetPrincipal(args, principal);
        }

        public override void OnRequest(BaseArgs args)
        {
            base.OnRequest(args);
        }
    }
}
