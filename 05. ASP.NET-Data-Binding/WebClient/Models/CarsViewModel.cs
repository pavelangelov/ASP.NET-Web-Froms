using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient.Models
{
    public class CarsViewModel
    {
        public IEnumerable<string> Producers { get; set; }

        public IEnumerable<string> Models { get; set; }

        public IEnumerable<string> Extras { get; set; }
    }
}