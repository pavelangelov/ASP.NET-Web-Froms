using DataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.Models;
using WebClient.Presenters;
using WebClient.Views;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace WebClient.UserControls
{
    [PresenterBinding(typeof(EmployeeDetailsPresenter))]
    public partial class EmployeeDetails : MvpUserControl<EmployeeDetailsViewModel>, IEmployeeDetailsView
    {
        public event EventHandler<EmployeeDetailsEventArgs> PageLoad;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["Id"] == null)
            {
                Response.Redirect("Employees");
            }

            int id;
            if (int.TryParse(Request.Params["Id"], out id))
            {
                this.PageLoad?.Invoke(sender, new EmployeeDetailsEventArgs(id));

                this.Details.DataSource = this.Model.Employees;
                this.Details.DataBind();
            }
        }
    }
}