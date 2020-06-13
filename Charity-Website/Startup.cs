using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Charity_Website.Startup))]
namespace Charity_Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
