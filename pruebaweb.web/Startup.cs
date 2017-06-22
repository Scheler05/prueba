using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pruebaweb.web.Startup))]
namespace pruebaweb.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
