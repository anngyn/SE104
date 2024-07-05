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
using Microsoft.Office.Interop.Excel;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using app = Microsoft.Office.Interop.Excel.Application;
using Excel = Microsoft.Office.Interop.Excel;
namespace WindowsFormsApp1
{
    public partial class DongHP : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-MROI1QP;Initial Catalog=QLDKMHVTHP;Integrated Security=True";
        SqlDataAdapter adt = new SqlDataAdapter();
        System.Data.DataTable dt = new System.Data.DataTable();
        SqlDataReader dr;
        string Lenh;
        public DongHP()
        {
            InitializeComponent();
            con = new SqlConnection(str);
            loadHK();
            loadNam();
            //  loaddata();

        }
        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select BAOCAOCHUADONGHP.MaBCChuaDongHP,BAOCAOCHUADONGHP.HocKy,BAOCAOCHUADONGHP.NamHoc, BAOCAOCHUADONGHP.MSSV, BAOCAOCHUADONGHP.TongTienDangKi, BAOCAOCHUADONGHP.SoTienPhaiDong,BAOCAOCHUADONGHP.SoTienConLai from BAOCAOCHUADONGHP";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            HPList.DataSource = dt;
            HPList.Columns["MaBCChuaDongHP"].HeaderText = "Mã BC Chưa Đóng Học Phí";
            HPList.Columns["HocKy"].HeaderText = "Học Kỳ";
            HPList.Columns["NamHoc"].HeaderText = "Năm Học";
            HPList.Columns["MSSV"].HeaderText = "MSSV";
            HPList.Columns["TongTienDangKi"].HeaderText = "Tổng Tiền Đăng Kí";
            HPList.Columns["SoTienPhaiDong"].HeaderText = "Số Tiền Phải Đóng";
            HPList.Columns["SoTienConLai"].HeaderText = "Số Tiền Còn Lại";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void ExportToExcel()
        {
            try
            {
                // Tạo đối tượng Excel
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.ActiveSheet;

                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    // Truy vấn để lấy dữ liệu từ bảng BAOCAOCHUADONGHOCPHI
                    string query = "SELECT * FROM BAOCAOCHUADONGHP";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Số dòng và cột ban đầu trong Excel
                    int row = 1;
                    int column = 1;

                    // Thêm tiêu đề cho các cột
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        worksheet.Cells[row, column] = reader.GetName(i);
                        column++;
                    }

                    row++;

                    // Thêm dữ liệu từ cơ sở dữ liệu vào Excel
                    while (reader.Read())
                    {
                        column = 1;
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            worksheet.Cells[row, column] = reader[i].ToString();
                            column++;
                        }
                        row++;
                    }

                    // Đóng kết nối và giải phóng tài nguyên
                    reader.Close();
                    connection.Close();
                }

                // Lưu file Excel
                workbook.SaveAs(@"D:\An\UIT\2grade\HK2\SE104\C#");
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show("Xuất file Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
  

private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDKMHVTHPDataSet2.BAOCAOCHUADONGHP' table. You can move, or remove it, as needed.
           // this.bAOCAOCHUADONGHPTableAdapter.Fill(this.qLDKMHVTHPDataSet2.BAOCAOCHUADONGHP);
            //// TODO: This line of code loads data into the 'qLDKMHVTHPDataSet2.HOCKY_NAMHOC' table. You can move, or remove it, as needed.
            //this.hOCKY_NAMHOCTableAdapter.Fill(this.qLDKMHVTHPDataSet2.HOCKY_NAMHOC);
            //// TODO: This line of code loads data into the 'qLDKMHVTHPDataSet2.HOCKY_NAMHOC' table. You can move, or remove it, as needed.
            //this.hOCKY_NAMHOCTableAdapter.Fill(this.qLDKMHVTHPDataSet2.HOCKY_NAMHOC);
            //// TODO: This line of code loads data into the 'qLDKMHVTHPDataSet2.PHIEUDKHP' table. You can move, or remove it, as needed.
          //  this.pHIEUDKHPTableAdapter.Fill(this.qLDKMHVTHPDataSet2.PHIEUDKHP);

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DSMH obj = new DSMH();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HSSV obj = new HSSV();
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

        private void button6_Click(object sender, EventArgs e)
        {
            DN obj = new DN();
            obj.Show();
            this.Close();
        }
        void loadHK()
        {
            Lenh = "Select distinct HocKy " +
                "From HOCKY_NAMHOC";
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
            Lenh = "Select distinct NamHoc " +
                "From HOCKY_NAMHOC";
            con.Open();
            cmd = new SqlCommand(Lenh, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbNam.Items.Add(dr[0].ToString());
            }
            con.Close();
        }
        private void KetQua_Click(object sender, EventArgs e)

        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);

            // Truy vấn để lấy dữ liệu từ cơ sở dữ liệu
            Lenh = "SELECT PHIEUDKHP.MSSV, PHIEUDKHP.MaSoPhieu, PHIEUTHUHP.MaPhieuThu, PHIEUTHUHP.SoTienThu, PHIEUTHUHP.NgayLap " +
                    "FROM PHIEUDKHP INNER JOIN " +
                    "PHIEUTHUHP ON PHIEUDKHP.MaSoPhieu = PHIEUTHUHP.MaSoPhieu " +
                    "WHERE PHIEUDKHP.MSSV = @MSSV"; // Sửa lỗi ở đây

            try
            {
                con.Open();
                cmd = new SqlCommand(Lenh, con);
                cmd.Parameters.AddWithValue("@MSSV", txtMSSV.Text); // Sửa lỗi ở đây

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);

                // Gán DataTable mới cho DataGridView
                HPList.DataSource = dt;
                HPList.Columns["MaSoPhieu"].HeaderText = "Mã Số Phiếu";
                HPList.Columns["MaPhieuThu"].HeaderText = "Mã Phiếu Thu";
                HPList.Columns["MSSV"].HeaderText = "MSSV";
                HPList.Columns["SoTienThu"].HeaderText = "Số Tiền Thu";
                HPList.Columns["NgayLap"].HeaderText = "Ngày Lập";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void btnXN_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu trường cbNam và cbHK không trống và có thể chuyển đổi thành số nguyên
            if (!int.TryParse(cbNam.SelectedItem.ToString(), out int namHoc) || !int.TryParse(cbHK.SelectedItem.ToString(), out int hocKy))
            {
                MessageBox.Show("Vui lòng chọn giá trị hợp lệ cho năm học và học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sử dụng SqlConnection để làm việc với database
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Xóa tất cả dữ liệu hiện có trong bảng BAOCAOCHUADONGHP
                        string deleteAllData = "DELETE FROM BAOCAOCHUADONGHP";
                        using (SqlCommand cmd = new SqlCommand(deleteAllData, connection, transaction))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        // Lưu trữ thông tin về phiếu đăng ký học phí của tất cả sinh viên chưa đóng học phí
                        List<dynamic> sinhVienChuaDongHP = new List<dynamic>();
                        string queryPhieuDKHP = @"
                    SELECT MSSV, MaSoPhieu, SoTienDaDong, SoTienPhaiDong, SoTienConLai, TongTienDangKi
                    FROM PHIEUDKHP
                    WHERE NamHoc = @NamHoc AND HocKy = @HocKy AND SoTienConLai > 0";

                        using (SqlCommand cmd = new SqlCommand(queryPhieuDKHP, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@NamHoc", namHoc);
                            cmd.Parameters.AddWithValue("@HocKy", hocKy);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    sinhVienChuaDongHP.Add(new
                                    {
                                        MSSV = reader["MSSV"].ToString(),
                                        TongTienDangKi = reader.GetDecimal(reader.GetOrdinal("TongTienDangKi")),
                                        SoTienDaDong = reader.GetDecimal(reader.GetOrdinal("SoTienDaDong")),
                                        SoTienPhaiDong = reader.GetDecimal(reader.GetOrdinal("SoTienPhaiDong")),
                                        SoTienConLai = reader.GetDecimal(reader.GetOrdinal("SoTienConLai"))
                                    });
                                }
                            }
                        }

                        foreach (var sv in sinhVienChuaDongHP)
                        {
                            string mssv = sv.MSSV;
                            decimal tongTienDangKi = sv.TongTienDangKi;
                            decimal soTienDaDong = sv.SoTienDaDong;
                            decimal soTienPhaiDong = sv.SoTienPhaiDong;
                            decimal soTienConLai = sv.SoTienConLai;

                            // Tạo mã báo cáo mới
                            string maBCChuaDongHP;
                            string queryLatestMaBCChuaDongHP = @"
                        SELECT TOP 1 MaBCChuaDongHP
                        FROM BAOCAOCHUADONGHP
                        ORDER BY MaBCChuaDongHP DESC";

                            using (SqlCommand cmd = new SqlCommand(queryLatestMaBCChuaDongHP, connection, transaction))
                            {
                                object result = cmd.ExecuteScalar();
                                if (result != null)
                                {
                                    string latestMaBCChuaDongHP = result.ToString();
                                    int nextMaBCChuaDongHPNumber;
                                    if (!int.TryParse(latestMaBCChuaDongHP.Substring(1), out nextMaBCChuaDongHPNumber))
                                    {
                                        nextMaBCChuaDongHPNumber = 1;
                                    }
                                    else
                                    {
                                        nextMaBCChuaDongHPNumber++;
                                    }
                                    maBCChuaDongHP = "B" + nextMaBCChuaDongHPNumber.ToString("000");
                                }
                                else
                                {
                                    maBCChuaDongHP = "B001";
                                }
                            }

                            // Lưu thông tin vào bảng BAOCAOCHUADONGHP
                            string insertBaoCaoChuaDongHP = @"
                        INSERT INTO BAOCAOCHUADONGHP (MaBCChuaDongHP, HocKy, NamHoc, MSSV, TongTienDangKi, SoTienPhaiDong, SoTienConLai)
                        VALUES (@MaBCChuaDongHP, @HocKy, @NamHoc, @MSSV, @TongTienDangKi, @SoTienPhaiDong, @SoTienConLai)";

                            using (SqlCommand cmd = new SqlCommand(insertBaoCaoChuaDongHP, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@MaBCChuaDongHP", maBCChuaDongHP);
                                cmd.Parameters.AddWithValue("@HocKy", hocKy);
                                cmd.Parameters.AddWithValue("@NamHoc", namHoc);
                                cmd.Parameters.AddWithValue("@MSSV", mssv);
                                cmd.Parameters.AddWithValue("@TongTienDangKi", tongTienDangKi);
                                cmd.Parameters.AddWithValue("@SoTienPhaiDong", soTienPhaiDong);
                                cmd.Parameters.AddWithValue("@SoTienConLai", soTienConLai);

                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Commit the transaction
                        transaction.Commit();

                        // Hiển thị thông báo thành công
                        MessageBox.Show("Đã thêm báo cáo chưa đóng học phí thành công.", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction on error
                        transaction.Rollback();
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }

            loaddata();
        }




        private void button3_Click_1(object sender, EventArgs e)
        {
            DN obj = new DN();
            obj.Show();
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            TestDongHP obj = new TestDongHP();
            obj.Show();
        }
    }
}




