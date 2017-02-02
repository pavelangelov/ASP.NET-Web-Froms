using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClient.Models;
using WebFormsMvp;

namespace WebClient.Views
{
    public interface IEmployeesView : IView<EmployeesViewModel>
    {
        event EventHandler PageLoad;
    }
}
