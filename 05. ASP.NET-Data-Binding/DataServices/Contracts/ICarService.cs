using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices.Contracts
{
    public interface ICarService
    {
        IEnumerable<string> GetProducers();

        IEnumerable<string> GetModelsByProducer(string producer);

        IEnumerable<string> GetExtras();
    }
}
