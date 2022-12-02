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
            string zeichnung;

            stammhöhe = Convert.ToInt32(textstammhöhe.Text);
            kronenhöhe = Convert.ToInt32(textkronenhöhe.Text);
            stammbreite = Convert.ToInt32(textstammbreite.Text);

            Tanne t = new Tanne();
            t.Stammbreite = stammbreite;
            t.Stammhoehe = stammhöhe;
            t.Kronenhoehe = kronenhöhe;
            t.Zeichne(); 
            textBoxZeichnung.Text = t.Zeichnung;


            /*
            int currentNumber = 0;

            for (int i = 0; i <= kronenhöhe * 2 - 1; i += 2)
            {
                for (int h = 0; h <= kronenhöhe - currentNumber; h++)
                {
                    textBoxZeichnung.Text += " ";
                }
                for (int h = 0; h <= i; h++)
                {
                    textBoxZeichnung.Text += "*";
                }
                currentNumber++;
                textBoxZeichnung.Text += Environment.NewLine;
            }

            for (int k = 1; k <= stammhöhe; k++)
            {
                for (int r = 0; r <= kronenhöhe - (stammbreite / 2); r++)
                {
                    textBoxZeichnung.Text += " ";
                }
                for (int b = 1; b <= stammbreite; b++)
                {
                    textBoxZeichnung.Text += "*";
                }
                textBoxZeichnung.Text += Environment.NewLine;
            }

            */
        }
    }
}
