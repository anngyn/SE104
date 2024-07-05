using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class DN : Form
    {
 //       SqlConnection con;
 //       SqlCommand cmd;
        string str = "Data Source=DESKTOP-MROI1QP;Initial Catalog=QLDKMHVTHP;Integrated Security=True";
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
 //       string Lenh;
        public DN()
        {
            InitializeComponent();
        }
        public static class GlobalVariables
        {
            public static string TaiKhoan { get; set; }
            public static string HK { get; set; }
            public static string NH { get; set; }
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            GlobalVariables.TaiKhoan = txtDN.Text;
            if (txtDN.Text == "" || txtMK.Text == "")
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
                return;
            }

            string taiKhoan = txtDN.Text;
            string matKhau = txtMK.Text;

            using (SqlConnection connection = new SqlConnection(str))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MaNgDung FROM DANGNHAP WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string maNgDung = reader["MaNgDung"].ToString();
                            if (maNgDung == "sv")
                            {
                                SinhVien obj = new SinhVien();
                                obj.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        private void btnPDT_Click(object sender, EventArgs e)
        {
            GlobalVariables.TaiKhoan = txtDN.Text;
            if (txtDN.Text == "" || txtMK.Text == "")
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
                return;
            }

            string taiKhoan = txtDN.Text;
            string matKhau = txtMK.Text;

            using (SqlConnection connection = new SqlConnection(str))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MaNgDung FROM DANGNHAP WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string maNgDung = reader["MaNgDung"].ToString();
                            if (maNgDung == "dt")
                            {
                                HSSV obj = new HSSV();
                                obj.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }
    }
}
