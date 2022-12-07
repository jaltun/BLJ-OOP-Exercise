using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            domainUpDown1.Items.Add(new Auto("Porsche", 250));
            domainUpDown1.Items.Add(new Auto("Oper", 90));
            domainUpDown1.Items.Add(new Auto("Ferrari", 370));
        }
    }
}
