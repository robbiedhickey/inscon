using System;
using System.Collections.Generic;
using System.IdentityModel.Services;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace ClientDashboard.Controllers
{
    public class AccountController : Controller
    {
        public string ViewClaims()
        {
            var principal = Thread.CurrentPrincipal as ClaimsPrincipal;

            var sb = new StringBuilder();
            sb.AppendLine("<table>");
            foreach (var claim in principal.Claims)
            {
                sb.AppendLine("<tr>");
                sb.Append(String.Format("<td>Type: {0}</td><td> Value: {1}</td>", claim.Type, claim.Value));
                sb.AppendLine("</tr>");
            }
            sb.AppendLine("</table>");

            return sb.ToString();


        }
    }
}
