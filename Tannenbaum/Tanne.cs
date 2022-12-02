using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum
{
    public class Tanne
    {

        public string Zeichnung { get; set; }

        public int Stammbreite
        {
            get; set;
        }

        public int Stammhoehe
        {
            get; set;
        }

        public int Kronenhoehe
        {
            get; set;
        }

        public void Zeichne()
        {
            int currentNumber = 0;

            for (int i = 0; i <= Kronenhoehe * 2 - 1; i += 2)
            {
                for (int h = 0; h <= Kronenhoehe - currentNumber; h++)
                {
                    Zeichnung += " ";
                }
                for (int h = 0; h <= i; h++)
                {
                    Zeichnung += "*";
                }
                currentNumber++;
                Zeichnung += Environment.NewLine;
            }

            for (int k = 1; k <= Stammhoehe; k++)
            {
                for (int r = 0; r <= Kronenhoehe- (Stammbreite / 2); r++)
                {
                    Zeichnung += " ";
                }
                for (int b = 1; b <= Stammbreite; b++)
                {
                    Zeichnung += "*";
                }
                Zeichnung += Environment.NewLine;
            }

        }
    }
}
