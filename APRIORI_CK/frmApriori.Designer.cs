namespace APRIORI_CK
{
    partial class frmApriori
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTLoad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTAPRIORI = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lbItem = new System.Windows.Forms.Label();
            this.lbluat = new System.Windows.Forms.Label();
            this.lbsoluong = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtngay = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BTLuu = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtminsupp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtminconf = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbtongsocot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(679, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SINH LUẬT KẾT HỢP VỚI THUẬT TOÁN APRIORI";
            // 
            // BTLoad
            // 
            this.BTLoad.Location = new System.Drawing.Point(71, 29);
            this.BTLoad.Name = "BTLoad";
            this.BTLoad.Size = new System.Drawing.Size(110, 31);
            this.BTLoad.TabIndex = 1;
            this.BTLoad.Text = "Load dữ liệu";
            this.BTLoad.UseVisualStyleBackColor = true;
            this.BTLoad.Click += new System.EventHandler(this.BTLoad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(979, 258);
            this.dataGridView1.TabIndex = 2;
            // 
            // BTAPRIORI
            // 
            this.BTAPRIORI.Location = new System.Drawing.Point(853, 76);
            this.BTAPRIORI.Name = "BTAPRIORI";
            this.BTAPRIORI.Size = new System.Drawing.Size(183, 31);
            this.BTAPRIORI.TabIndex = 1;
            this.BTAPRIORI.Text = "Luật kết hợp với Apriori";
            this.BTAPRIORI.UseVisualStyleBackColor = true;
            this.BTAPRIORI.Click += new System.EventHandler(this.BTAPRIORI_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(185, 292);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(197, 44);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(209, 292);
            this.listBox2.TabIndex = 3;
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Location = new System.Drawing.Point(6, 24);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(92, 17);
            this.lbItem.TabIndex = 4;
            this.lbItem.Text = "Tập phổ biến";
            // 
            // lbluat
            // 
            this.lbluat.AutoSize = true;
            this.lbluat.Location = new System.Drawing.Point(685, 382);
            this.lbluat.Name = "lbluat";
            this.lbluat.Size = new System.Drawing.Size(0, 17);
            this.lbluat.TabIndex = 5;
            // 
            // lbsoluong
            // 
            this.lbsoluong.AutoSize = true;
            this.lbsoluong.Location = new System.Drawing.Point(251, 58);
            this.lbsoluong.Name = "lbsoluong";
            this.lbsoluong.Size = new System.Drawing.Size(0, 17);
            this.lbsoluong.TabIndex = 6;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(71, 113);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(150, 256);
            this.checkedListBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chọn mã chứng khoán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(235, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số ngày";
            // 
            // txtngay
            // 
            this.txtngay.Location = new System.Drawing.Point(301, 87);
            this.txtngay.Name = "txtngay";
            this.txtngay.Size = new System.Drawing.Size(100, 23);
            this.txtngay.TabIndex = 11;
            this.txtngay.Text = "4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.lbItem);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(8, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 349);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LUẬT KẾT HỢP MÃ CHỨNG KHOÁN TĂNG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Luật kết hợp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.listBox3);
            this.groupBox2.Controls.Add(this.listBox4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(426, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 349);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LUẬT KẾT HỢP MÃ CHỨNG KHOÁN ĐI NGANG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Luật kết hợp";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.HorizontalScrollbar = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(6, 44);
            this.listBox3.Name = "listBox3";
            this.listBox3.ScrollAlwaysVisible = true;
            this.listBox3.Size = new System.Drawing.Size(185, 292);
            this.listBox3.TabIndex = 3;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.HorizontalScrollbar = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(197, 44);
            this.listBox4.Name = "listBox4";
            this.listBox4.ScrollAlwaysVisible = true;
            this.listBox4.Size = new System.Drawing.Size(209, 292);
            this.listBox4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tập phổ biến";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.listBox5);
            this.groupBox3.Controls.Add(this.listBox6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(845, 382);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 349);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LUẬT KẾT HỢP MÃ CHỨNG KHOÁ GIẢM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Luật kết hợp";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.HorizontalScrollbar = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Location = new System.Drawing.Point(6, 44);
            this.listBox5.Name = "listBox5";
            this.listBox5.ScrollAlwaysVisible = true;
            this.listBox5.Size = new System.Drawing.Size(185, 292);
            this.listBox5.TabIndex = 3;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.HorizontalScrollbar = true;
            this.listBox6.ItemHeight = 16;
            this.listBox6.Location = new System.Drawing.Point(197, 44);
            this.listBox6.Name = "listBox6";
            this.listBox6.ScrollAlwaysVisible = true;
            this.listBox6.Size = new System.Drawing.Size(209, 292);
            this.listBox6.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tập phổ biết";
            // 
            // BTLuu
            // 
            this.BTLuu.Location = new System.Drawing.Point(1042, 76);
            this.BTLuu.Name = "BTLuu";
            this.BTLuu.Size = new System.Drawing.Size(164, 31);
            this.BTLuu.TabIndex = 1;
            this.BTLuu.Text = "Lưu luật kết hợp";
            this.BTLuu.UseVisualStyleBackColor = true;
            this.BTLuu.Click += new System.EventHandler(this.BTLuu_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "MinSupp";
            // 
            // txtminsupp
            // 
            this.txtminsupp.Location = new System.Drawing.Point(490, 87);
            this.txtminsupp.Name = "txtminsupp";
            this.txtminsupp.Size = new System.Drawing.Size(77, 23);
            this.txtminsupp.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(611, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "MinConf";
            // 
            // txtminconf
            // 
            this.txtminconf.Location = new System.Drawing.Point(678, 87);
            this.txtminconf.Name = "txtminconf";
            this.txtminconf.Size = new System.Drawing.Size(81, 23);
            this.txtminconf.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(568, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(757, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "%";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(71, 90);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 21);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Check all";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbtongsocot
            // 
            this.lbtongsocot.AutoSize = true;
            this.lbtongsocot.Location = new System.Drawing.Point(513, 58);
            this.lbtongsocot.Name = "lbtongsocot";
            this.lbtongsocot.Size = new System.Drawing.Size(0, 17);
            this.lbtongsocot.TabIndex = 20;
            // 
            // frmApriori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 737);
            this.Controls.Add(this.lbtongsocot);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtminconf);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtminsupp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtngay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lbsoluong);
            this.Controls.Add(this.lbluat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTLuu);
            this.Controls.Add(this.BTAPRIORI);
            this.Controls.Add(this.BTLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmApriori";
            this.Text = "DEMO APRIORI";
            this.Load += new System.EventHandler(this.frmApriori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTLoad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTAPRIORI;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.Label lbluat;
        private System.Windows.Forms.Label lbsoluong;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtngay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTLuu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtminsupp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtminconf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbtongsocot;
    }
}