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
    public partial class MainForm : Form
    {
        BindingSource ProductSource;
        ShoppingCart ListShopping;

        public MainForm()
        {
            InitializeComponent();
            ProductSource = new BindingSource();
            ListShopping = new ShoppingCart();
            ListShopping.LoadFile();
            ProductSource.DataSource = ListShopping.ProductList;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LagerControl Lager = new LagerControl(ListShopping, ProductSource);
            Lager.Dock = DockStyle.Fill;
            LagerTab.Controls.Add(Lager);

            KundkorgControl Kundkorg = new KundkorgControl(ListShopping, ProductSource);
            Kundkorg.Dock = DockStyle.Fill;
            KundkorgTab.Controls.Add(Kundkorg);

            AcceptButton = Kundkorg.AcceptButton;

        }
    }
}
