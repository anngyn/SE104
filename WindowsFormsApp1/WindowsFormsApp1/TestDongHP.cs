using Microsoft.Office.Interop.Excel;
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
    public partial class TestDongHP : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-MROI1QP;Initial Catalog=QLDKMHVTHP;Integrated Security=True";
        SqlDataAdapter adt = new SqlDataAdapter();
        System.Data.DataTable dt = new System.Data.DataTable();
        SqlDataReader dr;
        public TestDongHP()
        {
            InitializeComponent();
            DT();
            loadhuyen();
            
        }
        void loadhuyen()
        {
            string connectionString = "Data Source=DESKTOP-MROI1QP;Initial Catalog=QLDKMHVTHP;Integrated Security=True";
            string lenh = "SELECT MaLoaiMon FROM LOAIMON";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(lenh, con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cbMaLoaiMon.Items.Add(dr[0].ToString());
                        }
                    }
                }
            }
        }
        void DT()
        {
            string connectionString = "Data Source=DESKTOP-MROI1QP;Initial Catalog=QLDKMHVTHP;Integrated Security=True";
            string lenh = "SELECT MaDT FROM DTUT";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(lenh, con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cbDT.Items.Add(dr[0].ToString());
                        }
                    }
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TestDongHP_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Chuỗi kết nối tới cơ sở dữ liệu của bạn
            string connectionString = "your_connection_string_here";

            // Lấy giá trị từ combobox và textbox
            string maLoaiMon = cbMaLoaiMon.SelectedItem.ToString();
            string soTienTinChi = txtSoTienTinChi.Text;
            string soTietTinChi = txtSoTietTinChi.Text;

            // Kiểm tra nếu các giá trị không rỗng
            if (!string.IsNullOrEmpty(maLoaiMon) && !string.IsNullOrEmpty(soTienTinChi) && !string.IsNullOrEmpty(soTietTinChi))
            {
                // Chuỗi SQL cập nhật
                string query = "UPDATE LOAIMON SET SoTienTinChi = @SoTienTinChi, SoTietTinChi = @SoTietTinChi WHERE MaLoaiMon = @MaLoaiMon";

                // Sử dụng đối tượng SqlConnection để kết nối tới cơ sở dữ liệu
                using (SqlConnection con = new SqlConnection(str))
                {
                    // Sử dụng đối tượng SqlCommand để thực hiện câu lệnh SQL
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Thêm các tham số vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@MaLoaiMon", maLoaiMon);
                        cmd.Parameters.AddWithValue("@SoTienTinChi", soTienTinChi);
                        cmd.Parameters.AddWithValue("@SoTietTinChi", soTietTinChi);

                        // Mở kết nối
                        con.Open();

                        // Thực thi câu lệnh SQL
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Đóng kết nối
                        con.Close();

                        // Kiểm tra xem có hàng nào bị ảnh hưởng không
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy MaLoaiMon để cập nhật.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Chuỗi kết nối tới cơ sở dữ liệu của bạn

            // Lấy giá trị từ combobox và textbox
            string maDT = cbDT.SelectedItem.ToString();
            string tiLeMienHPStr = txtHP.Text; // Sử dụng Text thay vì ToString để lấy giá trị nhập từ người dùng

            // Kiểm tra nếu các giá trị không rỗng
            if (!string.IsNullOrEmpty(maDT) && !string.IsNullOrEmpty(tiLeMienHPStr))
            {
                // Chuyển đổi chuỗi thành số decimal
                decimal tiLeMienHP;
                if (Decimal.TryParse(tiLeMienHPStr, out tiLeMienHP))
                {
                    // Chuỗi SQL cập nhật
                    string query = "UPDATE DTUT SET TiLeMienHP = @TiLeMienHP WHERE MaDT = @MaDT";

                    // Sử dụng đối tượng SqlConnection để kết nối tới cơ sở dữ liệu
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        // Sử dụng đối tượng SqlCommand để thực hiện câu lệnh SQL
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // Thêm các tham số vào câu lệnh SQL
                            cmd.Parameters.AddWithValue("@MaDT", maDT);
                            cmd.Parameters.AddWithValue("@TiLeMienHP", tiLeMienHP); // Sử dụng giá trị decimal

                            // Mở kết nối
                            con.Open();

                            // Thực thi câu lệnh SQL
                            int rowsAffected = cmd.ExecuteNonQuery();

                            // Đóng kết nối
                            con.Close();

                            // Kiểm tra xem có hàng nào bị ảnh hưởng không
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy MaDT để cập nhật.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Giá trị nhập cho Tỉ lệ Miền HP không hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu trường txtNam và txtHK không trống và có thể chuyển đổi thành số nguyên
            if (!int.TryParse(txtNam.Text, out int namHoc) || !int.TryParse(txtHK.Text, out int hocKy))
            {
                MessageBox.Show("Vui lòng nhập giá trị hợp lệ cho năm học và học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(str))
            {
                try
                {
                    con.Open();

                    // Tạo câu lệnh SQL INSERT
                    string Lenh = @"
                INSERT INTO HOCKY_NAMHOC (HocKy, NamHoc, ThoiHanDongHocPhi) 
                VALUES (@HocKy, @NamHoc, NULL)";

                    using (SqlCommand cmd = new SqlCommand(Lenh, con))
                    {
                        // Thêm các tham số vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@HocKy", hocKy);
                        cmd.Parameters.AddWithValue("@NamHoc", namHoc);

                        // Thực thi câu lệnh SQL
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu trường txtNam và txtHK không trống và có thể chuyển đổi thành số nguyên
            if (!int.TryParse(txtNam.Text, out int namHoc) || !int.TryParse(txtHK.Text, out int hocKy))
            {
                MessageBox.Show("Vui lòng nhập giá trị hợp lệ cho năm học và học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(str))
            {
                try
                {
                    con.Open();

                    // Tạo câu lệnh SQL DELETE
                    string Lenh = @"
                DELETE FROM HOCKY_NAMHOC
                WHERE HocKy = @HocKy AND NamHoc = @NamHoc";

                    using (SqlCommand cmd = new SqlCommand(Lenh, con))
                    {
                        // Thêm các tham số vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@HocKy", hocKy);
                        cmd.Parameters.AddWithValue("@NamHoc", namHoc);

                        // Thực thi câu lệnh SQL
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
