using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApiConsulting.Startup))]
namespace ApiConsulting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
