
namespace Affärssystem
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.KundkorgTab = new System.Windows.Forms.TabPage();
            this.LagerTab = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.LagerTab);
            this.tabControl.Controls.Add(this.KundkorgTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1478, 815);
            this.tabControl.TabIndex = 0;
            // 
            // KundkorgTab
            // 
            this.KundkorgTab.Location = new System.Drawing.Point(4, 29);
            this.KundkorgTab.Name = "KundkorgTab";
            this.KundkorgTab.Padding = new System.Windows.Forms.Padding(3);
            this.KundkorgTab.Size = new System.Drawing.Size(2209, 1190);
            this.KundkorgTab.TabIndex = 1;
            this.KundkorgTab.Text = "Kundkorg";
            this.KundkorgTab.UseVisualStyleBackColor = true;
            // 
            // LagerTab
            // 
            this.LagerTab.Location = new System.Drawing.Point(4, 29);
            this.LagerTab.Name = "LagerTab";
            this.LagerTab.Padding = new System.Windows.Forms.Padding(3);
            this.LagerTab.Size = new System.Drawing.Size(1470, 782);
            this.LagerTab.TabIndex = 0;
            this.LagerTab.Text = "Lager";
            this.LagerTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 815);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(1500, 859);
            this.Name = "MainForm";
            this.Text = "Affärssystem - Bokförsäljning";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage KundkorgTab;
        private System.Windows.Forms.TabPage LagerTab;
    }
}

