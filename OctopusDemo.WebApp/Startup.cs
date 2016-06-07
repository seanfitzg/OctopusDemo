using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OctopusDemo.WebApp.Startup))]
namespace OctopusDemo.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
