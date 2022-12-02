using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reisedauer_Mond
{
    internal class Mondreise
    {
        private double kmh = 0;
        
        public Mondreise(double kmh)
        {

        }

        public double ReiseTage()
        {

        }

        public double ReiseStunden()
        {
            return this.ReiseTage() / 24;
        }

    }
}
