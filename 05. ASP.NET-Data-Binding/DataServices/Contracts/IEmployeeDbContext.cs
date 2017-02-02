using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices.Contracts
{
    public interface IEmployeeDbContext
    {
        IEnumerable<IEmployeeViewModel> GetAllEmployees();

        IEnumerable<ICurrentEmployeeViewModel> GetEmployeeById(int id);

        IEnumerable<ICurrentEmployeeViewModel> GetEmployeeWithDetails();
    }
}
