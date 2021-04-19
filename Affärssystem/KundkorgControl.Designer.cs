
namespace Affärssystem
{
    partial class KundkorgControl
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
            this.CartList = new System.Windows.Forms.ListBox();
            this.CartDataGridView = new System.Windows.Forms.DataGridView();
            this.CompleteBuyButton = new System.Windows.Forms.Button();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.MainSliptter = new System.Windows.Forms.SplitContainer();
            this.ListProductsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSliptter)).BeginInit();
            this.MainSliptter.Panel1.SuspendLayout();
            this.MainSliptter.Panel2.SuspendLayout();
            this.MainSliptter.SuspendLayout();
            this.SuspendLayout();
            // 
            // CartList
            // 
            this.CartList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartList.BackColor = System.Drawing.Color.SkyBlue;
            this.CartList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartList.FormattingEnabled = true;
            this.CartList.ItemHeight = 20;
            this.CartList.Location = new System.Drawing.Point(3, 63);
            this.CartList.Name = "CartList";
            this.CartList.Size = new System.Drawing.Size(395, 604);
            this.CartList.TabIndex = 0;
            // 
            // CartDataGridView
            // 
            this.CartDataGridView.AllowUserToAddRows = false;
            this.CartDataGridView.AllowUserToDeleteRows = false;
            this.CartDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.CartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartDataGridView.Location = new System.Drawing.Point(3, 63);
            this.CartDataGridView.MultiSelect = false;
            this.CartDataGridView.Name = "CartDataGridView";
            this.CartDataGridView.ReadOnly = true;
            this.CartDataGridView.RowHeadersWidth = 62;
            this.CartDataGridView.RowTemplate.Height = 28;
            this.CartDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartDataGridView.ShowCellErrors = false;
            this.CartDataGridView.ShowCellToolTips = false;
            this.CartDataGridView.ShowEditingIcon = false;
            this.CartDataGridView.ShowRowErrors = false;
            this.CartDataGridView.Size = new System.Drawing.Size(972, 589);
            this.CartDataGridView.TabIndex = 1;
            // 
            // CompleteBuyButton
            // 
            this.CompleteBuyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteBuyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteBuyButton.Location = new System.Drawing.Point(191, 676);
            this.CompleteBuyButton.Name = "CompleteBuyButton";
            this.CompleteBuyButton.Size = new System.Drawing.Size(195, 39);
            this.CompleteBuyButton.TabIndex = 2;
            this.CompleteBuyButton.Text = "Complete and Buy";
            this.CompleteBuyButton.UseVisualStyleBackColor = true;
            this.CompleteBuyButton.Click += new System.EventHandler(this.CompleteBuyButton_Click);
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCartButton.ImageKey = "(none)";
            this.AddToCartButton.Location = new System.Drawing.Point(833, 676);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(129, 39);
            this.AddToCartButton.TabIndex = 3;
            this.AddToCartButton.Text = "Add to Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // MainSliptter
            // 
            this.MainSliptter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSliptter.IsSplitterFixed = true;
            this.MainSliptter.Location = new System.Drawing.Point(0, 0);
            this.MainSliptter.Name = "MainSliptter";
            // 
            // MainSliptter.Panel1
            // 
            this.MainSliptter.Panel1.Controls.Add(this.ListProductsLabel);
            this.MainSliptter.Panel1.Controls.Add(this.CartDataGridView);
            this.MainSliptter.Panel1.Controls.Add(this.AddToCartButton);
            // 
            // MainSliptter.Panel2
            // 
            this.MainSliptter.Panel2.Controls.Add(this.label1);
            this.MainSliptter.Panel2.Controls.Add(this.CartList);
            this.MainSliptter.Panel2.Controls.Add(this.CompleteBuyButton);
            this.MainSliptter.Size = new System.Drawing.Size(1383, 724);
            this.MainSliptter.SplitterDistance = 978;
            this.MainSliptter.TabIndex = 5;
            // 
            // ListProductsLabel
            // 
            this.ListProductsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListProductsLabel.AutoSize = true;
            this.ListProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListProductsLabel.Location = new System.Drawing.Point(20, 12);
            this.ListProductsLabel.Name = "ListProductsLabel";
            this.ListProductsLabel.Size = new System.Drawing.Size(193, 29);
            this.ListProductsLabel.TabIndex = 10;
            this.ListProductsLabel.Text = "List of Products";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cart Shopping";
            // 
            // KundkorgControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.MainSliptter);
            this.Name = "KundkorgControl";
            this.Size = new System.Drawing.Size(1383, 724);
            this.Load += new System.EventHandler(this.KundkorgControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).EndInit();
            this.MainSliptter.Panel1.ResumeLayout(false);
            this.MainSliptter.Panel1.PerformLayout();
            this.MainSliptter.Panel2.ResumeLayout(false);
            this.MainSliptter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSliptter)).EndInit();
            this.MainSliptter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CartList;
        private System.Windows.Forms.DataGridView CartDataGridView;
        private System.Windows.Forms.Button CompleteBuyButton;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.SplitContainer MainSliptter;
        private System.Windows.Forms.Label ListProductsLabel;
        private System.Windows.Forms.Label label1;
    }
}
