using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ws.Startup))]
namespace ws
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
