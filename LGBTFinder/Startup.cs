using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LGBTFinder.Startup))]
namespace LGBTFinder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
