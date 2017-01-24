using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Task_3.Students_and_Courses.Models;

namespace Task_3.Students_and_Courses
{
    public partial class StudentRegistration : System.Web.UI.Page
    {
        public StudentModel Student { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            this.Student = new StudentModel();
            this.Student.FirstName = this.FirstName.Text;
            this.Student.LastName = this.LastName.Text;
            this.Student.FacultyNumber = this.FacultyNumber.Text;
            this.Student.University = this.University.SelectedValue;
            this.Student.Speciality = this.Specialty.SelectedValue;
            foreach (var item in this.Courses.Items.Cast<ListItem>())
            {
                if (item.Selected)
                {
                    this.Student.Courses.Add(item.Value);
                }
            }

            Server.Transfer("SuccessRegistration.aspx");
        }
    }
}