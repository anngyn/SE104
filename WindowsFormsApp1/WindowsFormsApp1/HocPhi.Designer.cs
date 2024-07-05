namespace WindowsFormsApp1
{ 
    partial class HocPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HocPhi));
            this.frame = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateHP = new System.Windows.Forms.DateTimePicker();
            this.txtHovaTen = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.txtTongDK = new System.Windows.Forms.TextBox();
            this.txtTongDong = new System.Windows.Forms.TextBox();
            this.txtDaDong = new System.Windows.Forms.TextBox();
            this.txtConLai = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtSoTienThu = new System.Windows.Forms.TextBox();
            this.dtHP = new System.Windows.Forms.DataGridView();
            this.lbNH = new System.Windows.Forms.Label();
            this.lbHK = new System.Windows.Forms.Label();
            this.txtHK = new System.Windows.Forms.TextBox();
            this.txtNH = new System.Windows.Forms.TextBox();
            this.frame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHP)).BeginInit();
            this.SuspendLayout();
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
            this.frame.Margin = new System.Windows.Forms.Padding(0);
            this.frame.Name = "frame";
            this.frame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.frame.Size = new System.Drawing.Size(260, 613);
            this.frame.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
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
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
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
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(111)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(0, 555);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 70);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(111)))), ((int)(((byte)(153)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(-16, -11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(284, 78);
            this.button3.TabIndex = 0;
            this.button3.Text = "Đăng Xuất";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.panel_top.Controls.Add(this.label2);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(260, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(572, 62);
            this.panel_top.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(203, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin học phí ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(259, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 48);
            this.panel2.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(123, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(361, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Danh sách môn học đã đăng kí ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tổng tiền đăng kí";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(488, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tổng tiền phải đóng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(500, 528);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tổng tiền đã đóng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(513, 564);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tổng tiền còn lại";
            // 
            // dateHP
            // 
            this.dateHP.Location = new System.Drawing.Point(669, 119);
            this.dateHP.Name = "dateHP";
            this.dateHP.Size = new System.Drawing.Size(162, 26);
            this.dateHP.TabIndex = 46;
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.Location = new System.Drawing.Point(368, 119);
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.ReadOnly = true;
            this.txtHovaTen.Size = new System.Drawing.Size(199, 26);
            this.txtHovaTen.TabIndex = 43;
            this.txtHovaTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(328, 80);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.ReadOnly = true;
            this.txtMSSV.Size = new System.Drawing.Size(100, 26);
            this.txtMSSV.TabIndex = 42;
            this.txtMSSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(582, 122);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(72, 18);
            this.lbDate.TabIndex = 41;
            this.lbDate.Text = "Ngày lập";
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Location = new System.Drawing.Point(265, 83);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(57, 18);
            this.lbMSSV.TabIndex = 38;
            this.lbMSSV.Text = "MSSV:";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(265, 122);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(88, 18);
            this.lbTen.TabIndex = 37;
            this.lbTen.Text = "Họ và tên:";
            // 
            // txtTongDK
            // 
            this.txtTongDK.BackColor = System.Drawing.SystemColors.Control;
            this.txtTongDK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongDK.Location = new System.Drawing.Point(660, 464);
            this.txtTongDK.Name = "txtTongDK";
            this.txtTongDK.Size = new System.Drawing.Size(159, 19);
            this.txtTongDK.TabIndex = 47;
//            this.txtTongDK.TextChanged += new System.EventHandler(this.txtTongDK_TextChanged);
            // 
            // txtTongDong
            // 
            this.txtTongDong.BackColor = System.Drawing.SystemColors.Control;
            this.txtTongDong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongDong.Location = new System.Drawing.Point(660, 498);
            this.txtTongDong.Name = "txtTongDong";
            this.txtTongDong.Size = new System.Drawing.Size(159, 19);
            this.txtTongDong.TabIndex = 48;
            // 
            // txtDaDong
            // 
            this.txtDaDong.BackColor = System.Drawing.SystemColors.Control;
            this.txtDaDong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDaDong.Location = new System.Drawing.Point(660, 530);
            this.txtDaDong.Name = "txtDaDong";
            this.txtDaDong.Size = new System.Drawing.Size(159, 19);
            this.txtDaDong.TabIndex = 49;
            // 
            // txtConLai
            // 
            this.txtConLai.BackColor = System.Drawing.SystemColors.Control;
            this.txtConLai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConLai.Location = new System.Drawing.Point(660, 564);
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.Size = new System.Drawing.Size(159, 19);
            this.txtConLai.TabIndex = 50;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(539, 423);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(103, 33);
            this.btnNhap.TabIndex = 51;
            this.btnNhap.Text = "Thanh Toán";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtSoTienThu
            // 
            this.txtSoTienThu.Location = new System.Drawing.Point(669, 427);
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.Size = new System.Drawing.Size(151, 26);
            this.txtSoTienThu.TabIndex = 52;
            // 
            // dtHP
            // 
            this.dtHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHP.Location = new System.Drawing.Point(259, 225);
            this.dtHP.Name = "dtHP";
            this.dtHP.RowHeadersWidth = 51;
            this.dtHP.RowTemplate.Height = 24;
            this.dtHP.Size = new System.Drawing.Size(573, 188);
            this.dtHP.TabIndex = 53;
            this.dtHP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtHP_CellContentClick);
            // 
            // lbNH
            // 
            this.lbNH.AutoSize = true;
            this.lbNH.Location = new System.Drawing.Point(621, 83);
            this.lbNH.Name = "lbNH";
            this.lbNH.Size = new System.Drawing.Size(75, 18);
            this.lbNH.TabIndex = 40;
            this.lbNH.Text = "Năm học";
            // 
            // lbHK
            // 
            this.lbHK.AutoSize = true;
            this.lbHK.Location = new System.Drawing.Point(434, 83);
            this.lbHK.Name = "lbHK";
            this.lbHK.Size = new System.Drawing.Size(54, 18);
            this.lbHK.TabIndex = 39;
            this.lbHK.Text = "Học kì";
            // 
            // txtHK
            // 
            this.txtHK.Location = new System.Drawing.Point(491, 80);
            this.txtHK.Name = "txtHK";
            this.txtHK.ReadOnly = true;
            this.txtHK.Size = new System.Drawing.Size(100, 26);
            this.txtHK.TabIndex = 55;
            this.txtHK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNH
            // 
            this.txtNH.Location = new System.Drawing.Point(702, 80);
            this.txtNH.Name = "txtNH";
            this.txtNH.ReadOnly = true;
            this.txtNH.Size = new System.Drawing.Size(100, 26);
            this.txtNH.TabIndex = 56;
            this.txtNH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(832, 613);
            this.Controls.Add(this.txtNH);
            this.Controls.Add(this.txtHK);
            this.Controls.Add(this.dtHP);
            this.Controls.Add(this.txtSoTienThu);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtConLai);
            this.Controls.Add(this.txtDaDong);
            this.Controls.Add(this.txtTongDong);
            this.Controls.Add(this.txtTongDK);
            this.Controls.Add(this.dateHP);
            this.Controls.Add(this.txtHovaTen);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbHK);
            this.Controls.Add(this.lbMSSV);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbNH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.frame);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(850, 660);
            this.MinimumSize = new System.Drawing.Size(850, 660);
            this.Name = "HocPhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thu học phí";
            this.Load += new System.EventHandler(this.HocPhi_Load);
            this.frame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel frame;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateHP;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.TextBox txtTongDK;
        private System.Windows.Forms.TextBox txtTongDong;
        private System.Windows.Forms.TextBox txtDaDong;
        private System.Windows.Forms.TextBox txtConLai;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtSoTienThu;
        private System.Windows.Forms.DataGridView dtHP;
        private System.Windows.Forms.Label lbNH;
        private System.Windows.Forms.Label lbHK;
        private System.Windows.Forms.TextBox txtHK;
        private System.Windows.Forms.TextBox txtNH;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}