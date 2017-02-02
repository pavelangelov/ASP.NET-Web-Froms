using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient.Models
{
    public class CarsEventArgs : EventArgs
    {
        public CarsEventArgs(string producer)
        {
            this.SelectedProducer = producer;
        }

        public string SelectedProducer { get; set; }
    }
}