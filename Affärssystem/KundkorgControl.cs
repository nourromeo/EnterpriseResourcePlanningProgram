using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Affärssystem
{
    public partial class KundkorgControl : UserControl
    {
        public Button AcceptButton { get { return AddToCartButton; } }
        private BindingSource ProductSource;
        ShoppingCart ListShopping;


        public KundkorgControl(ShoppingCart listShopping, BindingSource productSource)
        {
            InitializeComponent();
            ProductSource = productSource;
            ListShopping = listShopping;
            CartDataGridView.DataSource = productSource;
        }

        private void KundkorgControl_Load(object sender, EventArgs e)
        {
            CartDataGridView.ClearSelection();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            var product = (Product)CartDataGridView.SelectedRows[0].DataBoundItem;

            int q;
            q = int.Parse(product.Quantity);

            if (q == 0)
            {
                MessageBox.Show("The product is Empty, ask from the wholesaler to deliver more! ");
                return;
            }
            else
            {
                CartList.Items.Add(product);

                product.Quantity = Convert.ToString(q - 1);
                ProductSource.ResetCurrentItem();
                ListShopping.SaveFile();                    
            }

        }

        private void RemoveFromCartButton_Click(object sender, EventArgs e)
        {
            /*
            if (CartDataGridView.SelectedRows.Count < 1)
            {
                return;
            }
            else
            {
                if (CartList.Items.Count == 0)
                {
                    MessageBox.Show("The Cart is already empty!");
                    return;

                }
                else
                {
                    var product = (Product)CartDataGridView.SelectedRows[0].DataBoundItem;

                    int q;
                    q = int.Parse(product.Quantity);
                    CartList.Items.Remove(CartList.SelectedItem);
                    product.Quantity = Convert.ToString(q + 1);
                    ProductSource.ResetCurrentItem();
                    ListShopping.SaveFile();
                }
            }
            */

        }

        private void CompleteBuyButton_Click(object sender, EventArgs e)
        {                
            if (CartList.Items.Count < 1)
                return;

            DialogResult completeAndBuy;
            completeAndBuy = MessageBox.Show("The order has been Completed Successfully", "Order Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CartList.Items.Clear();

        }

    }
}
