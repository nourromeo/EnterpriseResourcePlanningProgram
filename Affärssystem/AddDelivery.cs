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
    public partial class AddDelivery : Form
    {
        internal Product Delivery { get; private set; }

        public AddDelivery()
        {
            InitializeComponent();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            Delivery = new Product();
            Delivery.Antal = AntalDeliveryText.Text;


            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
