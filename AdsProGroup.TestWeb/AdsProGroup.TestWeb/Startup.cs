using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdsProGroup.TestWeb.Startup))]
namespace AdsProGroup.TestWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
