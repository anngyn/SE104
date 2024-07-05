using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class ChuongTrinhHoc : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-MROI1QP;Initial Catalog=QLDKMHVTHP;Integrated Security=True";
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string Lenh;
        SqlDataReader dr;
        public ChuongTrinhHoc()
        {
            InitializeComponent();
            con = new SqlConnection(str);
            loaddata();
            loadMMH();
            loadTMH();
            loadMN();
        }
        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select HocKy, MaMonHoc, TenMonHoc, MaNganh, GhiChu from  CTNGANH ";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            dataCTH.DataSource = dt;
            dataCTH.Columns["HocKy"].HeaderText = "Học Kỳ";
            dataCTH.Columns["MaMonHoc"].HeaderText = "Mã Môn Học";
            dataCTH.Columns["MaNganh"].HeaderText = "Mã Ngành";
            dataCTH.Columns["TenMonHoc"].HeaderText = "Tên Môn Học";
            dataCTH.Columns["GhiChu"].HeaderText = "Ghi Chú";

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ChuongTrinhHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDKMHVTHPDataSet2.DSMH_MO_TRONG_HOC_KI' table. You can move, or remove it, as needed.
          //  this.dSMH_MO_TRONG_HOC_KITableAdapter.Fill(this.qLDKMHVTHPDataSet.DSMH_MO_TRONG_HOC_KI);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            HSSV obj = new HSSV();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DongHP obj = new DongHP();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChuongTrinhHoc obj = new ChuongTrinhHoc();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DSMH obj = new DSMH();
            obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MonHocMo obj = new MonHocMo();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DN obj = new DN();
            obj.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ThemCT obj = new ThemCT();
            obj.Show();

        }
        void loadMMH()
        {
            Lenh = "SELECT MaMonHoc FROM DSMH";
            con.Open();
            cmd = new SqlCommand(Lenh, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtMMH.Items.Add(dr[0].ToString());
            }
            con.Close();
        }
        void loadTMH()
        {
            Lenh = "SELECT TenMonHoc FROM DSMH ";
            con.Open();
            cmd = new SqlCommand(Lenh, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtTen.Items.Add(dr[0].ToString());
            }
            con.Close();
        }
        void loadMN()
        {
            Lenh = "SELECT MaNganh FROM DSMH ";
            con.Open();
            cmd = new SqlCommand(Lenh, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtMNg.Items.Add(dr[0].ToString());
            }
            con.Close();
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        string checkQuery = "SELECT COUNT(*) FROM CTNGANH WHERE MaMonHoc = @MaMonHoc AND HocKy = @HocKy";
                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, con, transaction))
                        {   
                            checkCmd.Parameters.AddWithValue("@MaMonHoc", txtMMH.Text);
                            checkCmd.Parameters.AddWithValue("@HocKy", txtHK.Text);
                            // Gán Transaction cho checkCmd
                            checkCmd.Transaction = transaction;
                            int count = (int)checkCmd.ExecuteScalar();
                            if (count > 0)
                            {
                                throw new Exception("Mã môn học đã tồn tại.");
                            }
                        }
                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            // Chèn vào bảng CTNGANH
                            cmd.CommandText = @"
                INSERT INTO CTNGANH (HocKy, MaMonHoc,TenMonHoc, MaNganh, GhiChu) 
                VALUES (@HocKy, @MaMonHoc, @TenMonHoc, @MaNganh, @GhiChu)";
                            cmd.Parameters.AddWithValue("@MaMonHoc", txtMMH.Text);
                            cmd.Parameters.AddWithValue("@MaNganh", txtMNg.Text);
                            cmd.Parameters.AddWithValue("@TenMonHoc", txtTen.Text);
                            cmd.Parameters.AddWithValue("@HocKy", txtHK.Text);
                            cmd.Parameters.AddWithValue("@GhiChu", txtGC.Text);
                            // Gán Transaction cho cmd
                            cmd.Transaction = transaction;
                            cmd.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("Đã thêm chương trình học thành công.", "Thông báo");
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }

            // Sau khi thêm dữ liệu thành công, cập nhật lại hiển thị dữ liệu
            loaddata();
        }



        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    // Xóa dữ liệu trong bảng CTNGANH
                    cmd.CommandText = "DELETE FROM CTNGANH WHERE HocKy = @HocKy AND MaMonHoc = @MaMonHoc AND MaNganh = @MaNganh AND TenMonHoc = @TenMonHoc" ;
                    cmd.Parameters.AddWithValue("@MaMonHoc", txtMMH.Text);
                    cmd.Parameters.AddWithValue("@MaNganh", txtMNg.Text);
                    cmd.Parameters.AddWithValue("@HocKy", txtHK.Text);
                    cmd.Parameters.AddWithValue("@TenMonHoc", txtTen.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã XÓA chương trình học thành công.", "Thông báo");
                }
                loaddata();
            }
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        string checkQuery = "SELECT COUNT(*) FROM DSMH WHERE MaMonHoc = @MaMonHoc AND MaNganh = @MaNganh";
                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, con, transaction))
                        {
                            checkCmd.Parameters.AddWithValue("@MaMonHoc", txtMMH.Text);
                            checkCmd.Parameters.AddWithValue("@MaNganh", txtMNg.Text);
                            // Gán Transaction cho checkCmd
                            checkCmd.Transaction = transaction;
                            int count = (int)checkCmd.ExecuteScalar();
                            if (count == 0)
                            {
                                throw new Exception("Cặp (MaMonHoc, MaNganh) không tồn tại trong DSMH.");
                            }
                        }
                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            // Cập nhật dữ liệu trong bảng CTNGANH
                            cmd.CommandText = @"
                            UPDATE CTNGANH 
                            SET  HocKy = @HocKy,
                                 GhiChu = @GhiChu                      
                            WHERE MaMonHoc = @MaMonHoc AND
                                TenMonHoc = @TenMonHoc AND
                                MaNganh = @MaNganh";
                            cmd.Parameters.AddWithValue("@MaMonHoc", txtMMH.Text);
                            cmd.Parameters.AddWithValue("@MaNganh", txtMNg.Text);
                            cmd.Parameters.AddWithValue("@HocKy", txtHK.Text);
                            cmd.Parameters.AddWithValue("@TenMonHoc", txtTen.Text);
                            cmd.Parameters.AddWithValue("@GhiChu", txtGC.Text);
                            // Gán Transaction cho cmd
                            cmd.Transaction = transaction;
                            cmd.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("Đã SỬA chương trình học thành công.", "Thông báo");
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // Sau khi sửa dữ liệu thành công, cập nhật lại hiển thị dữ liệu
            loaddata();
        }




        private void dataCTH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataCTH.CurrentRow.Index;
            txtMNg.Text = dataCTH.Rows[i].Cells[3].Value.ToString();
            txtHK.Text = dataCTH.Rows[i].Cells[0].Value.ToString();
            txtMMH.Text = dataCTH.Rows[i].Cells[1].Value.ToString();
            txtGC.Text = dataCTH.Rows[i].Cells[4].Value.ToString();
            txtTen.Text = dataCTH.Rows[i].Cells[2].Value.ToString();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TestDongHP obj = new TestDongHP();
            obj.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       
        private DataTable TableWithParameter(string query, string searchText)
        {
            // Connection string to your SQL Server database
            
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to the command
                   
                    cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    try
                    {
                        conn.Open();
                        da.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            return dt;
        }

        private void txtTim_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = txtTim.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                button5_Click(sender, e);
            }
            else
            {
                string query = @"
        SELECT CTNGANH.HocKy, CTNGANH.MaMonHoc, CTNGANH.MaNganh, CTNGANH.GhiChu, CTNGANH.TenMonHoc
        FROM CTNGANH
        WHERE 
        (CTNGANH.HocKy LIKE @SearchText OR CTNGANH.TenMonHoc LIKE @SearchText OR CTNGANH.MaMonHoc LIKE @SearchText OR CTNGANH.MaNganh LIKE @SearchText OR CTNGANH.GhiChu LIKE @SearchText)";

                DataTable dt = TableWithParameter(query, searchText);
                dataCTH.DataSource = dt;
            }
        }
    }


    }
