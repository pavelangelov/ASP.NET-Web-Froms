using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient.Models
{
    public class EmployeeDetailsEventArgs : EventArgs
    {
        public EmployeeDetailsEventArgs(int id)
        {
            this.Id = id;
        }

        public int Id { get; set; }
    }
}