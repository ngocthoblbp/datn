namespace APRIORI_CK
{
    partial class frmImport
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
            this.BTXOA = new System.Windows.Forms.Button();
            this.BTImportData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTChonFile = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTXOA
            // 
            this.BTXOA.Location = new System.Drawing.Point(791, 84);
            this.BTXOA.Name = "BTXOA";
            this.BTXOA.Size = new System.Drawing.Size(112, 27);
            this.BTXOA.TabIndex = 19;
            this.BTXOA.Text = "Xóa Dữ Liệu";
            this.BTXOA.UseVisualStyleBackColor = true;
            this.BTXOA.Click += new System.EventHandler(this.BTXOA_Click);
            // 
            // BTImportData
            // 
            this.BTImportData.Location = new System.Drawing.Point(928, 84);
            this.BTImportData.Name = "BTImportData";
            this.BTImportData.Size = new System.Drawing.Size(112, 27);
            this.BTImportData.TabIndex = 18;
            this.BTImportData.Text = "Import Dữ Liệu";
            this.BTImportData.UseVisualStyleBackColor = true;
            this.BTImportData.Click += new System.EventHandler(this.BTImportData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(104, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1065, 602);
            this.dataGridView1.TabIndex = 17;
            // 
            // BTChonFile
            // 
            this.BTChonFile.Location = new System.Drawing.Point(691, 83);
            this.BTChonFile.Name = "BTChonFile";
            this.BTChonFile.Size = new System.Drawing.Size(75, 27);
            this.BTChonFile.TabIndex = 16;
            this.BTChonFile.Text = "Chọn File";
            this.BTChonFile.UseVisualStyleBackColor = true;
            this.BTChonFile.Click += new System.EventHandler(this.BTChonFile_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(187, 86);
            this.txtpath.Name = "txtpath";
            this.txtpath.ReadOnly = true;
            this.txtpath.Size = new System.Drawing.Size(498, 23);
            this.txtpath.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Đường dẫn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(410, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "ĐỌC DỮ LIỆU TỪ FILE EXCEL";
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 750);
            this.Controls.Add(this.BTXOA);
            this.Controls.Add(this.BTImportData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTChonFile);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmImport";
            this.Text = "frmImport";
            this.Load += new System.EventHandler(this.frmImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTXOA;
        private System.Windows.Forms.Button BTImportData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTChonFile;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}