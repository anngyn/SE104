namespace WindowsFormsApp1
{
    partial class DKHP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DKHP));
            this.lbDate = new System.Windows.Forms.Label();
            this.lbHK = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.lbNH = new System.Windows.Forms.Label();
            this.btnXN = new System.Windows.Forms.Button();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtHovaTen = new System.Windows.Forms.TextBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.dtDKHP = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.frame = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbHK = new System.Windows.Forms.ComboBox();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.qLDKMHVTHPDataSet2 = new WindowsFormsApp1.QLDKMHVTHPDataSet2();
            this.cTNGANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTNGANHTableAdapter = new WindowsFormsApp1.QLDKMHVTHPDataSet2TableAdapters.CTNGANHTableAdapter();
            this.dSMHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMHTableAdapter = new WindowsFormsApp1.QLDKMHVTHPDataSet2TableAdapters.DSMHTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongDK = new System.Windows.Forms.TextBox();
            this.txtTongDong = new System.Windows.Forms.TextBox();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDKHP)).BeginInit();
            this.panel1.SuspendLayout();
            this.frame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTNGANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMHBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(265, 128);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(72, 18);
            this.lbDate.TabIndex = 23;
            this.lbDate.Text = "Ngày lập";
            // 
            // lbHK
            // 
            this.lbHK.AutoSize = true;
            this.lbHK.Location = new System.Drawing.Point(48, 25);
            this.lbHK.Name = "lbHK";
            this.lbHK.Size = new System.Drawing.Size(54, 18);
            this.lbHK.TabIndex = 21;
            this.lbHK.Text = "Học kì";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin đăng kí học phần";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.panel_top.Controls.Add(this.label2);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(259, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(573, 62);
            this.panel_top.TabIndex = 18;
            // 
            // lbNH
            // 
            this.lbNH.AutoSize = true;
            this.lbNH.Location = new System.Drawing.Point(159, 25);
            this.lbNH.Name = "lbNH";
            this.lbNH.Size = new System.Drawing.Size(75, 18);
            this.lbNH.TabIndex = 22;
            this.lbNH.Text = "Năm học";
            // 
            // btnXN
            // 
            this.btnXN.AutoSize = true;
            this.btnXN.Location = new System.Drawing.Point(465, 555);
            this.btnXN.Name = "btnXN";
            this.btnXN.Size = new System.Drawing.Size(171, 49);
            this.btnXN.TabIndex = 29;
            this.btnXN.Text = "Xác nhận";
            this.btnXN.UseVisualStyleBackColor = true;
            this.btnXN.Click += new System.EventHandler(this.btnXN_Click);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(11, 19);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.ReadOnly = true;
            this.txtMSSV.Size = new System.Drawing.Size(242, 26);
            this.txtMSSV.TabIndex = 30;
            this.txtMSSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.Location = new System.Drawing.Point(24, 18);
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.ReadOnly = true;
            this.txtHovaTen.Size = new System.Drawing.Size(251, 26);
            this.txtHovaTen.TabIndex = 31;
            this.txtHovaTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(14, 37);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(242, 26);
            this.txtTim.TabIndex = 32;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // dtDKHP
            // 
            this.dtDKHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDKHP.Location = new System.Drawing.Point(259, 251);
            this.dtDKHP.Name = "dtDKHP";
            this.dtDKHP.RowHeadersWidth = 51;
            this.dtDKHP.RowTemplate.Height = 24;
            this.dtDKHP.Size = new System.Drawing.Size(580, 208);
            this.dtDKHP.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(111)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(0, 555);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 67);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(111)))), ((int)(((byte)(153)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(-9, -10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(278, 74);
            this.button3.TabIndex = 34;
            this.button3.Text = "Đăng Xuất";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "  Lý lịch sinh viên";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(13, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "Đăng kí học phần ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 397);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thu học phí";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frame
            // 
            this.frame.BackColor = System.Drawing.Color.SteelBlue;
            this.frame.Controls.Add(this.pictureBox1);
            this.frame.Controls.Add(this.button2);
            this.frame.Controls.Add(this.button4);
            this.frame.Controls.Add(this.button1);
            this.frame.Controls.Add(this.panel1);
            this.frame.Dock = System.Windows.Forms.DockStyle.Left;
            this.frame.Font = new System.Drawing.Font("Verdana", 12F);
            this.frame.ForeColor = System.Drawing.Color.Black;
            this.frame.Location = new System.Drawing.Point(0, 0);
            this.frame.Name = "frame";
            this.frame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.frame.Size = new System.Drawing.Size(259, 613);
            this.frame.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // cbHK
            // 
            this.cbHK.FormattingEnabled = true;
            this.cbHK.Location = new System.Drawing.Point(19, 46);
            this.cbHK.Name = "cbHK";
            this.cbHK.Size = new System.Drawing.Size(108, 26);
            this.cbHK.TabIndex = 34;
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(140, 46);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(100, 26);
            this.cbNam.TabIndex = 35;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(344, 122);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(162, 26);
            this.date.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.cbNam);
            this.groupBox1.Controls.Add(this.cbHK);
            this.groupBox1.Controls.Add(this.lbNH);
            this.groupBox1.Controls.Add(this.lbHK);
            this.groupBox1.Location = new System.Drawing.Point(586, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 123);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Học Kì Năm Học";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(74, 87);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 34);
            this.button5.TabIndex = 36;
            this.button5.Text = "Chọn";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTim);
            this.groupBox2.Location = new System.Drawing.Point(263, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 88);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // qLDKMHVTHPDataSet2
            // 
            this.qLDKMHVTHPDataSet2.DataSetName = "QLDKMHVTHPDataSet2";
            this.qLDKMHVTHPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cTNGANHBindingSource
            // 
            this.cTNGANHBindingSource.DataMember = "CTNGANH";
            this.cTNGANHBindingSource.DataSource = this.qLDKMHVTHPDataSet2;
            // 
            // cTNGANHTableAdapter
            // 
            this.cTNGANHTableAdapter.ClearBeforeFill = true;
            // 
            // dSMHBindingSource
            // 
            this.dSMHBindingSource.DataMember = "DSMH";
            this.dSMHBindingSource.DataSource = this.qLDKMHVTHPDataSet2;
            // 
            // dSMHTableAdapter
            // 
            this.dSMHTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMSSV);
            this.groupBox3.Location = new System.Drawing.Point(266, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 54);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MSSV";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtHovaTen);
            this.groupBox4.Location = new System.Drawing.Point(544, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 52);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Họ và Tên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tổng Tiền Đăng Kí";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 504);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 18);
            this.label8.TabIndex = 41;
            this.label8.Text = "Tổng Tiền Phải Đóng";
            // 
            // txtTongDK
            // 
            this.txtTongDK.BackColor = System.Drawing.SystemColors.Control;
            this.txtTongDK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongDK.Location = new System.Drawing.Point(440, 472);
            this.txtTongDK.Name = "txtTongDK";
            this.txtTongDK.Size = new System.Drawing.Size(159, 19);
            this.txtTongDK.TabIndex = 48;
            // 
            // txtTongDong
            // 
            this.txtTongDong.BackColor = System.Drawing.SystemColors.Control;
            this.txtTongDong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongDong.Location = new System.Drawing.Point(440, 504);
            this.txtTongDong.Name = "txtTongDong";
            this.txtTongDong.Size = new System.Drawing.Size(159, 19);
            this.txtTongDong.TabIndex = 49;
            // 
            // DKHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 613);
            this.Controls.Add(this.txtTongDong);
            this.Controls.Add(this.txtTongDK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dtDKHP);
            this.Controls.Add(this.btnXN);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.frame);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(850, 660);
            this.MinimumSize = new System.Drawing.Size(850, 660);
            this.Name = "DKHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DKHP";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDKHP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.frame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTNGANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMHBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbHK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lbNH;
        private System.Windows.Forms.Button btnXN;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel frame;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbHK;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.DateTimePicker date;
        private QLDKMHVTHPDataSet2 qLDKMHVTHPDataSet2;
        private System.Windows.Forms.BindingSource cTNGANHBindingSource;
        private QLDKMHVTHPDataSet2TableAdapters.CTNGANHTableAdapter cTNGANHTableAdapter;
        private System.Windows.Forms.BindingSource dSMHBindingSource;
        private QLDKMHVTHPDataSet2TableAdapters.DSMHTableAdapter dSMHTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongDK;
        private System.Windows.Forms.TextBox txtTongDong;
        public System.Windows.Forms.DataGridView dtDKHP;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}