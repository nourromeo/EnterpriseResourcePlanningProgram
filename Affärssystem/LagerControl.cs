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
    public partial class LagerControl : UserControl
    {
        BindingSource ProductSource;
        public LagerControl(BindingSource productSource)
        {
            InitializeComponent();
            this.ProductSource = productSource;
            ListProductDataGridView.DataSource = ProductSource;
        }

    }
}
