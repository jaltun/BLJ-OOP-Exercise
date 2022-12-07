using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Simulator
{
    public class Auto
    {
        public string Marke
        {
            get;
            private set;
        }
        public int PS
        {
            get;
            private set;
        }
        public int AktuelleGeschwindigkeit
        {
            get;
            private set;
        }
        public int AktuellerGang
        {
            get;
            private set;
        }
        public bool IstMotorGestartet
        {
            get;
            private set;
        }

        public Auto(string marke, int ps)
        {
            Marke = marke;
            PS = ps;
            AktuellerGang = 1;
        }
    }
}
