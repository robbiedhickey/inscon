using System.Web.Routing;
using BootstrapMvcSample.Controllers;
using ClientDashboard.Controllers;
using NavigationRoutes;

namespace BootstrapMvcSample
{
    public class ExampleLayoutsRouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapNavigationRoute<ClaimsController>("Hazard Claims", c => c.Empty()) 
                   .AddChildRoute<ClaimsController>("View Scaffolding", c => c.Index())
                   .AddChildRoute<ClaimsController>("View Claim", c => c.ReadOnly());

            routes.MapNavigationRoute<ExampleLayoutsController>("Example Layouts", c => c.Starter())
                  .AddChildRoute<ExampleLayoutsController>("Marketing", c => c.Marketing())
                  .AddChildRoute<ExampleLayoutsController>("Fluid", c => c.Fluid())
                  .AddChildRoute<ExampleLayoutsController>("Sign In", c => c.SignIn())
                ;
        }
    }
}
