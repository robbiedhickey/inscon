using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootstrapMvcSample.Controllers;
using ClientDashboard.reoSvc;

//using BootstrapMvcSample.Controllers;

namespace Enterprise.Applications.ClientDashboard.Controllers
{
    public class HomeController : BootstrapBaseController
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            REOServiceClient svc = new REOServiceClient("NetTcpBinding_IREOService");
            REOPropertyInfo rpi = new REOPropertyInfo();

            rpi = svc.GetReoPropertyInfo(1, "123456");

            return View(rpi);
        }

        public ActionResult JunkIndex()
        {
            REOServiceClient svc = new REOServiceClient("NetTcpBinding_IREOService");
            REOPropertyInfo rpi = new REOPropertyInfo();

            rpi = svc.GetReoPropertyInfo(1, "123456");

            return View(rpi);
        }
    }
}
