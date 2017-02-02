using DataServices.Contracts;
using DataServices.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient.Models
{
    public class EmployeesViewModel
    {
        public IEnumerable<IEmployeeViewModel> Employees { get; set; }
    }
}