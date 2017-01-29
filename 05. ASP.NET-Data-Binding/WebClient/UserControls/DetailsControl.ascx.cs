using DataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MobileSite.UserControls
{
    public partial class DetailsControl : System.Web.UI.UserControl
    {
        private EmployeesService employeesData;

        public DetailsControl()
        {
            this.employeesData = new EmployeesService();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["Id"] == null)
            {
                Response.Redirect("Employees");
            }

            int id;
            if (int.TryParse(Request.Params["Id"], out id))
            {
                var employee = this.employeesData.GetEmployeeById(id);

                this.employeeImage.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String(employee.Image);

                this.Details.DataSource = new[] { employee };
                this.Details.DataBind();
            }
        }
    }
}