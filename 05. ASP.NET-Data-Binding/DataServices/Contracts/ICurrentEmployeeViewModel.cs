using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices.Contracts
{
    public interface ICurrentEmployeeViewModel
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        string Title { get; set; }

        string TitleOfCourtesy { get; set; }

        DateTime? BirthDate { get; set; }

        DateTime? HireDate { get; set; }

        string Address { get; set; }

        string Country { get; set; }

        string City { get; set; }

        byte[] Image { get; set; }
    }
}
