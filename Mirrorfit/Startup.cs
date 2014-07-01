using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mirrorfit.Startup))]
namespace Mirrorfit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
