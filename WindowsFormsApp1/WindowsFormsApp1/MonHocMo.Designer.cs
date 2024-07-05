namespace WindowsFormsApp1
{
    partial class MonHocMo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonHocMo));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDX = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDSMH = new System.Windows.Forms.Button();
            this.btnCTH = new System.Windows.Forms.Button();
            this.btnHP = new System.Windows.Forms.Button();
            this.btnSV = new System.Windows.Forms.Button();
            this.lbDSMHM = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtMHM = new System.Windows.Forms.DataGridView();
            this.dSMHMOTRONGHOCKIBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLDKMHVTHPDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDKMHVTHPDataSet2 = new WindowsFormsApp1.QLDKMHVTHPDataSet2();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHK = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dSMHMOTRONGHOCKIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMH_MO_TRONG_HOC_KITableAdapter = new WindowsFormsApp1.QLDKMHVTHPDataSet2TableAdapters.DSMH_MO_TRONG_HOC_KITableAdapter();
            this.btnChinh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMHM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMHMOTRONGHOCKIBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMHMOTRONGHOCKIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnDX);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.btnDSMH);
            this.panel2.Controls.Add(this.btnCTH);
            this.panel2.Controls.Add(this.btnHP);
            this.panel2.Controls.Add(this.btnSV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 613);
            this.panel2.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Location = new System.Drawing.Point(97, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Liên Hệ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnDX
            // 
            this.btnDX.AutoSize = true;
            this.btnDX.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDX.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDX.Location = new System.Drawing.Point(0, 543);
            this.btnDX.Name = "btnDX";
            this.btnDX.Size = new System.Drawing.Size(292, 70);
            this.btnDX.TabIndex = 6;
            this.btnDX.Text = "Đăng Xuất";
            this.btnDX.UseVisualStyleBackColor = false;
            this.btnDX.Click += new System.EventHandler(this.btnDX_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(22, 473);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(248, 48);
            this.button5.TabIndex = 5;
            this.button5.Text = "Danh Sách Môn Học Mở";
            this.button5.UseVisualStyleBackColor = false;
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
            // btnCTH
            // 
            this.btnCTH.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCTH.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTH.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCTH.Location = new System.Drawing.Point(22, 328);
            this.btnCTH.Name = "btnCTH";
            this.btnCTH.Size = new System.Drawing.Size(248, 48);
            this.btnCTH.TabIndex = 3;
            this.btnCTH.Text = "Chương Trình Học";
            this.btnCTH.UseVisualStyleBackColor = false;
            this.btnCTH.Click += new System.EventHandler(this.button3_Click);
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
            // lbDSMHM
            // 
            this.lbDSMHM.AutoSize = true;
            this.lbDSMHM.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSMHM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDSMHM.Location = new System.Drawing.Point(94, 27);
            this.lbDSMHM.Name = "lbDSMHM";
            this.lbDSMHM.Size = new System.Drawing.Size(382, 34);
            this.lbDSMHM.TabIndex = 0;
            this.lbDSMHM.Text = "Danh Sách Môn Học Mở";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.lbDSMHM);
            this.panel3.Location = new System.Drawing.Point(290, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(542, 73);
            this.panel3.TabIndex = 11;
            // 
            // dtMHM
            // 
            this.dtMHM.BackgroundColor = System.Drawing.Color.White;
            this.dtMHM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMHM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checkbox});
            this.dtMHM.Location = new System.Drawing.Point(290, 163);
            this.dtMHM.Name = "dtMHM";
            this.dtMHM.RowHeadersWidth = 51;
            this.dtMHM.RowTemplate.Height = 24;
            this.dtMHM.Size = new System.Drawing.Size(543, 408);
            this.dtMHM.TabIndex = 13;
            // 
            // dSMHMOTRONGHOCKIBindingSource1
            // 
            this.dSMHMOTRONGHOCKIBindingSource1.DataMember = "DSMH_MO_TRONG_HOC_KI";
            this.dSMHMOTRONGHOCKIBindingSource1.DataSource = this.qLDKMHVTHPDataSet2BindingSource;
            // 
            // qLDKMHVTHPDataSet2BindingSource
            // 
            this.qLDKMHVTHPDataSet2BindingSource.DataSource = this.qLDKMHVTHPDataSet2;
            this.qLDKMHVTHPDataSet2BindingSource.Position = 0;
            // 
            // qLDKMHVTHPDataSet2
            // 
            this.qLDKMHVTHPDataSet2.DataSetName = "QLDKMHVTHPDataSet2";
            this.qLDKMHVTHPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(390, 93);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(120, 24);
            this.cbNam.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "Năm Học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 59;
            this.label1.Text = "Học Kì:";
            // 
            // cbHK
            // 
            this.cbHK.FormattingEnabled = true;
            this.cbHK.Location = new System.Drawing.Point(584, 94);
            this.cbHK.Name = "cbHK";
            this.cbHK.Size = new System.Drawing.Size(120, 24);
            this.cbHK.TabIndex = 63;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 24);
            this.button1.TabIndex = 64;
            this.button1.Text = "Kết Quả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dSMHMOTRONGHOCKIBindingSource
            // 
            this.dSMHMOTRONGHOCKIBindingSource.DataMember = "DSMH_MO_TRONG_HOC_KI";
            this.dSMHMOTRONGHOCKIBindingSource.DataSource = this.qLDKMHVTHPDataSet2;
            // 
            // dSMH_MO_TRONG_HOC_KITableAdapter
            // 
            this.dSMH_MO_TRONG_HOC_KITableAdapter.ClearBeforeFill = true;
            // 
            // btnChinh
            // 
            this.btnChinh.Location = new System.Drawing.Point(503, 124);
            this.btnChinh.Name = "btnChinh";
            this.btnChinh.Size = new System.Drawing.Size(96, 33);
            this.btnChinh.TabIndex = 65;
            this.btnChinh.Text = "Chỉnh Sửa";
            this.btnChinh.UseVisualStyleBackColor = true;
            this.btnChinh.Click += new System.EventHandler(this.btnChinh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(621, 124);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 33);
            this.btnXoa.TabIndex = 66;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Checkbox
            // 
            this.Checkbox.HeaderText = "Chọn";
            this.Checkbox.MinimumWidth = 6;
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Width = 125;
            // 
            // MonHocMo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 613);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChinh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbHK);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtMHM);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "MonHocMo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Môn Học Mở";
            this.Load += new System.EventHandler(this.MonHocMo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMHM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMHMOTRONGHOCKIBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMHMOTRONGHOCKIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDX;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnDSMH;
        private System.Windows.Forms.Button btnCTH;
        private System.Windows.Forms.Button btnHP;
        private System.Windows.Forms.Button btnSV;
        private System.Windows.Forms.Label lbDSMHM;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtMHM;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHK;
        private QLDKMHVTHPDataSet2 qLDKMHVTHPDataSet2;
        private System.Windows.Forms.BindingSource dSMHMOTRONGHOCKIBindingSource;
        private QLDKMHVTHPDataSet2TableAdapters.DSMH_MO_TRONG_HOC_KITableAdapter dSMH_MO_TRONG_HOC_KITableAdapter;
        private System.Windows.Forms.BindingSource dSMHMOTRONGHOCKIBindingSource1;
        private System.Windows.Forms.BindingSource qLDKMHVTHPDataSet2BindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
    }
}