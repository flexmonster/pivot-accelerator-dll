using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flexmonster_Accelerator_MVC.App_Start
{
    public class FlexmonsterConfig
    {
        public static void Register()
        {
            // Replace with actual data source. 
            // Example: Data Source=localhost
            Flexmonster.Accelerator.Controllers.FlexmonsterProxyController.ConnectionString = "Data Source=https://olap.flexmonster.com/olap/msmdpump.dll";
            Flexmonster.Accelerator.Utils.CacheManager.MemoryLimit = 10 * 1024 * 1024; // Mb to bytes
            Flexmonster.Accelerator.Utils.CacheManager.Enabled = true;
            //Flexmonster.Accelerator.Utils.LoggerLocator.SetLogger(new Flexmonster.Accelerator.Utils.ILogger());
        }
    }
}