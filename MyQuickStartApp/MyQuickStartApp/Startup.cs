using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyQuickStartApp.Startup))]
namespace MyQuickStartApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
