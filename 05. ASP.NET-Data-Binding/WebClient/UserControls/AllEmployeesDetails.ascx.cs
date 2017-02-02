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
    [PresenterBinding(typeof(AllEmployeesPresenter))]
    public partial class AllEmployeesDetails : MvpUserControl<AllEmployeesViewModel>, IAllEmployeesView
    {
        public event EventHandler PageLoad;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.PageLoad?.Invoke(sender, e);

            this.EmployeesRepeater.DataSource = this.Model.Employees.ToList();
            this.EmployeesRepeater.DataBind();
        }
    }
}