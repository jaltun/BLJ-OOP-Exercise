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
   
        public partial class CartForm : Form
        {
            List<OrderItem> items;

            public CartForm(List<OrderItem> orderedItems)
            {
                InitializeComponent();

                this.items = orderedItems;
            }

            private void CartForm_Load(object sender, EventArgs e)
            {
                foreach (OrderItem item in items)
                {
                listBoxitems.Items.Add(item.Amount + " Ex." + "\t" + item.ProductName);
                }
            }

            private void buttonExit_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    
}
