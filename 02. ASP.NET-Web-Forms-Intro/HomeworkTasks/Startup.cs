using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeworkTasks.Startup))]
namespace HomeworkTasks
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
