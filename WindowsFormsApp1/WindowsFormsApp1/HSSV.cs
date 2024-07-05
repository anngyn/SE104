using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class HSSV : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-MROI1QP;Initial Catalog=QLDKMHVTHP;Integrated Security=True";
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string Lenh;
        SqlDataReader dr;
        public HSSV()
        {
            InitializeComponent();
            con = new SqlConnection(str);
            loaddata();
            loadHuyen();
            loadDT();
            loadNganh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DN obj = new DN();
            obj.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DongHP obj = new DongHP();
            obj.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ChuongTrinhHoc obj = new ChuongTrinhHoc();
            obj.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DSMH obj = new DSMH();
            obj.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            MonHocMo obj = new MonHocMo();
            obj.Show();
            this.Hide();
        }

        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from SINHVIEN";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            SVList.DataSource = dt;
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            cmd.Transaction = transaction;

                            string mssv = txtMSSV.Text.Length > 8 ? txtMSSV.Text.Substring(0, 8) : txtMSSV.Text;

                            cmd.CommandText = "INSERT INTO SINHVIEN VALUES (@MSSV, @HoTen, @NgaySinh, @GioiTinh, @Huyen, @DT, @Nganh)";
                            cmd.Parameters.AddWithValue("@MSSV", mssv);
                            cmd.Parameters.AddWithValue("@HoTen", txtName.Text);
                            cmd.Parameters.AddWithValue("@NgaySinh", date.Value);
                            cmd.Parameters.AddWithValue("@GioiTinh", txtGT.Text);
                            cmd.Parameters.AddWithValue("@Huyen", txtHuyen.SelectedValue);
                            cmd.Parameters.AddWithValue("@DT", txtDT.SelectedValue);
                            cmd.Parameters.AddWithValue("@Nganh", txtNghanh.SelectedValue);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }

            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            cmd.Transaction = transaction;

                            string mssv = txtMSSV.Text.Length > 8 ? txtMSSV.Text.Substring(0, 8) : txtMSSV.Text;

                            cmd.CommandText = "UPDATE SINHVIEN SET " +
                                "HoTen = @HoTen, " +
                                "NgaySinh = @NgaySinh, " +
                                "GioiTinh = @GioiTinh, " +
                                "MaNganh = @Nganh, " +
                                "MaDT = @DT, " +
                                "MaHuyen = @Huyen " +
                                "WHERE MSSV = @MSSV";
                            cmd.Parameters.AddWithValue("@MSSV", mssv);
                            cmd.Parameters.AddWithValue("@HoTen", txtName.Text);
                            cmd.Parameters.AddWithValue("@NgaySinh", date.Value);
                            cmd.Parameters.AddWithValue("@GioiTinh", txtGT.Text);
                            cmd.Parameters.AddWithValue("@Huyen", txtHuyen.SelectedValue);
                            cmd.Parameters.AddWithValue("@DT", txtDT.SelectedValue);
                            cmd.Parameters.AddWithValue("@Nganh", txtNghanh.SelectedValue);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }

            loaddata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            cmd.Transaction = transaction;

                            string mssv = txtMSSV.Text.Length > 8 ? txtMSSV.Text.Substring(0, 8) : txtMSSV.Text;

                            cmd.CommandText = "DELETE FROM SINHVIEN WHERE MSSV = @MSSV";
                            cmd.Parameters.AddWithValue("@MSSV", mssv);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }

            loaddata();
        }

        private void SVList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = SVList.CurrentRow.Index;
            txtMSSV.Text = SVList.Rows[i].Cells[0].Value.ToString();
            txtName.Text = SVList.Rows[i].Cells[1].Value.ToString();
            date.Text = SVList.Rows[i].Cells[2].Value.ToString();
            txtHuyen.Text = SVList.Rows[i].Cells[4].Value.ToString();
            txtGT.Text = SVList.Rows[i].Cells[3].Value.ToString();
            txtDT.Text = SVList.Rows[i].Cells[5].Value.ToString();
            txtNghanh.Text = SVList.Rows[i].Cells[6].Value.ToString();
        }

        void loadHuyen()
        {
            DataTable dtHuyen = new DataTable();
            Lenh = "SELECT MaHuyen, TenHuyen FROM HUYEN";
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(Lenh, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtHuyen);
                }
                con.Close();
            }
            txtHuyen.DataSource = dtHuyen;
            txtHuyen.DisplayMember = "TenHuyen";
            txtHuyen.ValueMember = "MaHuyen";
        }

        void loadDT()
        {
            DataTable dtDT = new DataTable();
            Lenh = "SELECT MaDT, TenLoaiDT FROM DTUT";
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(Lenh, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtDT);
                }
                con.Close();
            }
            txtDT.DataSource = dtDT;
            txtDT.DisplayMember = "TenLoaiDT";
            txtDT.ValueMember = "MaDT";
        }

        void loadNganh()
        {
            DataTable dtNganh = new DataTable();
            Lenh = "SELECT MaNganh, TenNganh FROM NGANH";
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(Lenh, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtNganh);
                }
                con.Close();
            }
            txtNghanh.DataSource = dtNganh;
            txtNghanh.DisplayMember = "TenNganh";
            txtNghanh.ValueMember = "MaNganh";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TestDongHP obj = new TestDongHP();
            obj.Show();
        }
    }

}





