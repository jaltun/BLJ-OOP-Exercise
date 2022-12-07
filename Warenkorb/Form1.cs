using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warenkorb
{
    public partial class OrderForm: Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
   
        List<OrderItem> orderedItems = new List<OrderItem>();

   

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(produkt.Text.Trim()))
                return;

            OrderItem item = new OrderItem();
            item.ProductName = produkt.Text;
            item.Amount = Convert.ToInt32(numericUpDown1.Value);
            orderedItems.Add(item);

            labelAmount.Text = "(" + orderedItems.Count.ToString() + ")";

            produkt.Text = "";
            produkt.Focus();
            numericUpDown1.Value = 1;
        }

        private void textBoxProduct_TextChanged(object sender, EventArgs e)
        {
            hinzufuegen.Enabled = produkt.Text.Length > 0;
        }

        private void linkLabelViewCart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CartForm cart = new CartForm(this.orderedItems);
            cart.ShowDialog();
        }
    }
}
