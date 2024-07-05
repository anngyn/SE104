using System;
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
using static WindowsFormsApp1.DN;

namespace WindowsFormsApp1
{
    public partial class DKHP : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-MROI1QP;Initial Catalog=QLDKMHVTHP;Integrated Security=True";
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string Lenh;
        SqlDataReader dr;
        public static DataTable dtDKHPdata;
        private Dictionary<string, bool> checkboxStates = new Dictionary<string, bool>();

        public DKHP()
        {
            InitializeComponent();
            con = new SqlConnection(str);
            LoadData();
            loadHK();
            loadNam();
            AddHeaderCheckbox();
        }

        void loadHK()
        {
            Lenh = "Select distinct HocKy From HOCKY_NAMHOC";
            con.Open();
            cmd = new SqlCommand(Lenh, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbHK.Items.Add(dr[0].ToString());
            }
            con.Close();
        }

        void loadNam()
        {
            Lenh = "Select distinct NamHoc From HOCKY_NAMHOC";
            con.Open();
            cmd = new SqlCommand(Lenh, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbNam.Items.Add(dr[0].ToString());
            }
            con.Close();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                // Mở kết nối
                connection.Open();

                // Chuỗi truy vấn SQL
                string query = "SELECT HoTen FROM SINHVIEN WHERE SINHVIEN.MSSV = @taiKhoan"; // Đảm bảo tên tham số là @taiKhoan

                // Khởi tạo SqlCommand để thực thi truy vấn
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@taiKhoan", GlobalVariables.TaiKhoan); // Sử dụng giá trị từ GlobalVariables.TaiKhoan

                    // Thực thi truy vấn và lấy dữ liệu
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Kiểm tra xem có dòng dữ liệu nào được trả về không
                        if (reader.Read())
                        {
                            // Đọc dữ liệu từ SqlDataReader và gán vào các TextBox
                            txtMSSV.Text = GlobalVariables.TaiKhoan;
                            txtHovaTen.Text = reader["HoTen"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu.");
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DN obj = new DN();
            obj.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien obj = new SinhVien();
            obj.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HocPhi obj = new HocPhi();
            obj.Show();
            this.Close();
        }

        private void AddHeaderCheckbox()
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Select All";
            checkBoxColumn.Name = "checkBoxColumn";
            checkBoxColumn.Width = 50;
            dtDKHP.Columns.Insert(0, checkBoxColumn);
            dtDKHP.CellContentClick += new DataGridViewCellEventHandler(dtDKHP_CellContentClick);
            UpdateHeaderCheckbox(false);
        }

        private void dtDKHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtDKHP.Columns["checkBoxColumn"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBox = dtDKHP.Rows[e.RowIndex].Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;
                string maMonHoc = dtDKHP.Rows[e.RowIndex].Cells["MaMonHoc"].Value.ToString();
                checkboxStates[maMonHoc] = Convert.ToBoolean(checkBox.Value);
            }
        }

        private void SaveCheckboxStates()
        {
            // Kiểm tra xem DataGridView có dữ liệu hay không và cột "MaMonHoc" có tồn tại hay không
            if (dtDKHP.DataSource != null && dtDKHP.Columns.Contains("MaMonHoc"))
            {
                foreach (DataGridViewRow row in dtDKHP.Rows)
                {
                    if (row.Cells["MaMonHoc"].Value != null)
                    {
                        string maMonHoc = row.Cells["MaMonHoc"].Value.ToString();
                        bool isChecked = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                        checkboxStates[maMonHoc] = isChecked;
                    }
                }
            }
        }

        private void RestoreCheckboxStates()
        {
            foreach (DataGridViewRow row in dtDKHP.Rows)
            {
                if (row.Cells["MaMonHoc"].Value != null)
                {
                    string maMonHoc = row.Cells["MaMonHoc"].Value.ToString();
                    if (checkboxStates.ContainsKey(maMonHoc))
                    {
                        row.Cells["checkBoxColumn"].Value = checkboxStates[maMonHoc];
                    }
                    else
                    {
                        row.Cells["checkBoxColumn"].Value = false;
                    }
                }
            }
        }
        private void UpdateHeaderCheckbox(bool isChecked)
        {
            dtDKHP.Columns["checkBoxColumn"].HeaderText = isChecked ? "Unselect All" : "Select All";
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            SaveCheckboxStates();

            string searchText = txtTim.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                button5_Click(sender, e);
            }
            else
            {
                string query = @"
        SELECT DSMH_MO_TRONG_HOC_KI.MaMonHoc, DSMH.TenMonHoc, DSMH.MaLoaiMon, DSMH.SoTinChi, DSMH.SoTiet, DSMH.MaNganh
        FROM DSMH
        INNER JOIN DSMH_MO_TRONG_HOC_KI ON DSMH.MaMonHoc = DSMH_MO_TRONG_HOC_KI.MaMonHoc
        WHERE (DSMH_MO_TRONG_HOC_KI.HocKy = @HocKy) AND (DSMH_MO_TRONG_HOC_KI.NamHoc = @NamHoc)
        AND (DSMH_MO_TRONG_HOC_KI.MaMonHoc LIKE @SearchText OR DSMH.TenMonHoc LIKE @SearchText)";

                DataTable dt = TableWithParameter(query, searchText);
                dtDKHP.DataSource = dt;

                RestoreCheckboxStates();
            }
        }

        private DataTable TableWithParameter(string query, string searchText)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@HocKy", cbHK.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@NamHoc", cbNam.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            SaveCheckboxStates();

            con = new SqlConnection(str);
            Lenh = @"
        SELECT DSMH_MO_TRONG_HOC_KI.MaMonHoc, DSMH.TenMonHoc, DSMH.MaLoaiMon, DSMH.SoTinChi, DSMH.SoTiet, DSMH_MO_TRONG_HOC_KI.MaNganh 
        FROM DSMH 
        INNER JOIN DSMH_MO_TRONG_HOC_KI ON DSMH.MaMonHoc = DSMH_MO_TRONG_HOC_KI.MaMonHoc 
        WHERE (DSMH_MO_TRONG_HOC_KI.HocKy = @HocKy) AND (DSMH_MO_TRONG_HOC_KI.NamHoc = @NamHoc)";

            try
            {
                con.Open();
                cmd = new SqlCommand(Lenh, con);
                cmd.Parameters.AddWithValue("@HocKy", cbHK.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@NamHoc", cbNam.SelectedItem.ToString());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dtDKHP.DataSource = dt;
                if (dtDKHP.Columns.Contains("MaMonHoc"))
                {
                    dtDKHP.Columns["MaMonHoc"].HeaderText = "Mã Môn Học";
                }
                if (dtDKHP.Columns.Contains("TenMonHoc"))
                {
                    dtDKHP.Columns["TenMonHoc"].HeaderText = "Tên Môn Học";
                }
                if (dtDKHP.Columns.Contains("SoTinChi"))
                {
                    dtDKHP.Columns["SoTinChi"].HeaderText = "Số Tín Chỉ";
                }
                if (dtDKHP.Columns.Contains("MaLoaiMon"))
                {
                    dtDKHP.Columns["MaLoaiMon"].HeaderText = "Mã Loại Môn";
                }
                if (dtDKHP.Columns.Contains("SoTiet"))
                {
                    dtDKHP.Columns["SoTiet"].HeaderText = "Số Tiết";
                }
                if (dtDKHP.Columns.Contains("MaNganh"))
                {
                    dtDKHP.Columns["MaNganh"].HeaderText = "Mã Ngành";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            dtDKHPdata = dtDKHP.DataSource as DataTable;
            GlobalVariables.HK = cbHK.Text;
            GlobalVariables.NH = cbNam.Text;

            RestoreCheckboxStates();
        }


        public static List<string> registeredCourses = new List<string>();
        private void btnXN_Click(object sender, EventArgs e)
        {
            registeredCourses.Clear();
            decimal totalAmount = 0;
            decimal discountRate = 1;
            decimal tuitionRate = 1;// Mặc định không có miễn học phí (tỷ lệ 100%)
            decimal tiendong = 0;

            // Lấy MSSV từ TextBox
            string mssv = txtMSSV.Text;

            // Truy vấn để lấy tỷ lệ miễn học phí từ bảng DTUT
            using (SqlConnection connection = new SqlConnection(str))
            {
                string queryDiscount = @"
            SELECT DTUT.TiLeMienHP 
            FROM DTUT JOIN SINHVIEN ON DTUT.MaDT = SINHVIEN.MaDT
            WHERE SINHVIEN.MSSV = @MSSV";

                using (SqlCommand cmd = new SqlCommand(queryDiscount, connection))
                {
                    cmd.Parameters.AddWithValue("@MSSV", mssv);

                    connection.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        discountRate = Convert.ToDecimal(result);
                        tuitionRate = 1 - discountRate;
                    }
                    connection.Close();
                }
            }

            for (int i = 0; i < dtDKHP.RowCount - 1; i++)
            {
                // Kiểm tra xem checkbox có được chọn không
                if (Convert.ToBoolean(dtDKHP.Rows[i].Cells["checkBoxColumn"].Value) == true)
                {
                    // Lấy giá trị mã môn học từ cột "MaMonHoc"
                    string maMonHoc = dtDKHP.Rows[i].Cells["MaMonHoc"].Value.ToString();
                    // Lấy giá trị tên môn học từ cột "TenMonHoc"
                    string tenMonHoc = dtDKHP.Rows[i].Cells["TenMonHoc"].Value.ToString();

                    // Thêm tên môn học vào danh sách đăng ký thành công
                    registeredCourses.Add(tenMonHoc);

                    // Truy vấn để lấy thông tin SoTinChi và SoTienTinChi
                    using (SqlConnection connection = new SqlConnection(str))
                    {
                        string query = @"
                    SELECT DSMH.SoTinChi, LOAIMON.SoTienTinChi 
                    FROM DSMH
                    JOIN LOAIMON ON DSMH.MaLoaiMon = LOAIMON.MaLoaiMon
                    WHERE DSMH.MaMonHoc = @MaMonHoc";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);

                            connection.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int soTinChi = reader.GetInt32(0);
                                    decimal soTienTinChi = reader.GetDecimal(1);
                                    totalAmount += soTinChi * soTienTinChi;
                                }
                            }
                            connection.Close();
                        }
                    }
                }
            }

            if (registeredCourses.Count > 0)
            {
                // Hiển thị danh sách các môn học đăng ký thành công
                StringBuilder message = new StringBuilder();
                message.AppendLine("Các môn học đã đăng ký thành công:");
                foreach (string course in registeredCourses)
                {
                    message.AppendLine(course);
                }
                MessageBox.Show(message.ToString(), "Thông báo");

                // Tính toán số tiền phải đóng sau khi áp dụng tỷ lệ miễn học phí
                decimal amountToPay = totalAmount * tuitionRate;

                // Sử dụng CultureInfo để định dạng thành tiền tệ Việt Nam
                CultureInfo vietnamCulture = new CultureInfo("vi-VN");

                // Hiển thị tổng tiền đăng ký vào TextBox
                txtTongDK.Text = totalAmount.ToString("C0", vietnamCulture); // "C0" định dạng thành tiền tệ và không có chữ số thập phân

                // Hiển thị số tiền phải đóng vào TextBox
                txtTongDong.Text = amountToPay.ToString("C0", vietnamCulture); // "C0" định dạng thành tiền tệ và không có chữ số thập phân

                // Lấy MaSoPhieu gần nhất từ cơ sở dữ liệu
                string latestMaSoPhieu;
                using (SqlConnection connection = new SqlConnection(str))
                {
                    string queryLatestMaSoPhieu = @"
                SELECT TOP 1 MaSoPhieu
                FROM PHIEUDKHP
                ORDER BY MaSoPhieu DESC";

                    using (SqlCommand cmd = new SqlCommand(queryLatestMaSoPhieu, connection))
                    {
                        connection.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            latestMaSoPhieu = result.ToString();
                        }
                        else
                        {
                            // Nếu không có bản ghi nào trong bảng PHIEUDKHP, gán mã bắt đầu là P001
                            latestMaSoPhieu = "P001";
                        }
                        connection.Close();
                    }
                }

                // Tăng MaSoPhieu lên 1 đơn vị
                int nextMaSoPhieuNumber;
                if (!int.TryParse(latestMaSoPhieu.Substring(1), out nextMaSoPhieuNumber))
                {
                    // If parsing fails, start from 1
                    nextMaSoPhieuNumber = 1;
                }
                else
                {
                    nextMaSoPhieuNumber++;
                }
                string nextMaSoPhieu = "P" + nextMaSoPhieuNumber.ToString("000");

                // Lấy ngày hiện tại
                DateTime ngayLap = DateTime.Today;

                // Lấy năm học và học kỳ từ combobox cbNam và cbHK
                string namHoc = cbNam.SelectedItem.ToString();
                string hocKy = cbHK.SelectedItem.ToString();

                using (SqlConnection connection = new SqlConnection(str))
                {
                    string Dadong = @"
                    SELECT SoTienDaDong 
                    FROM PHIEUDKHP 
                    WHERE HocKy = @HocKy AND NamHoc = @NamHoc AND MSSV = @MSSV";

                    using (SqlCommand cmd = new SqlCommand(Dadong, connection))
                    {
                        cmd.Parameters.AddWithValue("@HocKy", hocKy);
                        cmd.Parameters.AddWithValue("@NamHoc", namHoc);
                        cmd.Parameters.AddWithValue("@MSSV", mssv);

                        connection.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            tiendong = Convert.ToDecimal(result);
                        }
                        connection.Close();
                    }
                }
            

            // Tính toán số tiền còn lại
            decimal soTienConLai = amountToPay - tiendong;
                // Xóa các bản ghi cũ trong PHIEUDKHP và CT_DKHP
                using (SqlConnection connection = new SqlConnection(str))
                {
                    string deletePHIEUDKHP = @"
                DELETE FROM CT_DKHP WHERE MaSoPhieu IN (SELECT MaSoPhieu FROM PHIEUDKHP WHERE HocKy = @HocKy AND NamHoc = @NamHoc AND MSSV = @MSSV);
                DELETE FROM PHIEUDKHP WHERE HocKy = @HocKy AND NamHoc = @NamHoc AND MSSV = @MSSV;";

                    using (SqlCommand cmd = new SqlCommand(deletePHIEUDKHP, connection))
                    {
                        cmd.Parameters.AddWithValue("@HocKy", hocKy);
                        cmd.Parameters.AddWithValue("@NamHoc", namHoc);
                        cmd.Parameters.AddWithValue("@MSSV", mssv);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                // Cập nhật hoặc chèn bản ghi vào bảng PHIEUDKHP
                using (SqlConnection connection = new SqlConnection(str))
                {
                    string upsertQuery = @"
                IF EXISTS (SELECT 1 FROM PHIEUDKHP WHERE HocKy = @HocKy AND NamHoc = @NamHoc AND MSSV = @MSSV)
                BEGIN
                    UPDATE PHIEUDKHP
                    SET NgayLap = @NgayLap,
                        TongTienDangKi = @TongTienDangKi,
                        SoTienPhaiDong = @SoTienPhaiDong,
                        SoTienDaDong = @Sotiendadong,
                        SoTienConLai = @SoTienConLai
                    WHERE HocKy = @HocKy AND NamHoc = @NamHoc AND MSSV = @MSSV
                END
                ELSE
                BEGIN
                    INSERT INTO PHIEUDKHP (MaSoPhieu, MSSV, NgayLap, HocKy, NamHoc, TongTienDangKi, SoTienPhaiDong, SoTienDaDong, SoTienConLai)
                    VALUES (@MaSoPhieu, @MSSV, @NgayLap,  @HocKy, @NamHoc, @TongTienDangKi, @SoTienPhaiDong, 0, @SoTienConLai)
                END";

                    using (SqlCommand cmd = new SqlCommand(upsertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaSoPhieu", nextMaSoPhieu);
                        cmd.Parameters.AddWithValue("@MSSV", mssv);
                        cmd.Parameters.AddWithValue("@NgayLap", ngayLap);
                        cmd.Parameters.AddWithValue("@HocKy", hocKy);
                        cmd.Parameters.AddWithValue("@NamHoc", namHoc);
                        cmd.Parameters.AddWithValue("@TongTienDangKi", totalAmount);
                        cmd.Parameters.AddWithValue("@SoTienPhaiDong", amountToPay);
                        cmd.Parameters.AddWithValue("@SoTienConLai", soTienConLai);
                        cmd.Parameters.AddWithValue("@SoTienDaDong", tiendong);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }

                    // Cập nhật bảng CT_DKHP với MaSoPhieu và MaMo
                    for (int i = 0; i < dtDKHP.RowCount - 1; i++)
                    {
                        if (Convert.ToBoolean(dtDKHP.Rows[i].Cells["checkBoxColumn"].Value) == true)
                        {
                            string maMonHoc = dtDKHP.Rows[i].Cells["MaMonHoc"].Value.ToString();

                            // Truy vấn để lấy MaMo từ bảng DSMH_MO_TRONG_HOC_KI
                            using (SqlConnection connection2 = new SqlConnection(str))
                            {
                                string queryMaMo = @"
                            SELECT MaMo 
                            FROM DSMH_MO_TRONG_HOC_KI 
                            WHERE MaMonHoc = @MaMonHoc AND HocKy = @HocKy AND NamHoc = @NamHoc";

                                using (SqlCommand cmd = new SqlCommand(queryMaMo, connection2))
                                {
                                    cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                                    cmd.Parameters.AddWithValue("@HocKy", hocKy);
                                    cmd.Parameters.AddWithValue("@NamHoc", namHoc);

                                    connection2.Open();
                                    object result = cmd.ExecuteScalar();
                                    if (result != null)
                                    {
                                        string maMo = result.ToString();

                                        // Chèn thông tin vào bảng CT_DKHP
                                        using (SqlConnection connection3 = new SqlConnection(str))
                                        {
                                            string insertCT_DKHP = @"
                                        INSERT INTO CT_DKHP (MaSoPhieu, MaMo)
                                        VALUES (@MaSoPhieu, @MaMo)";

                                            using (SqlCommand cmd2 = new SqlCommand(insertCT_DKHP, connection3))
                                            {
                                                cmd2.Parameters.AddWithValue("@MaSoPhieu", nextMaSoPhieu);
                                                cmd2.Parameters.AddWithValue("@MaMo", maMo);

                                                connection3.Open();
                                                cmd2.ExecuteNonQuery();
                                                connection3.Close();
                                            }
                                        }
                                    }
                                    connection2.Close();
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có môn học nào được đăng ký.");
            }
        }


    }
}



