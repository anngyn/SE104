using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static WindowsFormsApp1.DN;

namespace WindowsFormsApp1
{
    public partial class HocPhi : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-MROI1QP;Initial Catalog=QLDKMHVTHP;Integrated Security=True";
        SqlDataAdapter adt = new SqlDataAdapter();
        System.Data.DataTable dt = new System.Data.DataTable();
        string Lenh;
        SqlDataReader dr;

        //        SqlDataReader dr;
        string taiKhoan = GlobalVariables.TaiKhoan;
        
        
        public HocPhi()
        {
            InitializeComponent();
            // Khởi tạo form DKHP để truy cập phương thức GetDataTableFromDTDKHP
            // Gọi phương thức để lấy DataTable từ DataGridView dtDKHP của form DKHP
            con = new SqlConnection(str);
            LoadData();
            loaddata();
            

            // Gán DataTable nhận được cho DataSource của DataGridView dtHP  
        }
        
        private void LoadData()
        {
            txtHK.Text = GlobalVariables.HK;
            txtNH.Text = GlobalVariables.NH;
            string namHoc = txtNH.Text;
            string hocKy = txtHK.Text;
            string taiKhoan = GlobalVariables.TaiKhoan;

            using (SqlConnection connection = new SqlConnection(str))
            {
                try
                {
                    connection.Open();

                    // Chuỗi truy vấn SQL
                    string query = @"SELECT SINHVIEN.HoTen, PHIEUDKHP.TongTienDangKi, PHIEUDKHP.SoTienPhaiDong
                             FROM SINHVIEN
                             INNER JOIN PHIEUDKHP ON SINHVIEN.MSSV = PHIEUDKHP.MSSV
                             WHERE PHIEUDKHP.NamHoc = @NamHoc AND PHIEUDKHP.HocKy = @HocKy AND SINHVIEN.MSSV = @taiKhoan";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@taiKhoan", taiKhoan);
                        cmd.Parameters.AddWithValue("@NamHoc", namHoc);
                        cmd.Parameters.AddWithValue("@HocKy", hocKy);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtMSSV.Text = taiKhoan;
                                txtHovaTen.Text = reader["HoTen"].ToString();
                                txtHK.Text = hocKy;
                                txtNH.Text = namHoc;
                                txtTongDK.Text = reader["TongTienDangKi"].ToString();
                                txtTongDong.Text = reader["SoTienPhaiDong"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Không có dữ liệu cho năm học và học kỳ này.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DN obj = new DN();
            obj.Show();
            this.Close();
        }

        //private void txtTongDK_TextChanged(object sender, EventArgs e)
        //{
        //    using (SqlConnection con = new SqlConnection(str))
        //    {
        //        con.Open();
        //        using (SqlTransaction transaction = con.BeginTransaction())
        //        {
        //            try
        //            {
        //                using (SqlCommand cmd = con.CreateCommand())
        //                {
        //                    cmd.Transaction = transaction;

        //                    // Chèn vào bảng HOCKY_NAMHOC nếu chưa tồn tại
        //                    cmd.CommandText = "UPDATE PHIEUDKHP set TongTienDangKi = SUM(DSMH.SoTinChi * LOAIMON.SoTienTinChi) " +
        //                                       "FROM     PHIEUDKHP INNER JOIN " +
        //                                      "CT_DKHP ON PHIEUDKHP.MaSoPhieu = CT_DKHP.MaSoPhieu INNER JOIN " +
        //                                      "DSMH_MO_TRONG_HOC_KI ON CT_DKHP.MaMo = DSMH_MO_TRONG_HOC_KI.MaMo INNER JOIN " +
        //                                      "DSMH ON DSMH_MO_TRONG_HOC_KI.MaMonHoc = DSMH.MaMonHoc INNER JOIN " +
        //                                      "LOAIMON ON DSMH.MaLoaiMon = LOAIMON.MaLoaiMon " +
        //                                      "GROUP BY PHIEUDKHP.MSSV " +
        //                                      "HAVING (PHIEUDKHP.MSSV = '---')";

        //                    cmd.ExecuteNonQuery();

        //                }

        //                transaction.Commit();
        //            }
        //            catch (Exception ex)
        //            {
        //                transaction.Rollback();
        //            }
        //        }
        //    }
        //}

        private void HocPhi_Load(object sender, EventArgs e)
        {

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            // Lấy MSSV từ TextBox
            string mssv = txtMSSV.Text;

            // Lấy năm học và học kỳ từ combobox cbNam và cbHK
            string namHoc = txtNH.Text;
            string hocKy = txtHK.Text;

            // Lấy số tiền đóng từ TextBox
            decimal soTienDong = 0;
            if (!decimal.TryParse(txtSoTienThu.Text, out soTienDong) || soTienDong < 0)
            {
                MessageBox.Show("Số tiền đóng không hợp lệ.");
                return;
            }

            // Biến để lưu MaHKNH nếu tồn tại
            string maSoPhieu = null;
            decimal soTienDaDong = 0;
            decimal soTienPhaiDong = 0;
            decimal soTienConLai = 0;
            DateTime thoiHanDongHocPhi;
            DateTime selectedDate = dateHP.Value;
            using (SqlConnection connection = new SqlConnection(str))
            {
                // Kiểm tra MaHKNH dựa trên năm học và học kỳ
                string queryCheckMaHKNH = @"
                SELECT ThoiHanDongHocPhi 
                FROM HOCKY_NAMHOC
                WHERE NamHoc = @NamHoc AND HocKy = @HocKy";


                using (SqlCommand cmd = new SqlCommand(queryCheckMaHKNH, connection))
                {
                    cmd.Parameters.AddWithValue("@NamHoc", namHoc);
                    cmd.Parameters.AddWithValue("@HocKy", hocKy);

                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            thoiHanDongHocPhi = reader.GetDateTime(reader.GetOrdinal("ThoiHanDongHocPhi"));
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin về học kỳ và năm học.");
                            return;
                        }
                    }
                    connection.Close();
                }

                if (thoiHanDongHocPhi < selectedDate)
                {
                    MessageBox.Show($"Đã quá hạn đóng học phí \n Bạn không thể tham gia thi Cuối Kỳ \n Vui lòng liên hệ phòng đào tạo ");
                    return;
                }

                // Lấy thông tin về phiếu đăng ký học phí của sinh viên
                string queryPhieuDKHP = @"
           SELECT MaSoPhieu, SoTienDaDong, SoTienPhaiDong, SoTienConLai
           FROM PHIEUDKHP
           WHERE MSSV = @MSSV AND NamHoc = @NamHoc AND HocKy = @HocKy";

                using (SqlCommand cmd = new SqlCommand(queryPhieuDKHP, connection))
                {
                    cmd.Parameters.AddWithValue("@MSSV", mssv);
                    cmd.Parameters.AddWithValue("@HocKy", hocKy);
                    cmd.Parameters.AddWithValue("@NamHoc", namHoc);

                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maSoPhieu = reader["MaSoPhieu"].ToString();
                            soTienDaDong = reader.GetDecimal(reader.GetOrdinal("SoTienDaDong"));
                            soTienPhaiDong = reader.GetDecimal(reader.GetOrdinal("SoTienPhaiDong"));
                            soTienConLai = reader.GetDecimal(reader.GetOrdinal("SoTienConLai"));
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin phiếu đăng ký học phí.");
                            return;
                        }
                    }
                    connection.Close();
                }
            }

            // Kiểm tra số tiền đóng không vượt quá số tiền còn lại
            if (soTienDong > soTienConLai)
            {
                MessageBox.Show("Số tiền đóng vượt quá số tiền còn lại phải đóng.");
                return;
            }

            // Cập nhật số tiền đã đóng và số tiền còn lại
            soTienDaDong += soTienDong;
            soTienConLai -= soTienDong;

            using (SqlConnection connection = new SqlConnection(str))
            {
                // Cập nhật phiếu đăng ký học phí
                string updatePhieuDKHP = @"
           UPDATE PHIEUDKHP
           SET SoTienDaDong = @SoTienDaDong, SoTienConLai = @SoTienConLai
           WHERE MSSV = @MSSV AND NamHoc = @NamHoc AND HocKy = @HocKy";

                using (SqlCommand cmd = new SqlCommand(updatePhieuDKHP, connection))
                {
                    cmd.Parameters.AddWithValue("@SoTienDaDong", soTienDaDong);
                    cmd.Parameters.AddWithValue("@SoTienConLai", soTienConLai);
                    cmd.Parameters.AddWithValue("@MSSV", mssv);
                    cmd.Parameters.AddWithValue("@HocKy", hocKy);
                    cmd.Parameters.AddWithValue("@NamHoc", namHoc);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

                // Tạo mã phiếu thu mới
                string maPhieuThu;
                string queryLatestMaPhieuThu = @"
           SELECT TOP 1 MaPhieuThu
           FROM PHIEUTHUHP
           ORDER BY MaPhieuThu DESC";

                using (SqlCommand cmd = new SqlCommand(queryLatestMaPhieuThu, connection))
                {
                    connection.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string latestMaPhieuThu = result.ToString();
                        int nextMaPhieuThuNumber;
                        if (!int.TryParse(latestMaPhieuThu.Substring(1), out nextMaPhieuThuNumber))
                        {
                            nextMaPhieuThuNumber = 1;
                        }
                        else
                        {
                            nextMaPhieuThuNumber++;
                        }
                        maPhieuThu = "T" + nextMaPhieuThuNumber.ToString("000");
                    }
                    else
                    {
                        maPhieuThu = "T001";
                    }
                    connection.Close();
                }

                // Lưu thông tin vào bảng PHIEUTHUHP
                string insertPhieuThuHP = @"
           INSERT INTO PHIEUTHUHP (MaPhieuThu, MaSoPhieu, NgayLap, SoTienThu)
VALUES (@MaPhieuThu, @MaSoPhieu, @NgayLap, @SoTienThu)";
                

                using (SqlCommand cmd = new SqlCommand(insertPhieuThuHP, connection))
                {
                    cmd.Parameters.AddWithValue("@MaPhieuThu", maPhieuThu);
                    cmd.Parameters.AddWithValue("@MaSoPhieu", maSoPhieu);
                    cmd.Parameters.AddWithValue("@NgayLap", selectedDate);
                    cmd.Parameters.AddWithValue("@SoTienThu", soTienDong);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            // Hiển thị thông báo cập nhật thành công và số tiền còn lại
            MessageBox.Show($"Cập nhật số tiền đóng học phí thành công.\nSố tiền còn lại: {soTienConLai.ToString("C0", new CultureInfo("vi-VN"))}", "Thông báo");

            // Cập nhật lại các TextBox
            txtDaDong.Text = soTienDaDong.ToString("C0", new CultureInfo("vi-VN"));
            txtConLai.Text = soTienConLai.ToString("C0", new CultureInfo("vi-VN"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DKHP obj = new DKHP();
            obj.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien obj = new SinhVien();
            obj.Show();
            this.Close();
        }
        // Tạo một đối tượng DKHP để truy cập phương thức GetDtDKHPData()
        private static DKHP dkhpForm;

        private void dtHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void loaddata()
        {
            try
            {
                // Kiểm tra và mở kết nối nếu cần
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Khởi tạo SqlCommand với câu truy vấn và kết nối
                using (SqlCommand cmd = con.CreateCommand())
                {
                    // Lấy giá trị từ các TextBox
                    string hocKy = txtHK.Text;
                    string namHoc = txtNH.Text;

                    // Chuẩn bị câu lệnh SQL với tham số
                    string query = @"SELECT CT_DKHP.MaMo, DSMH.MaMonHoc, DSMH.TenMonHoc, DSMH.SoTinChi
                            FROM PHIEUDKHP 
                            INNER JOIN CT_DKHP ON PHIEUDKHP.MaSoPhieu = CT_DKHP.MaSoPhieu 
                            INNER JOIN DSMH_MO_TRONG_HOC_KI ON CT_DKHP.MaMo = DSMH_MO_TRONG_HOC_KI.MaMo 
                            INNER JOIN DSMH ON DSMH_MO_TRONG_HOC_KI.MaMonHoc = DSMH.MaMonHoc
                            WHERE PHIEUDKHP.HocKy = @HocKy AND PHIEUDKHP.NamHoc = @NamHoc";

                    // Gán câu truy vấn cho SqlCommand
                    cmd.CommandText = query;

                    // Thêm tham số cho câu truy vấn
                    cmd.Parameters.AddWithValue("@HocKy", hocKy);
                    cmd.Parameters.AddWithValue("@NamHoc", namHoc);
                    
                    // Khởi tạo SqlDataAdapter với SqlCommand đã cấu hình
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        // Xóa dữ liệu hiện có trong DataTable
                        dt.Clear();
                        
                        // Đổ dữ liệu vào DataTable
                        adt.Fill(dt);
                        
                        // Gán DataTable cho DataSource của DataGridView
                        dtHP.DataSource = dt;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Đảm bảo rằng kết nối được đóng lại nếu đã mở
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }



        // Lấy dữ liệu từ dtDKHP trong DKHP



        // Bây giờ bạn có thể sử dụng dữ liệu trong dtDKHPData như một DataTable bình thường

    }
}
       
