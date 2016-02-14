using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolApp.Web.Startup))]
namespace SchoolApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
