using DataServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebClient.Views;
using WebFormsMvp;

namespace WebClient.Presenters
{
    public class AllEmployeesPresenter : Presenter<IAllEmployeesView>
    {
        private IEmployeeDbContext employeesData;

        public AllEmployeesPresenter(IAllEmployeesView view, IEmployeeDbContext employeesData) 
            : base(view)
        {
            this.employeesData = employeesData;

            this.View.PageLoad += View_PageLoad;
        }

        private void View_PageLoad(object sender, EventArgs e)
        {
            this.View.Model.Employees = this.employeesData.GetEmployeeWithDetails();
        }
    }
}