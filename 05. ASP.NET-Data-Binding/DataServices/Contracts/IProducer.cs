using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices.Contracts
{
    public interface IProducer
    {
        string Name { get; }

        IEnumerable<string> Models { get; }
    }
}
