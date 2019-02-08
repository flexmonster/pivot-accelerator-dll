using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Flexmonster_Accelerator_MVC.Controllers
{
    public class AcceleratorController : Flexmonster.Accelerator.Controllers.FlexmonsterProxyController
    {
        public IHttpActionResult Test()
        {
            return Ok("Test");
        }
    }
}
