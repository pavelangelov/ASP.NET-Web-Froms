using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Task_5.Web_Calculator.Startup))]
namespace Task_5.Web_Calculator
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
