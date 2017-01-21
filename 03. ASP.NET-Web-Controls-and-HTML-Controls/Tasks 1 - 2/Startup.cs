using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tasks_1___2.Startup))]
namespace Tasks_1___2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
