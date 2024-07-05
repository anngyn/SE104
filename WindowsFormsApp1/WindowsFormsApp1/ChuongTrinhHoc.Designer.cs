namespace WindowsFormsApp1
{
    partial class ChuongTrinhHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChuongTrinhHoc));
            this.lbCTH = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDSMHM = new System.Windows.Forms.Button();
            this.btnDSMH = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnHP = new System.Windows.Forms.Button();
            this.btnSV = new System.Windows.Forms.Button();
            this.dataCTH = new System.Windows.Forms.DataGridView();
            this.dSMHMOTRONGHOCKIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDKMHVTHPDataSet2 = new WindowsFormsApp1.QLDKMHVTHPDataSet2();
            this.btnSuaCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.dSMH_MO_TRONG_HOC_KITableAdapter = new WindowsFormsApp1.QLDKMHVTHPDataSet2TableAdapters.DSMH_MO_TRONG_HOC_KITableAdapter();
            this.txtGC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.txtHK = new System.Windows.Forms.ComboBox();
            this.txtMMH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.ComboBox();
            this.txtMNg = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCTH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMHMOTRONGHOCKIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCTH
            // 
            this.lbCTH.AutoSize = true;
            this.lbCTH.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCTH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCTH.Location = new System.Drawing.Point(144, 16);
            this.lbCTH.Name = "lbCTH";
            this.lbCTH.Size = new System.Drawing.Size(296, 34);
            this.lbCTH.TabIndex = 0;
            this.lbCTH.Text = "Chương Trình Học";
            this.lbCTH.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.lbCTH);
            this.panel3.Location = new System.Drawing.Point(256, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 71);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnDSMHM);
            this.panel2.Controls.Add(this.btnDSMH);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnHP);
            this.panel2.Controls.Add(this.btnSV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 613);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Location = new System.Drawing.Point(107, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Khác";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(0, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "Đăng Xuất";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDSMHM
            // 
            this.btnDSMHM.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDSMHM.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSMHM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDSMHM.Location = new System.Drawing.Point(22, 473);
            this.btnDSMHM.Name = "btnDSMHM";
            this.btnDSMHM.Size = new System.Drawing.Size(248, 48);
            this.btnDSMHM.TabIndex = 5;
            this.btnDSMHM.Text = "Danh Sách Môn Học Mở";
            this.btnDSMHM.UseVisualStyleBackColor = false;
            this.btnDSMHM.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnDSMH
            // 
            this.btnDSMH.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDSMH.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSMH.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDSMH.Location = new System.Drawing.Point(22, 397);
            this.btnDSMH.Name = "btnDSMH";
            this.btnDSMH.Size = new System.Drawing.Size(248, 48);
            this.btnDSMH.TabIndex = 4;
            this.btnDSMH.Text = "Danh Sách Môn Học ";
            this.btnDSMH.UseVisualStyleBackColor = false;
            this.btnDSMH.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(22, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(248, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "Chương Trình Học";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnHP
            // 
            this.btnHP.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHP.Location = new System.Drawing.Point(22, 261);
            this.btnHP.Name = "btnHP";
            this.btnHP.Size = new System.Drawing.Size(248, 48);
            this.btnHP.TabIndex = 2;
            this.btnHP.Text = "Báo Cáo Chưa Đóng Học Phí";
            this.btnHP.UseVisualStyleBackColor = false;
            this.btnHP.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSV
            // 
            this.btnSV.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSV.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSV.Location = new System.Drawing.Point(22, 190);
            this.btnSV.Name = "btnSV";
            this.btnSV.Size = new System.Drawing.Size(248, 48);
            this.btnSV.TabIndex = 1;
            this.btnSV.Text = "Hồ Sơ Sinh Viên";
            this.btnSV.UseVisualStyleBackColor = false;
            this.btnSV.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataCTH
            // 
            this.dataCTH.BackgroundColor = System.Drawing.Color.White;
            this.dataCTH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCTH.Location = new System.Drawing.Point(290, 261);
            this.dataCTH.Name = "dataCTH";
            this.dataCTH.RowHeadersWidth = 51;
            this.dataCTH.RowTemplate.Height = 24;
            this.dataCTH.Size = new System.Drawing.Size(541, 311);
            this.dataCTH.TabIndex = 8;
            this.dataCTH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCTH_CellContentClick);
            // 
            // dSMHMOTRONGHOCKIBindingSource
            // 
            this.dSMHMOTRONGHOCKIBindingSource.DataMember = "DSMH_MO_TRONG_HOC_KI";
            this.dSMHMOTRONGHOCKIBindingSource.DataSource = this.qLDKMHVTHPDataSet2;
            // 
            // qLDKMHVTHPDataSet2
            // 
            this.qLDKMHVTHPDataSet2.DataSetName = "QLDKMHVTHPDataSet2";
            this.qLDKMHVTHPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCT.Location = new System.Drawing.Point(739, 222);
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(59, 29);
            this.btnSuaCT.TabIndex = 63;
            this.btnSuaCT.Text = "Sửa";
            this.btnSuaCT.UseVisualStyleBackColor = true;
            this.btnSuaCT.Click += new System.EventHandler(this.btnSuaCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCT.Location = new System.Drawing.Point(658, 222);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(59, 29);
            this.btnXoaCT.TabIndex = 62;
            this.btnXoaCT.Text = "Xóa";
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(305, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 56;
            this.label7.Text = "Mã Ngành";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Học Kì:";
            // 
            // btnThemCT
            // 
            this.btnThemCT.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCT.Location = new System.Drawing.Point(581, 222);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(59, 29);
            this.btnThemCT.TabIndex = 49;
            this.btnThemCT.Text = "Thêm ";
            this.btnThemCT.UseVisualStyleBackColor = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // dSMH_MO_TRONG_HOC_KITableAdapter
            // 
            this.dSMH_MO_TRONG_HOC_KITableAdapter.ClearBeforeFill = true;
            // 
            // txtGC
            // 
            this.txtGC.Location = new System.Drawing.Point(676, 134);
            this.txtGC.Name = "txtGC";
            this.txtGC.Size = new System.Drawing.Size(144, 23);
            this.txtGC.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(562, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 71;
            this.label5.Text = "Ghi Chú";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(306, 226);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(164, 23);
            this.txtTim.TabIndex = 73;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged_1);
            // 
            // txtHK
            // 
            this.txtHK.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHK.FormattingEnabled = true;
            this.txtHK.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.txtHK.Location = new System.Drawing.Point(390, 88);
            this.txtHK.Name = "txtHK";
            this.txtHK.Size = new System.Drawing.Size(144, 26);
            this.txtHK.TabIndex = 78;
            // 
            // txtMMH
            // 
            this.txtMMH.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMMH.FormattingEnabled = true;
            this.txtMMH.Location = new System.Drawing.Point(676, 89);
            this.txtMMH.Name = "txtMMH";
            this.txtMMH.Size = new System.Drawing.Size(144, 26);
            this.txtMMH.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "Mã Môn Học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(564, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 80;
            this.label2.Text = "Tên Môn Học";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.FormattingEnabled = true;
            this.txtTen.Location = new System.Drawing.Point(676, 175);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(144, 26);
            this.txtTen.TabIndex = 81;
            // 
            // txtMNg
            // 
            this.txtMNg.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMNg.FormattingEnabled = true;
            this.txtMNg.Location = new System.Drawing.Point(390, 132);
            this.txtMNg.Name = "txtMNg";
            this.txtMNg.Size = new System.Drawing.Size(144, 26);
            this.txtMNg.TabIndex = 82;
            // 
            // ChuongTrinhHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 613);
            this.Controls.Add(this.txtMNg);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHK);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGC);
            this.Controls.Add(this.txtMMH);
            this.Controls.Add(this.btnSuaCT);
            this.Controls.Add(this.btnXoaCT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThemCT);
            this.Controls.Add(this.dataCTH);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ChuongTrinhHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương Trình Học";
            this.Load += new System.EventHandler(this.ChuongTrinhHoc_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCTH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMHMOTRONGHOCKIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCTH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDSMHM;
        private System.Windows.Forms.Button btnDSMH;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnHP;
        private System.Windows.Forms.Button btnSV;
        private System.Windows.Forms.DataGridView dataCTH;
        private System.Windows.Forms.Button btnSuaCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemCT;
        private QLDKMHVTHPDataSet2 qLDKMHVTHPDataSet2;
        private System.Windows.Forms.BindingSource dSMHMOTRONGHOCKIBindingSource;
        private QLDKMHVTHPDataSet2TableAdapters.DSMH_MO_TRONG_HOC_KITableAdapter dSMH_MO_TRONG_HOC_KITableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtGC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.ComboBox txtHK;
        private System.Windows.Forms.ComboBox txtMMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtTen;
        private System.Windows.Forms.ComboBox txtMNg;
    }
}