using Flexmonster.Accelerator.Models;

namespace Flexmonster_Accelerator_MVC.Controllers
{
    public class AcceleratorController : Flexmonster.Accelerator.Controllers.FlexmonsterProxyController
    {
        public override void OnRequest(BaseArgs args)
        {
            base.OnRequest(args);
        }
    }
}
