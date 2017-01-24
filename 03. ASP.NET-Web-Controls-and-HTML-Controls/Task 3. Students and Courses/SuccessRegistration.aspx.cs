using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Task_3.Students_and_Courses
{
    public partial class SuccessRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var sourcePage = (StudentRegistration)Context.Handler;
                var content = new HtmlGenericControl("ul");
                content.Attributes["class"] = "list-group";

                AttachStudentInfo(sourcePage, content);

                this.Result.Controls.Add(content);
            }
        }

        private void AttachStudentInfo(StudentRegistration source, HtmlGenericControl container)
        {
            var student = source.Student;

            var firstName = new HtmlGenericControl("li");
            firstName.InnerHtml = $"First name: {student.FirstName}";
            firstName.Attributes["class"] = "list-group-item";

            var lastName = new HtmlGenericControl("li");
            lastName.InnerHtml = $"Last name: {student.LastName}";
            lastName.Attributes["class"] = "list-group-item";

            var facultyNumber = new HtmlGenericControl("li");
            facultyNumber.InnerHtml = $"Faculty number: {student.FacultyNumber}";
            facultyNumber.Attributes["class"] = "list-group-item";

            var university = new HtmlGenericControl("li");
            university.InnerHtml = $"University: {student.University}";
            university.Attributes["class"] = "list-group-item";

            var speciality = new HtmlGenericControl("li");
            speciality.InnerHtml = $"Speciality: {student.Speciality}";
            speciality.Attributes["class"] = "list-group-item";

            var courses = new HtmlGenericControl("li");
            var coursesStr = student.Courses.Count > 0 ? string.Join(", ", student.Courses) : "This Student doesn`t have recorded courses.";
            courses.InnerHtml = $"Speciality: {coursesStr}";
            courses.Attributes["class"] = "list-group-item";

            container.Controls.Add(firstName);
            container.Controls.Add(lastName);
            container.Controls.Add(facultyNumber);
            container.Controls.Add(university);
            container.Controls.Add(speciality);
            container.Controls.Add(courses);
        }
    }
}