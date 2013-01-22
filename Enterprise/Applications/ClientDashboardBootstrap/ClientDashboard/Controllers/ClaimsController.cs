using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootstrapMvcSample.Controllers;

namespace ClientDashboard.Controllers
{
    public class ClaimsController : BootstrapBaseController
    {
        //
        // GET: /Claims/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReadOnly()
        {
            return View();
        }

    }
}
