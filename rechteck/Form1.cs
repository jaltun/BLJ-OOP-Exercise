using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rechteck
{
    public partial class Form1 : Form
    {

        class Rechteck
        {
            public double Höhe { get; set; }
            public double Breite { get; set; }

            public double GetArea()
            {
                return Höhe * Breite;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void beenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void berechnen_Click(object sender, EventArgs e)
        {
            double width = 0;
            double height = 0;

            if (double.TryParse(texthöhe.Text, out width) == false)
            {
                MessageBox.Show("Ungültige Eingabe. Die Breite des Rechtecks muss eine Zahl sein.");
                texthöhe.Focus();
                texthöhe.SelectAll();
            }
            else if (double.TryParse(texthöhe.Text, out height) == false)
            {
                MessageBox.Show("Ungültige Eingabe. Die Höhe des Rechtecks muss eine Zahl sein.");
                texthöhe.Focus();
                texthöhe.SelectAll();
            }
            else
            {
                Rechteck rechteck = new Rechteck();
                rechteck.Breite = width;
                rechteck.Höhe = height;

                texthöhe.Text = rechteck.GetArea().ToString();
            }
        }

        private void textbreite_TextChanged(object sender, EventArgs e)
        {
            berechnen.Enabled = texthöhe.Text.Length > 0 && texthöhe.Text.Length > 0;
        }

        private void texthöhe_TextChanged(object sender, EventArgs e)
        {
            berechnen.Enabled = texthöhe.Text.Length > 0 && texthöhe.Text.Length > 0;
        }
    }
}

