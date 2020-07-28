namespace APRIORI_CK
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MENUIMPORT = new System.Windows.Forms.ToolStripMenuItem();
            this.MENUAPRIORI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENUIMPORT,
            this.MENUAPRIORI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1259, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MENUIMPORT
            // 
            this.MENUIMPORT.Name = "MENUIMPORT";
            this.MENUIMPORT.Size = new System.Drawing.Size(107, 20);
            this.MENUIMPORT.Text = "IMPORT DỮ LIỆU";
            this.MENUIMPORT.Click += new System.EventHandler(this.MENUIMPORT_Click);
            // 
            // MENUAPRIORI
            // 
            this.MENUAPRIORI.Name = "MENUAPRIORI";
            this.MENUAPRIORI.Size = new System.Drawing.Size(140, 20);
            this.MENUAPRIORI.Text = "THUẬT TOÁN APRIORI";
            this.MENUAPRIORI.Click += new System.EventHandler(this.MENUAPRIORI_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 629);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "DEMO APRIORI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MENUIMPORT;
        private System.Windows.Forms.ToolStripMenuItem MENUAPRIORI;
    }
}

