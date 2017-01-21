using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeworkTasks
{
    public partial class PrintName : System.Web.UI.Page
    {
        private string EmptyNameMessage = "Name must have more than 1 symbol!";
        private int NameMinLength = 2;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            var name = this.InputName.Text;
            if (name == null || name.Length < this.NameMinLength)
            {
                this.Result.Text = this.EmptyNameMessage;
            }
            else
            {
                this.Result.Text = $"Hello {name}";
            }
        }
    }
}