using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DailyBazar.Web.Startup))]
namespace DailyBazar.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
