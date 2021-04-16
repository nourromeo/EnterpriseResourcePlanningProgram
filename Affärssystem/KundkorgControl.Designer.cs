
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KundkorgControl));
            this.CartList = new System.Windows.Forms.ListBox();
            this.CartDataGridView = new System.Windows.Forms.DataGridView();
            this.CompleteBuyButton = new System.Windows.Forms.Button();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.RemoveFromCartButton = new System.Windows.Forms.Button();
            this.MainSliptter = new System.Windows.Forms.SplitContainer();
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
            this.CartList.FormattingEnabled = true;
            this.CartList.ItemHeight = 20;
            this.CartList.Location = new System.Drawing.Point(8, 3);
            this.CartList.Name = "CartList";
            this.CartList.Size = new System.Drawing.Size(338, 644);
            this.CartList.TabIndex = 0;
            // 
            // CartDataGridView
            // 
            this.CartDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartDataGridView.Location = new System.Drawing.Point(3, 3);
            this.CartDataGridView.Name = "CartDataGridView";
            this.CartDataGridView.RowHeadersWidth = 62;
            this.CartDataGridView.RowTemplate.Height = 28;
            this.CartDataGridView.Size = new System.Drawing.Size(848, 633);
            this.CartDataGridView.TabIndex = 1;
            // 
            // CompleteBuyButton
            // 
            this.CompleteBuyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteBuyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteBuyButton.Location = new System.Drawing.Point(147, 660);
            this.CompleteBuyButton.Name = "CompleteBuyButton";
            this.CompleteBuyButton.Size = new System.Drawing.Size(187, 39);
            this.CompleteBuyButton.TabIndex = 2;
            this.CompleteBuyButton.Text = "Complete and Buy";
            this.CompleteBuyButton.UseVisualStyleBackColor = true;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCartButton.Image = ((System.Drawing.Image)(resources.GetObject("AddToCartButton.Image")));
            this.AddToCartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddToCartButton.ImageKey = "(none)";
            this.AddToCartButton.Location = new System.Drawing.Point(648, 660);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(190, 39);
            this.AddToCartButton.TabIndex = 3;
            this.AddToCartButton.Text = "Add to Cart";
            this.AddToCartButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddToCartButton.UseVisualStyleBackColor = true;
            // 
            // RemoveFromCartButton
            // 
            this.RemoveFromCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveFromCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveFromCartButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveFromCartButton.Image")));
            this.RemoveFromCartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveFromCartButton.ImageKey = "(none)";
            this.RemoveFromCartButton.Location = new System.Drawing.Point(17, 660);
            this.RemoveFromCartButton.Name = "RemoveFromCartButton";
            this.RemoveFromCartButton.Size = new System.Drawing.Size(190, 39);
            this.RemoveFromCartButton.TabIndex = 4;
            this.RemoveFromCartButton.Text = "Remove from Cart";
            this.RemoveFromCartButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveFromCartButton.UseVisualStyleBackColor = true;
            // 
            // MainSliptter
            // 
            this.MainSliptter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSliptter.Location = new System.Drawing.Point(0, 0);
            this.MainSliptter.Name = "MainSliptter";
            // 
            // MainSliptter.Panel1
            // 
            this.MainSliptter.Panel1.Controls.Add(this.CartDataGridView);
            this.MainSliptter.Panel1.Controls.Add(this.RemoveFromCartButton);
            this.MainSliptter.Panel1.Controls.Add(this.AddToCartButton);
            // 
            // MainSliptter.Panel2
            // 
            this.MainSliptter.Panel2.Controls.Add(this.CartList);
            this.MainSliptter.Panel2.Controls.Add(this.CompleteBuyButton);
            this.MainSliptter.Size = new System.Drawing.Size(1207, 708);
            this.MainSliptter.SplitterDistance = 854;
            this.MainSliptter.TabIndex = 5;
            // 
            // KundkorgControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainSliptter);
            this.Name = "KundkorgControl";
            this.Size = new System.Drawing.Size(1207, 708);
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).EndInit();
            this.MainSliptter.Panel1.ResumeLayout(false);
            this.MainSliptter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSliptter)).EndInit();
            this.MainSliptter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CartList;
        private System.Windows.Forms.DataGridView CartDataGridView;
        private System.Windows.Forms.Button CompleteBuyButton;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Button RemoveFromCartButton;
        private System.Windows.Forms.SplitContainer MainSliptter;
    }
}
