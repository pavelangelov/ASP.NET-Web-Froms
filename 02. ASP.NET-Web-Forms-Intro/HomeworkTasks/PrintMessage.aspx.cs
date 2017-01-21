using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeworkTasks
{
    public partial class PrintMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.MessageBox.Text = "Hello, ASP.NET";
        }

        protected void ShowAssemblyLocation(object sender, EventArgs e)
        {
            var info = Assembly.GetExecutingAssembly().Location;

            this.assemblyInfo.Text = info;
        }
    }
}