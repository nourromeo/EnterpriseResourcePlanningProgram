
namespace Affärssystem
{
    partial class LagerControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddFromWholesalerButton = new System.Windows.Forms.Button();
            this.RemoveProductButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ListProductsLabel = new System.Windows.Forms.Label();
            this.ListProductDataGridView = new System.Windows.Forms.DataGridView();
            this.ISBNText = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PlatformText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.PlaytimeLabel = new System.Windows.Forms.Label();
            this.PlaytimeText = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.LanguageText = new System.Windows.Forms.TextBox();
            this.AuthorText = new System.Windows.Forms.TextBox();
            this.GenreText = new System.Windows.Forms.TextBox();
            this.FormatText = new System.Windows.Forms.TextBox();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveProductButton = new System.Windows.Forms.Button();
            this.TypeText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddFromWholesalerButton
            // 
            this.AddFromWholesalerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFromWholesalerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFromWholesalerButton.Location = new System.Drawing.Point(990, 440);
            this.AddFromWholesalerButton.Name = "AddFromWholesalerButton";
            this.AddFromWholesalerButton.Size = new System.Drawing.Size(335, 41);
            this.AddFromWholesalerButton.TabIndex = 13;
            this.AddFromWholesalerButton.Text = "Add a Delivery From a Wholesaler";
            this.AddFromWholesalerButton.UseVisualStyleBackColor = true;
            this.AddFromWholesalerButton.Click += new System.EventHandler(this.AddFromWholesalerButton_Click);
            // 
            // RemoveProductButton
            // 
            this.RemoveProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveProductButton.Location = new System.Drawing.Point(814, 440);
            this.RemoveProductButton.Name = "RemoveProductButton";
            this.RemoveProductButton.Size = new System.Drawing.Size(170, 41);
            this.RemoveProductButton.TabIndex = 12;
            this.RemoveProductButton.Text = "Remove Prudoct";
            this.RemoveProductButton.UseVisualStyleBackColor = true;
            this.RemoveProductButton.Click += new System.EventHandler(this.RemoveProductButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.Location = new System.Drawing.Point(1185, 150);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(142, 42);
            this.AddProductButton.TabIndex = 11;
            this.AddProductButton.Text = "Add Prudoct";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ListProductsLabel
            // 
            this.ListProductsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListProductsLabel.AutoSize = true;
            this.ListProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListProductsLabel.Location = new System.Drawing.Point(17, 11);
            this.ListProductsLabel.Name = "ListProductsLabel";
            this.ListProductsLabel.Size = new System.Drawing.Size(193, 29);
            this.ListProductsLabel.TabIndex = 9;
            this.ListProductsLabel.Text = "List of Products";
            // 
            // ListProductDataGridView
            // 
            this.ListProductDataGridView.AllowUserToAddRows = false;
            this.ListProductDataGridView.AllowUserToDeleteRows = false;
            this.ListProductDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListProductDataGridView.Location = new System.Drawing.Point(3, 43);
            this.ListProductDataGridView.MultiSelect = false;
            this.ListProductDataGridView.Name = "ListProductDataGridView";
            this.ListProductDataGridView.ReadOnly = true;
            this.ListProductDataGridView.RowHeadersWidth = 62;
            this.ListProductDataGridView.RowTemplate.Height = 28;
            this.ListProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListProductDataGridView.ShowCellErrors = false;
            this.ListProductDataGridView.ShowCellToolTips = false;
            this.ListProductDataGridView.ShowEditingIcon = false;
            this.ListProductDataGridView.ShowRowErrors = false;
            this.ListProductDataGridView.Size = new System.Drawing.Size(1333, 383);
            this.ListProductDataGridView.TabIndex = 8;
            this.ListProductDataGridView.SelectionChanged += new System.EventHandler(this.ListProductDataGridView_SelectionChanged);
            // 
            // ISBNText
            // 
            this.ISBNText.Location = new System.Drawing.Point(96, 26);
            this.ISBNText.Name = "ISBNText";
            this.ISBNText.Size = new System.Drawing.Size(249, 26);
            this.ISBNText.TabIndex = 1;
            this.ISBNText.TextChanged += new System.EventHandler(this.ISBNText_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PlatformText
            // 
            this.PlatformText.Location = new System.Drawing.Point(882, 166);
            this.PlatformText.Name = "PlatformText";
            this.PlatformText.Size = new System.Drawing.Size(262, 26);
            this.PlatformText.TabIndex = 10;
            this.PlatformText.TextChanged += new System.EventHandler(this.PlatformText_TextChanged);
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(514, 131);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(218, 26);
            this.PriceText.TabIndex = 6;
            this.PriceText.TextChanged += new System.EventHandler(this.PriceText_TextChanged);
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(149, 91);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(249, 26);
            this.NameText.TabIndex = 2;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            this.MainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.TypeText);
            this.MainSplitContainer.Panel1.Controls.Add(this.AddProductButton);
            this.MainSplitContainer.Panel1.Controls.Add(this.PlaytimeLabel);
            this.MainSplitContainer.Panel1.Controls.Add(this.PlaytimeText);
            this.MainSplitContainer.Panel1.Controls.Add(this.PlatformLabel);
            this.MainSplitContainer.Panel1.Controls.Add(this.LanguageText);
            this.MainSplitContainer.Panel1.Controls.Add(this.AuthorText);
            this.MainSplitContainer.Panel1.Controls.Add(this.GenreText);
            this.MainSplitContainer.Panel1.Controls.Add(this.FormatText);
            this.MainSplitContainer.Panel1.Controls.Add(this.LanguageLabel);
            this.MainSplitContainer.Panel1.Controls.Add(this.GenreLabel);
            this.MainSplitContainer.Panel1.Controls.Add(this.FormatLabel);
            this.MainSplitContainer.Panel1.Controls.Add(this.NameLabel);
            this.MainSplitContainer.Panel1.Controls.Add(this.TypeLabel);
            this.MainSplitContainer.Panel1.Controls.Add(this.AuthorLabel);
            this.MainSplitContainer.Panel1.Controls.Add(this.PriceLabel);
            this.MainSplitContainer.Panel1.Controls.Add(this.ISBNLabel);
            this.MainSplitContainer.Panel1.Controls.Add(this.PlatformText);
            this.MainSplitContainer.Panel1.Controls.Add(this.NameText);
            this.MainSplitContainer.Panel1.Controls.Add(this.ISBNText);
            this.MainSplitContainer.Panel1.Controls.Add(this.PriceText);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.CancelButton);
            this.MainSplitContainer.Panel2.Controls.Add(this.SaveProductButton);
            this.MainSplitContainer.Panel2.Controls.Add(this.ListProductsLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.ListProductDataGridView);
            this.MainSplitContainer.Panel2.Controls.Add(this.RemoveProductButton);
            this.MainSplitContainer.Panel2.Controls.Add(this.AddFromWholesalerButton);
            this.MainSplitContainer.Size = new System.Drawing.Size(1339, 731);
            this.MainSplitContainer.SplitterDistance = 237;
            this.MainSplitContainer.TabIndex = 15;
            // 
            // PlaytimeLabel
            // 
            this.PlaytimeLabel.AutoSize = true;
            this.PlaytimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaytimeLabel.Location = new System.Drawing.Point(763, 130);
            this.PlaytimeLabel.Name = "PlaytimeLabel";
            this.PlaytimeLabel.Size = new System.Drawing.Size(113, 29);
            this.PlaytimeLabel.TabIndex = 30;
            this.PlaytimeLabel.Text = "Playtime";
            // 
            // PlaytimeText
            // 
            this.PlaytimeText.Location = new System.Drawing.Point(882, 131);
            this.PlaytimeText.Name = "PlaytimeText";
            this.PlaytimeText.Size = new System.Drawing.Size(262, 26);
            this.PlaytimeText.TabIndex = 9;
            this.PlaytimeText.TextChanged += new System.EventHandler(this.PlaytimeText_TextChanged);
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformLabel.Location = new System.Drawing.Point(762, 164);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(110, 29);
            this.PlatformLabel.TabIndex = 28;
            this.PlatformLabel.Text = "Platform";
            // 
            // LanguageText
            // 
            this.LanguageText.Location = new System.Drawing.Point(149, 166);
            this.LanguageText.Name = "LanguageText";
            this.LanguageText.Size = new System.Drawing.Size(249, 26);
            this.LanguageText.TabIndex = 4;
            this.LanguageText.TextChanged += new System.EventHandler(this.LanguageText_TextChanged);
            // 
            // AuthorText
            // 
            this.AuthorText.Location = new System.Drawing.Point(149, 128);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.Size = new System.Drawing.Size(249, 26);
            this.AuthorText.TabIndex = 3;
            this.AuthorText.TextChanged += new System.EventHandler(this.AuthorText_TextChanged);
            // 
            // GenreText
            // 
            this.GenreText.Location = new System.Drawing.Point(514, 96);
            this.GenreText.Name = "GenreText";
            this.GenreText.Size = new System.Drawing.Size(218, 26);
            this.GenreText.TabIndex = 5;
            this.GenreText.TextChanged += new System.EventHandler(this.GenreText_TextChanged);
            // 
            // FormatText
            // 
            this.FormatText.Location = new System.Drawing.Point(514, 166);
            this.FormatText.Name = "FormatText";
            this.FormatText.Size = new System.Drawing.Size(218, 26);
            this.FormatText.TabIndex = 7;
            this.FormatText.TextChanged += new System.EventHandler(this.FormatText_TextChanged);
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageLabel.Location = new System.Drawing.Point(15, 161);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(128, 29);
            this.LanguageLabel.TabIndex = 22;
            this.LanguageLabel.Text = "Language";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.Location = new System.Drawing.Point(410, 91);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(85, 29);
            this.GenreLabel.TabIndex = 21;
            this.GenreLabel.Text = "Genre";
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormatLabel.Location = new System.Drawing.Point(413, 162);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(95, 29);
            this.FormatLabel.TabIndex = 20;
            this.FormatLabel.Text = "Format";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(17, 87);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(82, 29);
            this.NameLabel.TabIndex = 19;
            this.NameLabel.Text = "Name";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(762, 96);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(72, 29);
            this.TypeLabel.TabIndex = 18;
            this.TypeLabel.Text = "Type";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.Location = new System.Drawing.Point(17, 125);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(88, 29);
            this.AuthorLabel.TabIndex = 17;
            this.AuthorLabel.Text = "Author";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(413, 127);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(74, 29);
            this.PriceLabel.TabIndex = 16;
            this.PriceLabel.Text = "Price";
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNLabel.Location = new System.Drawing.Point(17, 22);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(73, 29);
            this.ISBNLabel.TabIndex = 15;
            this.ISBNLabel.Text = "ISBN";
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.Enabled = false;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(16, 440);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(89, 41);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveProductButton
            // 
            this.SaveProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveProductButton.Enabled = false;
            this.SaveProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveProductButton.Location = new System.Drawing.Point(111, 440);
            this.SaveProductButton.Name = "SaveProductButton";
            this.SaveProductButton.Size = new System.Drawing.Size(89, 41);
            this.SaveProductButton.TabIndex = 15;
            this.SaveProductButton.Text = "Save";
            this.SaveProductButton.UseVisualStyleBackColor = true;
            this.SaveProductButton.Click += new System.EventHandler(this.SaveProductButton_Click);
            // 
            // TypeText
            // 
            this.TypeText.Location = new System.Drawing.Point(882, 95);
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(262, 26);
            this.TypeText.TabIndex = 8;
            this.TypeText.TextChanged += new System.EventHandler(this.TypeText_TextChanged);
            // 
            // LagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainSplitContainer);
            this.Name = "LagerControl";
            this.Size = new System.Drawing.Size(1339, 731);
            ((System.ComponentModel.ISupportInitialize)(this.ListProductDataGridView)).EndInit();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel1.PerformLayout();
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddFromWholesalerButton;
        private System.Windows.Forms.Button RemoveProductButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label ListProductsLabel;
        private System.Windows.Forms.DataGridView ListProductDataGridView;
        private System.Windows.Forms.TextBox ISBNText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox PlatformText;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label FormatLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.TextBox AuthorText;
        private System.Windows.Forms.TextBox GenreText;
        private System.Windows.Forms.TextBox FormatText;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.TextBox LanguageText;
        private System.Windows.Forms.Label PlaytimeLabel;
        private System.Windows.Forms.TextBox PlaytimeText;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Button SaveProductButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox TypeText;
    }
}
