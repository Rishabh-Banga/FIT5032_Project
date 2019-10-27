using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Steercar_proj.Startup))]
namespace Steercar_proj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
