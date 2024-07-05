namespace WindowsFormsApp1
{
    partial class test
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLDKMHVTHPDataSet = new WindowsFormsApp1.QLDKMHVTHPDataSet();
            this.qLDKMHVTHPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTNGANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTNGANHTableAdapter = new WindowsFormsApp1.QLDKMHVTHPDataSetTableAdapters.CTNGANHTableAdapter();
            this.txtNH = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTNGANHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checkbox});
            this.dataGridView1.Location = new System.Drawing.Point(0, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 359);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Checkbox
            // 
            this.Checkbox.HeaderText = "Chọn";
            this.Checkbox.MinimumWidth = 6;
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 28);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // qLDKMHVTHPDataSet
            // 
            this.qLDKMHVTHPDataSet.DataSetName = "QLDKMHVTHPDataSet";
            this.qLDKMHVTHPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLDKMHVTHPDataSetBindingSource
            // 
            this.qLDKMHVTHPDataSetBindingSource.DataSource = this.qLDKMHVTHPDataSet;
            this.qLDKMHVTHPDataSetBindingSource.Position = 0;
            // 
            // cTNGANHBindingSource
            // 
            this.cTNGANHBindingSource.DataMember = "CTNGANH";
            this.cTNGANHBindingSource.DataSource = this.qLDKMHVTHPDataSetBindingSource;
            // 
            // cTNGANHTableAdapter
            // 
            this.cTNGANHTableAdapter.ClearBeforeFill = true;
            // 
            // txtNH
            // 
            this.txtNH.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNH.Location = new System.Drawing.Point(95, 35);
            this.txtNH.Name = "txtNH";
            this.txtNH.Size = new System.Drawing.Size(100, 26);
            this.txtNH.TabIndex = 2;
            // 
            // txtNam
            // 
            this.txtNam.AutoSize = true;
            this.txtNam.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(12, 38);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(77, 18);
            this.txtNam.TabIndex = 4;
            this.txtNam.Text = "Năm Học";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(479, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Học Kỳ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(282, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtNH);
            this.Controls.Add(this.dataGridView1);
            this.Name = "test";
            this.Text = "Thêm Môn Học Mở";
            this.Load += new System.EventHandler(this.test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKMHVTHPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTNGANHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource qLDKMHVTHPDataSetBindingSource;
        private QLDKMHVTHPDataSet qLDKMHVTHPDataSet;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.BindingSource cTNGANHBindingSource;
        private QLDKMHVTHPDataSetTableAdapters.CTNGANHTableAdapter cTNGANHTableAdapter;
        private System.Windows.Forms.TextBox txtNH;
        private System.Windows.Forms.Label txtNam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
    }
}