using DataServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices.Models
{
    public class Producer : IProducer
    {
        public Producer(string name, IEnumerable<string> models)
        {
            this.Name = name;
            this.Models = models;
        }

        public IEnumerable<string> Models { get; private set; }

        public string Name { get; private set; }
    }
}
