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
    public partial class DSMH : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-MROI1QP;Initial Catalog=QLDKMHVTHP;Integrated Security=True";
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string Lenh;
        SqlDataReader dr;
        public DSMH()
        {
            InitializeComponent();
            con = new SqlConnection(str);
            loaddata();
            loadMaNganh();
            loadMLM();


        }

        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from DSMH";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            dtDSMH.DataSource = dt;
        }
        void loadMaNganh()
        {
            Lenh = "SELECT MaNganh FROM NGANH";
            con.Open();
            cmd = new SqlCommand(Lenh, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbMaNganh.Items.Add(dr[0].ToString());
            }
            con.Close();
        }

        void loadMLM()
        {
            Lenh = "SELECT MaLoaiMon FROM LOAIMON";
            con.Open();
            cmd = new SqlCommand(Lenh, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtMLM.Items.Add(dr[0].ToString());
            }
            con.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Kiểm tra mã môn học đã tồn tại hay chưa
                        string checkQuery = "SELECT COUNT(*) FROM DSMH WHERE MaMonHoc = @MaMonHoc";
                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, con, transaction))
                        {
                            checkCmd.Parameters.AddWithValue("@MaMonHoc", txtMMH.Text);
                            int count = (int)checkCmd.ExecuteScalar();
                            if (count > 0)
                            {
                                throw new Exception("Mã môn học đã tồn tại.");
                            }
                        }

                        // Lấy thông tin từ bảng LOAIMON
                        string queryLoaiMon = "SELECT SoTietTinChi FROM LOAIMON WHERE MaLoaiMon = @MaLoaiMon";
                        decimal soTietTinChi = 0;

                        using (SqlCommand cmd = new SqlCommand(queryLoaiMon, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@MaLoaiMon", txtMLM.Text);
                            object result = cmd.ExecuteScalar();

                            if (result != null)
                            {
                                soTietTinChi = Convert.ToDecimal(result);
                            }
                            else
                            {
                                throw new Exception("Không tìm thấy thông tin loại môn học.");
                            }
                        }

                        // Tính SoTinChi dựa trên SoTiet và SoTietTinChi
                        decimal soTiet = Convert.ToDecimal(nbst.Text);
                        decimal soTinChi = soTiet / soTietTinChi;

                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            cmd.Transaction = transaction;

                            // Insert vào bảng DSMH
                            cmd.CommandText = "INSERT INTO DSMH (MaMonHoc, TenMonHoc, MaLoaiMon, SoTiet, MaNganh, SoTinChi) VALUES (@MaMonHoc, @TenMonHoc, @MaLoaiMon, @SoTiet, @MaNganh, @SoTinChi)";

                            // Thêm các tham số
                            cmd.Parameters.AddWithValue("@MaMonHoc", txtMMH.Text);
                            cmd.Parameters.AddWithValue("@TenMonHoc", txtTMH.Text);
                            cmd.Parameters.AddWithValue("@MaLoaiMon", txtMLM.Text);
                            cmd.Parameters.AddWithValue("@SoTiet", soTiet);
                            cmd.Parameters.AddWithValue("@MaNganh", cbMaNganh.Text);
                            cmd.Parameters.AddWithValue("@SoTinChi", soTinChi);

                            // Thực hiện lệnh
                            cmd.ExecuteNonQuery();
                        }

                        // Commit transaction
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction on error
                        transaction.Rollback();
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }

            loaddata();
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

        private void button5_Click(object sender, EventArgs e)
        {
            MonHocMo obj = new MonHocMo();
            obj.Show();
            this.Hide();
        }

        private void DSMH_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'databasemain.DSMH' table. You can move, or remove it, as needed.
            //this.dSMHTableAdapter2.Fill(this.databasemain.DSMH);
            //// TODO: This line of code loads data into the 'qLDKMHVTHPDataSet3.DSMH' table. You can move, or remove it, as needed.
            //this.dSMHTableAdapter1.Fill(this.qLDKMHVTHPDataSet3.DSMH);
            //// TODO: This line of code loads data into the 'qLDKMHVTHPDataSet2.DSMH' table. You can move, or remove it, as needed.
            //this.dSMHTableAdapter.Fill(this.qLDKMHVTHPDataSet2.DSMH);

        }



        private void lbDSMH_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DN obj = new DN();
            obj.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Kiểm tra mã môn học tồn tại
                        string checkQuery = "SELECT COUNT(*) FROM DSMH WHERE MaMonHoc = @MaMonHoc";
                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, con, transaction))
                        {
                            checkCmd.Parameters.AddWithValue("@MaMonHoc", txtMMH.Text);
                            int count = (int)checkCmd.ExecuteScalar();
                            if (count == 0)
                            {
                                throw new Exception("Mã môn học không tồn tại.");
                            }
                        }

                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            cmd.Transaction = transaction;

                            // Xóa bản ghi trong bảng DSMH
                            cmd.CommandText = "DELETE FROM DSMH WHERE MaMonHoc = @MaMonHoc";

                            // Thêm các tham số
                            cmd.Parameters.AddWithValue("@MaMonHoc", txtMMH.Text);

                            // Thực hiện lệnh
                            cmd.ExecuteNonQuery();
                        }

                        // Commit transaction
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction on error
                        transaction.Rollback();
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }

            loaddata();
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Kiểm tra mã môn học tồn tại
                        string checkQuery = "SELECT COUNT(*) FROM DSMH WHERE MaMonHoc = @MaMonHoc";
                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, con, transaction))
                        {
                            checkCmd.Parameters.AddWithValue("@MaMonHoc", txtMMH.Text);
                            int count = (int)checkCmd.ExecuteScalar();
                            if (count == 0)
                            {
                                throw new Exception("Mã môn học không tồn tại.");
                            }
                        }

                        // Lấy thông tin từ bảng LOAIMON
                        string queryLoaiMon = "SELECT SoTietTinChi FROM LOAIMON WHERE MaLoaiMon = @MaLoaiMon";
                        decimal soTietTinChi = 0;

                        using (SqlCommand cmd = new SqlCommand(queryLoaiMon, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@MaLoaiMon", txtMLM.Text);
                            object result = cmd.ExecuteScalar();

                            if (result != null)
                            {
                                soTietTinChi = Convert.ToDecimal(result);
                            }
                            else
                            {
                                throw new Exception("Không tìm thấy thông tin loại môn học.");
                            }
                        }

                        // Tính SoTinChi dựa trên SoTiet và SoTietTinChi
                        decimal soTiet = Convert.ToDecimal(nbst.Text);
                        decimal soTinChi = soTiet / soTietTinChi;

                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            cmd.Transaction = transaction;

                            // Update bảng DSMH
                            cmd.CommandText = "UPDATE DSMH SET TenMonHoc = @TenMonHoc, MaLoaiMon = @MaLoaiMon, SoTiet = @SoTiet, MaNganh = @MaNganh, SoTinChi = @SoTinChi WHERE MaMonHoc = @MaMonHoc";

                            // Thêm các tham số
                            cmd.Parameters.AddWithValue("@TenMonHoc", txtTMH.Text);
                            cmd.Parameters.AddWithValue("@MaLoaiMon", txtMLM.Text);
                            cmd.Parameters.AddWithValue("@SoTiet", soTiet);
                            cmd.Parameters.AddWithValue("@MaNganh", cbMaNganh.Text);
                            cmd.Parameters.AddWithValue("@SoTinChi", soTinChi);
                            cmd.Parameters.AddWithValue("@MaMonHoc", txtMMH.Text);

                            // Thực hiện lệnh
                            cmd.ExecuteNonQuery();
                        }

                        // Commit transaction
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction on error
                        transaction.Rollback();
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }

            loaddata();
        }



        private void dtDSMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtDSMH.CurrentRow.Index;
            txtMMH.Text = dtDSMH.Rows[i].Cells[0].Value.ToString();
            txtTMH.Text = dtDSMH.Rows[i].Cells[1].Value.ToString();
            nbst.Text = dtDSMH.Rows[i].Cells[3].Value.ToString();
            txtMLM.Text = dtDSMH.Rows[i].Cells[2].Value.ToString();
            cbMaNganh.Text = dtDSMH.Rows[i].Cells[4].Value.ToString();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
