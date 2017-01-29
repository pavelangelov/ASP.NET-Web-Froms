using DataServices.Contracts;
using DataServices.Data;
using DataServices.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices
{
    public class EmployeesService
    {
        private NORTHWNDEntities db;

        public EmployeesService()
        {
            this.db = new NORTHWNDEntities();
        }

        public IEnumerable<IEmployeeViewModel> GetAllEmployees()
        {
            var employees = this.db.Employees.Select(e => new EmployeeViewModel() { Id = e.EmployeeID,
            Name = e.FirstName + " " +  e.LastName}).ToArray();

            return employees;
        }

        public ICurrentEmployeeViewModel GetEmployeeById(int id)
        {
            var dbEmployee = this.db.Employees.FirstOrDefault(e => e.EmployeeID == id);
            var employee = new CurrentEmployeeViewModel();
            employee.FirstName = dbEmployee.FirstName;
            employee.LastName = dbEmployee.LastName;
            employee.Address = dbEmployee.Address;
            employee.Country = dbEmployee.Country;
            employee.City = dbEmployee.City;
            employee.BirthDate = dbEmployee.BirthDate;
            employee.HireDate = dbEmployee.HireDate;
            employee.Title = dbEmployee.Title;
            employee.TitleOfCourtesy = dbEmployee.TitleOfCourtesy;
            employee.Image = dbEmployee.Photo;

            return employee;
        }
    }
}
