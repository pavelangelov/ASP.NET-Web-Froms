using DataServices;
using DataServices.Contracts;
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

namespace MobileSite.UserControls
{
    [PresenterBinding(typeof(EmployeesPresenter))]
    public partial class EmployeesControl : MvpUserControl<EmployeesViewModel>, IEmployeesView
    {
        public event EventHandler PageLoad;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.PageLoad?.Invoke(sender, e);

                this.Employees.DataSource = this.Model.Employees;
                this.Employees.DataBind();
            }
        }
    }
}