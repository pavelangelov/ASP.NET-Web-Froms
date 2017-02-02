using DataServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient.Models
{
    public class AllEmployeesViewModel
    {
        public IEnumerable<ICurrentEmployeeViewModel> Employees { get; set; }
    }
}