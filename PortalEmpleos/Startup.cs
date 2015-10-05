using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortalEmpleos.Startup))]
namespace PortalEmpleos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
