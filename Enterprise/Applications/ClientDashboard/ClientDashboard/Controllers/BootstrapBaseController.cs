using System.Web.Mvc;
using BootstrapSupport;

namespace BootstrapMvcSample.Controllers
{
    using System.Web;

    public class BootstrapBaseController: Controller
    {
        public void Attention(string message)
        {
            TempData.Add(Alerts.ATTENTION, message);
        }

        public void Success(string message)
        {
            TempData.Add(Alerts.SUCCESS, message);
        }

        public void Information(string message)
        {
            TempData.Add(Alerts.INFORMATION, message);
        }

        public void Error(string message)
        {
            TempData.Add(Alerts.ERROR, message);
        }

        public void Attention(HtmlString message)
        {
            TempData.Add(Alerts.ATTENTION, message);
        }

        public void Success(HtmlString message)
        {
            TempData.Add(Alerts.SUCCESS, message);
        }

        public void Information(HtmlString message)
        {
            TempData.Add(Alerts.INFORMATION, message);
        }

        public void Error(HtmlString message)
        {
            TempData.Add(Alerts.ERROR, message);
        }
    }
}
