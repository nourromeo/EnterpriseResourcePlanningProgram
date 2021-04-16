
namespace Affärssystem
{
    partial class AddDelivery
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.AntalDeliveryText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNLabel.Location = new System.Drawing.Point(12, 25);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(73, 29);
            this.ISBNLabel.TabIndex = 17;
            this.ISBNLabel.Text = "ISBN";
            // 
            // AntalDeliveryText
            // 
            this.AntalDeliveryText.Location = new System.Drawing.Point(91, 29);
            this.AntalDeliveryText.Name = "AntalDeliveryText";
            this.AntalDeliveryText.Size = new System.Drawing.Size(249, 26);
            this.AntalDeliveryText.TabIndex = 16;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(198, 72);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(142, 42);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add Prudoct";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 127);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.AntalDeliveryText);
            this.Name = "AddDelivery";
            this.Text = "AddDelivery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.TextBox AntalDeliveryText;
        private System.Windows.Forms.Button addButton;
    }
}