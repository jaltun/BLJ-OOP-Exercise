using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reisedauer_Mond
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Reisedauer_Click(object sender, EventArgs e)
        {
            int kmH = 0;
            
            Mondreise mondreise= new Mondreise(kmH);

            if (Tage.Checked)
                textBoxausgabe.Text=mondreise.GetTravelDurationDays().ToString();
            else
                textBoxausgabe.Text=mondreise.GetTravelDurationHours().ToString();
        }
    }
}
