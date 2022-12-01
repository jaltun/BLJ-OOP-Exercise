using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tannenbaum
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void zeichnen_Click(object sender, EventArgs e)
        {
            int stammhöhe, kronenhöhe, stammbreite=0;

            Convert.ToInt32(textstammhöhe.Text=stammhöhe);
            Convert.ToInt32(textkronenhöhe.Text=kronenhöhe);
            Convert.ToInt32(textstammbreite.Text=stammbreite);

            int currentNumber = 0;

            for (int i = 0; i <= kronenhöhe * 2 - 1; i += 2)
            {

                for (int h = 0; h <= kronenhöhe - currentNumber; h++)
                {
                    Console.Write(" ");
                }
                for (int h = 0; h <= i; h++)
                {
                    Console.Write("*");
                }
                currentNumber++;
                Console.Write("\n");
            }

            for (int k = 1; k <= stammhöhe; k++)
            {
                for (int e = 0; e <= kronenhöhe - (stammbreite / 2); e++)
                {
                    Console.Write(" ");
                }
                for (int b = 1; b <= stammbreite; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
