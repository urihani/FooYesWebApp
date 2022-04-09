using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FooYes.Web.Startup))]
namespace FooYes.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
