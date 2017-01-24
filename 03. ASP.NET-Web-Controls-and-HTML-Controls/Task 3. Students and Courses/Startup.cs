using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Task_3.Students_and_Courses.Startup))]
namespace Task_3.Students_and_Courses
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
