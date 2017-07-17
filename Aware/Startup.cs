using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aware.Startup))]
namespace Aware
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
