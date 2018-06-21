using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibrerateWeb.Startup))]
namespace LibrerateWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
