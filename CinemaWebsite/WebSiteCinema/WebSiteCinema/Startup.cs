using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSiteCinema.Startup))]
namespace WebSiteCinema
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
