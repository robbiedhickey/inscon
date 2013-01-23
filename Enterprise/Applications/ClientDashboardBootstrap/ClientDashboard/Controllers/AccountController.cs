using System;
using System.Collections.Generic;
using System.IdentityModel.Services;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientDashboard.Controllers
{
    public class AccountController : Controller
    {
        public void LogOff()
        {
            FederatedAuthentication.WSFederationAuthenticationModule.SignOut("/");
        }
    }
}
