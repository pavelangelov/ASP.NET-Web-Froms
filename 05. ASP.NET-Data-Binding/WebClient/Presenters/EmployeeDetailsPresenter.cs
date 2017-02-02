using DataServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebClient.Models;
using WebClient.Views;
using WebFormsMvp;

namespace WebClient.Presenters
{
    public class EmployeeDetailsPresenter : Presenter<IEmployeeDetailsView>
    {
        private IEmployeeDbContext employeesData;

        public EmployeeDetailsPresenter(IEmployeeDetailsView view, IEmployeeDbContext employeesData)
            : base(view)
        {
            this.employeesData = employeesData;

            this.View.PageLoad += View_PageLoad;
        }

        private void View_PageLoad(object sender, EmployeeDetailsEventArgs e)
        {
            var id = e.Id;
            this.View.Model.Employees = this.employeesData.GetEmployeeById(id).ToList();
        }
    }
}