using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SlidingTemplate.Startup))]
namespace SlidingTemplate
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
