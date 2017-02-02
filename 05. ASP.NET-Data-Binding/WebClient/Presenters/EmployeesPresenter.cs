using DataServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebClient.Views;
using WebFormsMvp;

namespace WebClient.Presenters
{
    public class EmployeesPresenter : Presenter<IEmployeesView>
    {
        private IEmployeeDbContext employeesData;

        public EmployeesPresenter(IEmployeesView view, IEmployeeDbContext employeesData) 
            : base(view)
        {
            this.employeesData = employeesData;

            this.View.PageLoad += View_PageLoad;
        }

        private void View_PageLoad(object sender, EventArgs e)
        {
            this.View.Model.Employees = this.employeesData.GetAllEmployees();
        }
    }
}