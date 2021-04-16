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
        BindingList<Product> ProductList;
        BindingSource ProductSource;
        int antal = 1;
        public MainForm()
        {
            InitializeComponent();
            ProductList = new BindingList<Product>() 
            {
                new Product() {Antal = "1", ISBN = "123", Name = "Commentarii de Bello Gallico et Civili", Price = "449", Type = "Bok", Author  = "Gaius Julius Caesar", Genre = "Historia", Format = "Inbunden", Language = "Latin"},
                new Product() {Antal = "1", ISBN = "456", Name = "Schindlers list", Price = "149", Type = "DVD", Playtime = "195"},
                new Product() {Antal = "1", ISBN = "789", Name = "Microsoft Flight Simulator", Price = "449", Type = "Spel", PLatform = "PC"}
            };
            ProductSource = new BindingSource();
            ProductSource.DataSource = ProductList;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LagerControl Lager = new LagerControl(ProductSource);
            Lager.Dock = DockStyle.Fill;
            LagerTab.Controls.Add(Lager);

            KundkorgControl Kundkorg = new KundkorgControl();
            Kundkorg.Dock = DockStyle.Fill;
            KundkorgTab.Controls.Add(Kundkorg);
        }
    }
}
