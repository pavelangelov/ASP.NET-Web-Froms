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
    public class EmployeesService : IEmployeeDbContext
    {
        private NORTHWNDEntities dbContext;

        public EmployeesService(NORTHWNDEntities dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<IEmployeeViewModel> GetAllEmployees()
        {
            var employees = this.dbContext.Employees.Select(e => new EmployeeViewModel()
            {
                Id = e.EmployeeID,
                Name = e.FirstName + " " + e.LastName
            }).ToArray();

            return employees;
        }

        public IEnumerable<ICurrentEmployeeViewModel> GetEmployeeById(int id)
        {
            var employees = this.dbContext.Employees.Where(e => e.EmployeeID == id)
                                                    .Select(em => new CurrentEmployeeViewModel()
                                                    {
                                                        FirstName = em.FirstName,
                                                        LastName = em.LastName,
                                                        Address = em.Address,
                                                        Country = em.Country,
                                                        City = em.City,
                                                        BirthDate = em.BirthDate,
                                                        HireDate = em.HireDate,
                                                        Title = em.Title,
                                                        TitleOfCourtesy = em.TitleOfCourtesy,
                                                        Image = em.Photo
                                                    });
            

            return employees;
        }

        public IEnumerable<ICurrentEmployeeViewModel> GetEmployeeWithDetails()
        {
            var employees = this.dbContext.Employees.Select(em => new CurrentEmployeeViewModel()
                                                    {
                                                        FirstName = em.FirstName,
                                                        LastName = em.LastName,
                                                        Address = em.Address,
                                                        Country = em.Country,
                                                        City = em.City,
                                                        BirthDate = em.BirthDate,
                                                        HireDate = em.HireDate,
                                                        Title = em.Title,
                                                        TitleOfCourtesy = em.TitleOfCourtesy,
                                                        Image = em.Photo
                                                    });


            return employees;
        }
    }
}
