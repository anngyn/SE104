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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static WindowsFormsApp1.DN;

namespace WindowsFormsApp1
{
    public partial class SinhVien : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-MROI1QP;Initial Catalog=QLDKMHVTHP;Integrated Security=True";
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string Lenh;
        SqlDataReader dr;
        public SinhVien()
        {
            InitializeComponent();
            LoadDataFromDatabase();
            con = new SqlConnection(str);
            loadtinh();
            //loadhuyen();
           // loadtinh();
            loadKhoa ();
            //loadnganh();
            loadDT();
        }
        void loadtinh()
        {
            Lenh = "SELECT TenTinh FROM TINH";
            con.Open();
            cmd = new SqlCommand(Lenh, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbTinh.Items.Add(dr[0].ToString());
            }
            con.Close();
        }
        
        void loadDT()
        {
            Lenh = "SELECT TenLoaiDT FROM DTUT";
            con.Open();
            cmd = new SqlCommand(Lenh, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbDT.Items.Add(dr[0].ToString());
            }
            con.Close();
        }
        void loadKhoa()
        {
            Lenh = "SELECT TenKhoa FROM KHOA";
            con.Open();
            cmd = new SqlCommand(Lenh, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbKhoa.Items.Add(dr[0].ToString());
            }
            con.Close();
        }
  

        string taiKhoan = GlobalVariables.TaiKhoan;
        private void LoadDataFromDatabase()
        {
            //Khởi tạo SqlConnection
            using (SqlConnection connection = new SqlConnection(str))
            {
                // Mở kết nối
                connection.Open();

                // Chuỗi truy vấn SQL
                string query = "SELECT SINHVIEN.HoTen, SINHVIEN.NgaySinh, SINHVIEN.GioiTinh, DTUT.TenLoaiDT, HUYEN.TenHuyen, KHOA.TenKhoa, NGANH.TenNganh, TINH.TenTinh " +
                               "FROM SINHVIEN INNER JOIN " +
                               "DTUT ON SINHVIEN.MaDT = DTUT.MaDT INNER JOIN " +
                               "HUYEN ON SINHVIEN.MaHuyen = HUYEN.MaHuyen INNER JOIN " +
                               "NGANH ON SINHVIEN.MaNganh = NGANH.MaNganh INNER JOIN " +
                               "KHOA ON NGANH.MaKhoa = KHOA.MaKhoa INNER JOIN " +
                               "TINH ON HUYEN.MaTinh = TINH.MaTinh " +
                               "WHERE MSSV = @taiKhoan";

                // Khởi tạo SqlCommand để thực thi truy vấn
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm giá trị của biến taiKhoan vào tham số trong SqlCommand
                    command.Parameters.AddWithValue("@taiKhoan", taiKhoan);

                    // Thực thi truy vấn và lấy dữ liệu
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Kiểm tra xem có dòng dữ liệu nào được trả về không
                        if (reader.Read())
                        {
                            // Đọc dữ liệu từ SqlDataReader và gán vào các TextBox
                            txtMSSV.Text = taiKhoan;
                            txtHoTen.Text = reader["HoTen"].ToString();
                            date.Value = reader.GetDateTime(1);
                            cbGT.Text = reader["GioiTinh"].ToString();
                            cbTinh.Text = reader["TenTinh"].ToString();
                            cbNganh.Text = reader["TenNganh"].ToString();
                            cbDT.Text = reader["TenLoaiDT"].ToString();
                            cbHuyen.Text = reader["TenHuyen"].ToString();
                            cbKhoa.Text = reader["TenKhoa"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu.");
                        }
                    }
                }
                connection.Close();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            DN obj = new DN();
            obj.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DKHP obj = new DKHP();
            obj.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HocPhi obj = new HocPhi();
            obj.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'qLDKMHVTHPDataSet2.TINH' table. You can move, or remove it, as needed.
            //this.tINHTableAdapter.Fill(this.qLDKMHVTHPDataSet2.TINH);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(str))
            {
                string query = @"
            UPDATE SINHVIEN
            SET HoTen = @HoTen,
                NgaySinh = @NgaySinh,
                GioiTinh = @GioiTinh,
                MaHuyen = (SELECT H.MaHuyen FROM HUYEN H WHERE H.TenHuyen = @TenHuyen),
                MaDT = (SELECT D.MaDT FROM DTUT D WHERE D.TenLoaiDT = @TenLoaiDT),
                MaNganh = (SELECT N.MaNganh FROM NGANH N WHERE N.TenNganh = @TenNganh)
            WHERE MSSV = @MSSV ;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MSSV", txtMSSV.Text);
                    command.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    command.Parameters.AddWithValue("@NgaySinh", date.Value);
                    command.Parameters.AddWithValue("@GioiTinh", cbGT.Text);
                    command.Parameters.AddWithValue("@TenHuyen", cbHuyen.Text);
                    command.Parameters.AddWithValue("@TenLoaiDT", cbDT.Text);
                    command.Parameters.AddWithValue("@TenNganh", cbNganh.Text);

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu được cập nhật.");
                    }

                    connection.Close();
                }
            }
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNganh.Items.Clear();
            con.Open();
            Lenh = @"Select KHOA.TenKhoa, NGANH.TenNganh 
            From KHOA INNER JOIN NGANH ON KHOA.MaKhoa = NGANH.MaKhoa 
            WHERE (KHOA.TenKhoa = N'" + cbKhoa.Text + @"')";
            cmd = new SqlCommand(Lenh, con);
            dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                cbNganh.Items.Add(dr["TenNganh"].ToString());
                i++;
            }
            con.Close();
        }

        private void cbTinh_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbHuyen.Items.Clear();
            con.Open();
            Lenh = @"Select TINH.TenTinh, HUYEN.TenHuyen 
            From TINH INNER JOIN HUYEN ON TINH.MaTinh = HUYEN.MaTinh 
            WHERE (TINH.TenTinh = N'" + cbTinh.Text + @"')";
            cmd = new SqlCommand(Lenh, con);
            dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                cbHuyen.Items.Add(dr["TenHuyen"].ToString());
                i++;
            }
            con.Close();
        }
    }
    }

