using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Task_4.Tic_tac_toe.Startup))]
namespace Task_4.Tic_tac_toe
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
