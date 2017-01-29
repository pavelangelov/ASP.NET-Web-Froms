using DataServices;
using DataServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MobileSite.UserControls
{
    public partial class EmployeesControl : System.Web.UI.UserControl
    {
        private EmployeesService employeesData;

        public EmployeesControl()
        {
            this.employeesData = new EmployeesService();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var employees = this.employeesData.GetAllEmployees();

                this.Employees.DataSource = employees;
                this.Employees.DataBind();
            }
        }
    }
}