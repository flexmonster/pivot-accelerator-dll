using Flexmonster.Accelerator.Models;
using Flexmonster.Accelerator.Utils.Impersonation;
using System.Security.Principal;

namespace Flexmonster_Accelerator_MVC.App_Start
{
    public class FlexmonsterConfig
    {
        public static void Register()
        {
            // Replace with actual data source. 
            // Example: Data Source=localhost
            Flexmonster.Accelerator.Controllers.FlexmonsterProxyController.ConnectionString = "Data Source=localhost\\MD19;";
            Flexmonster.Accelerator.Controllers.FlexmonsterProxyController.Impersonator = new WinImpersonatorFactory();
            Flexmonster.Accelerator.Utils.CacheManager.MemoryLimit = 10 * 1024 * 1024; // Mb to bytes
            Flexmonster.Accelerator.Utils.CacheManager.Enabled = true;
            //Flexmonster.Accelerator.Utils.LoggerLocator.SetLogger(new Flexmonster.Accelerator.Utils.ILogger());
        }
    }

    public class WinImpersonatorFactory : IImpersonatorFactory
    {
        public IImpersonator GetImpersonator(BaseArgs args)
        {
            return new WinImpersonator(args.identity as WindowsIdentity);
        }
    }

    public class WinImpersonator : IImpersonator
    {
        public WinImpersonator(WindowsIdentity identity)
        {
            Impersonate(identity);
        }

        public void Impersonate(WindowsIdentity identity)
        {
            if (identity != null)
            {
                identity.Impersonate();
            }
        }

        public void Dispose() { }
    }
}