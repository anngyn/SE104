namespace WindowsFormsApp1
{
    partial class DSMH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSMH));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbDSMH = new System.Windows.Forms.Label();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDSMHM = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCTH = new System.Windows.Forms.Button();
            this.btnHP = new System.Windows.Forms.Button();
            this.btnSV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtDSMH = new System.Windows.Forms.DataGridView();
            this.dSMHBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.databasemain = new WindowsFormsApp1.databasemain();
            this.dSMHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDKMHVTHPDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDKMHVTHPDataSet2 = new WindowsFormsApp1.QLDKMHVTHPDataSet2();
            this.cbMaNganh = new System.Windows.Forms.ComboBox();
            this.txtTMH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMMH = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtMLM = new System.Windows.Forms.ComboBox();
            this.dSMHTableAdapter = new WindowsFormsApp1.QLDKMHVTHPDataSet2TableAdapters.DSMHTableAdapter();
            this.nbst = new System.Windows.Forms.NumericUpDown();
            this.qLDKMHVTHPDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSMHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLDKMHVTHPDataSet3 = new WindowsFormsApp1.QLDKMHVTHPDataSet3();
            this.dSMHBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dSMHTableAdapter1 = new WindowsFormsApp1.QLDKMHVTHPDataSet3TableAdapters.DSMHTableAdapter();
            this.dSMHBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dSMHTableAdapter2 = new WindowsFormsApp1.databasemainTableAdapters.DSMHTableAdapter();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMHBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasemain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSet2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMHBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMHBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.lbDSMH);
            this.panel3.Location = new System.Drawing.Point(289, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 72);
            this.panel3.TabIndex = 6;
            // 
            // lbDSMH
            // 
            this.lbDSMH.AutoSize = true;
            this.lbDSMH.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSMH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDSMH.Location = new System.Drawing.Point(134, 27);
            this.lbDSMH.Name = "lbDSMH";
            this.lbDSMH.Size = new System.Drawing.Size(326, 34);
            this.lbDSMH.TabIndex = 0;
            this.lbDSMH.Text = "Danh Sách Môn Học";
            this.lbDSMH.Click += new System.EventHandler(this.lbDSMH_Click);
            // 
            // btnThemMH
            // 
            this.btnThemMH.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMH.Location = new System.Drawing.Point(616, 160);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(67, 29);
            this.btnThemMH.TabIndex = 8;
            this.btnThemMH.Text = "Thêm ";
            this.btnThemMH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMH.UseVisualStyleBackColor = true;
            this.btnThemMH.Click += new System.EventHandler(this.button6_Click);
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
            this.btnDSMHM.Location = new System.Drawing.Point(21, 473);
            this.btnDSMHM.Name = "btnDSMHM";
            this.btnDSMHM.Size = new System.Drawing.Size(248, 48);
            this.btnDSMHM.TabIndex = 5;
            this.btnDSMHM.Text = "Danh Sách Môn Học Mở";
            this.btnDSMHM.UseVisualStyleBackColor = false;
            this.btnDSMHM.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(21, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(248, 48);
            this.button4.TabIndex = 4;
            this.button4.Text = "Danh Sách Môn Học ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnCTH
            // 
            this.btnCTH.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCTH.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTH.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCTH.Location = new System.Drawing.Point(21, 328);
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
            this.btnHP.Location = new System.Drawing.Point(21, 261);
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
            this.btnSV.Location = new System.Drawing.Point(21, 190);
            this.btnSV.Name = "btnSV";
            this.btnSV.Size = new System.Drawing.Size(248, 48);
            this.btnSV.TabIndex = 1;
            this.btnSV.Text = "Hồ Sơ Sinh Viên";
            this.btnSV.UseVisualStyleBackColor = false;
            this.btnSV.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnDSMHM);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnCTH);
            this.panel2.Controls.Add(this.btnHP);
            this.panel2.Controls.Add(this.btnSV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 613);
            this.panel2.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.Location = new System.Drawing.Point(102, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Khác";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // dtDSMH
            // 
            this.dtDSMH.BackgroundColor = System.Drawing.Color.White;
            this.dtDSMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDSMH.Location = new System.Drawing.Point(289, 210);
            this.dtDSMH.Name = "dtDSMH";
            this.dtDSMH.RowHeadersWidth = 51;
            this.dtDSMH.RowTemplate.Height = 24;
            this.dtDSMH.Size = new System.Drawing.Size(592, 359);
            this.dtDSMH.TabIndex = 10;
            this.dtDSMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDSMH_CellContentClick);
            // 
            // dSMHBindingSource4
            // 
            this.dSMHBindingSource4.DataMember = "DSMH";
            this.dSMHBindingSource4.DataSource = this.databasemain;
            // 
            // databasemain
            // 
            this.databasemain.DataSetName = "databasemain";
            this.databasemain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSMHBindingSource
            // 
            this.dSMHBindingSource.DataMember = "DSMH";
            this.dSMHBindingSource.DataSource = this.qLDKMHVTHPDataSet2BindingSource;
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
            // cbMaNganh
            // 
            this.cbMaNganh.FormattingEnabled = true;
            this.cbMaNganh.Location = new System.Drawing.Point(431, 159);
            this.cbMaNganh.Name = "cbMaNganh";
            this.cbMaNganh.Size = new System.Drawing.Size(159, 24);
            this.cbMaNganh.TabIndex = 44;
            // 
            // txtTMH
            // 
            this.txtTMH.Location = new System.Drawing.Point(431, 125);
            this.txtTMH.Name = "txtTMH";
            this.txtTMH.Size = new System.Drawing.Size(159, 23);
            this.txtTMH.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(616, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "Mã Loại Môn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "Mã Ngành:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(616, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "Số Tiết:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "Mã Môn Học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tên Môn Học:";
            // 
            // txtMMH
            // 
            this.txtMMH.Location = new System.Drawing.Point(431, 90);
            this.txtMMH.Name = "txtMMH";
            this.txtMMH.Size = new System.Drawing.Size(159, 23);
            this.txtMMH.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(710, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 29);
            this.button2.TabIndex = 47;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(792, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 29);
            this.button3.TabIndex = 48;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtMLM
            // 
            this.txtMLM.FormattingEnabled = true;
            this.txtMLM.Location = new System.Drawing.Point(731, 91);
            this.txtMLM.Name = "txtMLM";
            this.txtMLM.Size = new System.Drawing.Size(120, 24);
            this.txtMLM.TabIndex = 49;
            // 
            // dSMHTableAdapter
            // 
            this.dSMHTableAdapter.ClearBeforeFill = true;
            // 
            // nbst
            // 
            this.nbst.Location = new System.Drawing.Point(731, 126);
            this.nbst.Name = "nbst";
            this.nbst.Size = new System.Drawing.Size(120, 23);
            this.nbst.TabIndex = 52;
            // 
            // qLDKMHVTHPDataSet2BindingSource1
            // 
            this.qLDKMHVTHPDataSet2BindingSource1.DataSource = this.qLDKMHVTHPDataSet2;
            this.qLDKMHVTHPDataSet2BindingSource1.Position = 0;
            // 
            // dSMHBindingSource1
            // 
            this.dSMHBindingSource1.DataMember = "DSMH";
            this.dSMHBindingSource1.DataSource = this.qLDKMHVTHPDataSet2;
            // 
            // qLDKMHVTHPDataSet3
            // 
            this.qLDKMHVTHPDataSet3.DataSetName = "QLDKMHVTHPDataSet3";
            this.qLDKMHVTHPDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSMHBindingSource2
            // 
            this.dSMHBindingSource2.DataMember = "DSMH";
            this.dSMHBindingSource2.DataSource = this.qLDKMHVTHPDataSet3;
            // 
            // dSMHTableAdapter1
            // 
            this.dSMHTableAdapter1.ClearBeforeFill = true;
            // 
            // dSMHBindingSource3
            // 
            this.dSMHBindingSource3.DataMember = "DSMH";
            this.dSMHBindingSource3.DataSource = this.qLDKMHVTHPDataSet3;
            // 
            // dSMHTableAdapter2
            // 
            this.dSMHTableAdapter2.ClearBeforeFill = true;
            // 
            // DSMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 613);
            this.Controls.Add(this.nbst);
            this.Controls.Add(this.txtMLM);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbMaNganh);
            this.Controls.Add(this.txtTMH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMMH);
            this.Controls.Add(this.dtDSMH);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnThemMH);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "DSMH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh_Sách_Môn_Học";
            this.Load += new System.EventHandler(this.DSMH_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMHBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasemain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSet2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMHBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMHBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbDSMH;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDSMHM;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCTH;
        private System.Windows.Forms.Button btnHP;
        private System.Windows.Forms.Button btnSV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtDSMH;
        private System.Windows.Forms.ComboBox cbMaNganh;
        private System.Windows.Forms.TextBox txtTMH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMMH;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox txtMLM;
        private System.Windows.Forms.BindingSource qLDKMHVTHPDataSet2BindingSource;
        private QLDKMHVTHPDataSet2 qLDKMHVTHPDataSet2;
        private System.Windows.Forms.BindingSource dSMHBindingSource;
        private QLDKMHVTHPDataSet2TableAdapters.DSMHTableAdapter dSMHTableAdapter;
        private System.Windows.Forms.NumericUpDown nbst;
        private System.Windows.Forms.BindingSource dSMHBindingSource1;
        private System.Windows.Forms.BindingSource qLDKMHVTHPDataSet2BindingSource1;
        private QLDKMHVTHPDataSet3 qLDKMHVTHPDataSet3;
        private System.Windows.Forms.BindingSource dSMHBindingSource2;
        private QLDKMHVTHPDataSet3TableAdapters.DSMHTableAdapter dSMHTableAdapter1;
        private System.Windows.Forms.BindingSource dSMHBindingSource3;
        private databasemain databasemain;
        private System.Windows.Forms.BindingSource dSMHBindingSource4;
        private databasemainTableAdapters.DSMHTableAdapter dSMHTableAdapter2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}