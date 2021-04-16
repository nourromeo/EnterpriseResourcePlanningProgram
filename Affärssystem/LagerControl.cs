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
        Product SelectedItem;

        public Product Delivery { get; private set; }

        public LagerControl(BindingSource productSource)
        {
            InitializeComponent();
            this.ProductSource = productSource;
            ListProductDataGridView.DataSource = ProductSource;
        }

        private void ListProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ListProductDataGridView.SelectedRows.Count < 1)
            {
                SetTextEnbled(false);
                ISBNText.Enabled = true;

                return;
            }
            var product = (Product)ListProductDataGridView.SelectedRows[0].DataBoundItem;
            ISBNText.Text = product.ISBN;
            NameText.Text = product.Name;
            PriceText.Text = product.Price;
            TypeText.Text = product.Type;
            AuthorText.Text = product.Author;
            GenreText.Text = product.Genre;
            FormatText.Text = product.Format;
            LanguageText.Text = product.Language;
            PlatformText.Text = product.PLatform;
            PlaytimeText.Text = product.Playtime;
            SelectedItem = product;
            Delivery = product;

            SaveProductButton.Enabled = false;
            CancelButton.Enabled = false;
            // AddProductButton.Enabled = false;

            SetTextEnbled(true);
        }

        private void SetTextEnbled(bool state)
        {
            ISBNText.Enabled = state;
            NameText.Enabled = state;
            PriceText.Enabled = state;
            TypeText.Enabled = state;
            AuthorText.Enabled = state;
            GenreText.Enabled = state;
            FormatText.Enabled = state;
            LanguageText.Enabled = state;
            PlatformText.Enabled = state;
            PlaytimeText.Enabled = state;
        }

        private void ISBNText_TextChanged(object sender, EventArgs e)
        {
            SaveProductButton.Enabled = true;
            CancelButton.Enabled = true;
            AddProductButton.Enabled = true;

            SetTextEnbled(true);

        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            SaveProductButton.Enabled = true;
            CancelButton.Enabled = true;
            AddProductButton.Enabled = true;
        }

        private void PriceText_TextChanged(object sender, EventArgs e)
        {
            SaveProductButton.Enabled = true;
            CancelButton.Enabled = true;
            AddProductButton.Enabled = true;
        }

        private void TypeText_TextChanged(object sender, EventArgs e)
        {
            SaveProductButton.Enabled = true;
            CancelButton.Enabled = true;
            AddProductButton.Enabled = true;
        }

        private void AuthorText_TextChanged(object sender, EventArgs e)
        {
            SaveProductButton.Enabled = true;
            CancelButton.Enabled = true;
            AddProductButton.Enabled = true;
        }

        private void GenreText_TextChanged(object sender, EventArgs e)
        {
            SaveProductButton.Enabled = true;
            CancelButton.Enabled = true;
            AddProductButton.Enabled = true;
        }

        private void FormatText_TextChanged(object sender, EventArgs e)
        {
            SaveProductButton.Enabled = true;
            CancelButton.Enabled = true;
            AddProductButton.Enabled = true;
        }

        private void LanguageText_TextChanged(object sender, EventArgs e)
        {
            SaveProductButton.Enabled = true;
            CancelButton.Enabled = true;
            AddProductButton.Enabled = true;
        }

        private void PlatformText_TextChanged(object sender, EventArgs e)
        {
            SaveProductButton.Enabled = true;
            CancelButton.Enabled = true;
            AddProductButton.Enabled = true;
        }

        private void PlaytimeText_TextChanged(object sender, EventArgs e)
        {
            SaveProductButton.Enabled = true;
            CancelButton.Enabled = true;
            AddProductButton.Enabled = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ListProductDataGridView_SelectionChanged(sender, null);
        }

        private void SaveProductButton_Click(object sender, EventArgs e)
        {
            SelectedItem.ISBN = ISBNText.Text;
            SelectedItem.Name = NameText.Text;
            SelectedItem.Author = AuthorText.Text;
            SelectedItem.Price = PriceText.Text;
            SelectedItem.Type = TypeText.Text;
            SelectedItem.Genre = GenreText.Text;
            SelectedItem.Format = FormatText.Text;
            SelectedItem.Language = LanguageText.Text;
            SelectedItem.PLatform = PlatformText.Text;
            SelectedItem.Playtime = PlaytimeText.Text;

            ProductSource.ResetCurrentItem();
            ListProductDataGridView_SelectionChanged(sender, null);
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            if (ListProductDataGridView.SelectedRows.Count < 1)
                return;
            var product = (Product)ListProductDataGridView.SelectedRows[0].DataBoundItem;
            ProductSource.Remove(product);

            ISBNText.Text = NameText.Text = AuthorText.Text 
                = PriceText.Text = TypeText.Text = GenreText.Text 
                = FormatText.Text = LanguageText.Text = PlatformText.Text 
                = PlaytimeText.Text = string.Empty;

            SaveProductButton.Enabled = false;
            CancelButton.Enabled = false;
            ListProductDataGridView_SelectionChanged(sender, null);
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            var product = new Product();

            product.ISBN = ISBNText.Text;
            product.Name = NameText.Text;
            product.Price = PriceText.Text;
            product.Type = TypeText.Text;
            product.Author = AuthorText.Text;
            product.Genre = GenreText.Text;
            product.Format = FormatText.Text;
            product.Language = LanguageText.Text;
            product.PLatform = PlatformText.Text;
            product.Playtime = PlaytimeText.Text;

            ProductSource.Add(product);
        }

        private void AddFromWholesalerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
