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

        private int entfernungMond = 385000;
        
        public Mondreise(double speedkmh)
        {
            kmh = speedkmh;
        }


        public double GetTravelDurationDays()
        {
            return this.GetTravelDurationHours() / 24;
        }

        public double GetTravelDurationHours()
        {
            return entfernungMond / 24;
        }

    }
}
