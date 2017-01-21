using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tasks_1___2.Utils
{
    public class RandomGenerator
    {
        public int RandomNumber(int min, int max)
        {
            var rand = new Random();
            var number = rand.Next(min, max);

            return number;
        }
    }
}