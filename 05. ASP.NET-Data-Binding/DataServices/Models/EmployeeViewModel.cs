using DataServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices.Models
{
    public class EmployeeViewModel : IEmployeeViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
