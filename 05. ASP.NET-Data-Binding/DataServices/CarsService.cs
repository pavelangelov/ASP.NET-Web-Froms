using DataServices.Contracts;
using DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices
{
    public class CarsService
    {
        private ICollection<IProducer> producers;

        public CarsService()
        {
            GenerateProducers();
        }

        public string[] GetProducers()
        {
            var producers = this.producers.Select(p => p.Name).ToArray();

            return producers;
        }

        public IEnumerable<string> GetModelsByProducer(string producer)
        {
            var currentBrand = this.producers.FirstOrDefault(x => x.Name == producer);

            return currentBrand.Models;
        }

        public IEnumerable<string> GetExtras()
        {
            var extras = new[]
            {
                "4x4",
                "Clima",
                "Alarm",
                "Air bag",
                "Leather",
                "Navigation"
            };

            return extras;
        }

        private void GenerateProducers()
        {
            this.producers = new List<IProducer>();
            this.producers.Add(new Producer("Alfa Romeo", new[] { "149", "156", "159", "169" }));
            this.producers.Add(new Producer("Audi", new[] { "A2", "A3", "A4", "A5", "A6", "A8" }));
            this.producers.Add(new Producer("BMW", new[] { "320", "520", "640", "M6" }));
            this.producers.Add(new Producer("Fiat", new[] { "Brava", "Bravo", "Tipo", "500" }));
            this.producers.Add(new Producer("Opel", new[] { "Astra", "Corsa", "Omega", "Signum", "Vectra" }));
            this.producers.Add(new Producer("Skoda", new[] { "Fabia", "Octavia", "Superb" }));
            this.producers.Add(new Producer("VW", new[] { "Caddy", "Golf", "Passat", "Polo" }));
        }
    }
}
