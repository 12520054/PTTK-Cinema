using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CinemaWebsite.Startup))]
namespace CinemaWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
