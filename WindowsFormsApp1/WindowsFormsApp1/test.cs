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
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class test : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-MROI1QP;Initial Catalog=QLDKMHVTHP;Integrated Security=True";
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string Lenh;
        SqlDataReader dr;
        public test()
        {
            InitializeComponent();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDKMHVTHPDataSet.CTNGANH' table. You can move, or remove it, as needed.
            this.cTNGANHTableAdapter.Fill(this.qLDKMHVTHPDataSet.CTNGANH);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            int namHoc;
            if (!int.TryParse(txtNH.Text, out namHoc))
            {
                MessageBox.Show("Năm học không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<CourseInfo> coursesToInsert = new List<CourseInfo>();

            // Thu thập thông tin các môn học được chọn
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkboxCell = row.Cells["Checkbox"] as DataGridViewCheckBoxCell;
                if (checkboxCell != null && Convert.ToBoolean(checkboxCell.Value))
                {
                    int hocKy = Convert.ToInt32(row.Cells["HocKy"].Value);
                    string maMonHoc = row.Cells["MaMonHoc"].Value.ToString();
                    string tenMonHoc = row.Cells["TenMonHoc"].Value.ToString();
                    string maNganh = row.Cells["MaNganh"].Value.ToString();

                    coursesToInsert.Add(new CourseInfo
                    {
                        HocKy = hocKy,
                        MaMonHoc = maMonHoc,
                        TenMonHoc = tenMonHoc,
                        MaNganh = maNganh
                    });
                }
            }

            // Nếu không có môn học nào được chọn, thông báo và thoát
            if (coursesToInsert.Count == 0)
            {
                MessageBox.Show("Không có môn học nào được chọn để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();

                string latestMaMo;
                // Lấy mã mở gần nhất từ bảng
                using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 MaMo FROM DSMH_MO_TRONG_HOC_KI ORDER BY MaMo DESC", con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        latestMaMo = result.ToString();
                    }
                    else
                    {
                        latestMaMo = "M000"; // Bắt đầu từ M000 nếu không có bản ghi nào
                    }
                }

                // Lấy số tiếp theo từ mã mở gần nhất
                int nextMaMoNumber;
                if (!int.TryParse(latestMaMo.Substring(1), out nextMaMoNumber))
                {
                    nextMaMoNumber = 0;
                }
                nextMaMoNumber++; // Tăng giá trị để lấy mã mở tiếp theo

                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Kiểm tra xem có môn học nào đã tồn tại hay không
                        foreach (var course in coursesToInsert)
                        {
                            if (IsSubjectExists(con, transaction, namHoc, course.HocKy, course.MaMonHoc))
                            {
                                MessageBox.Show($"Môn học '{course.MaMonHoc}' đã tồn tại trong DSMH_MO_TRONG_HOC_KI cho năm học {namHoc} và học kỳ {course.HocKy}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                transaction.Rollback();
                                return;
                            }
                        }

                        // Nếu không có môn học nào tồn tại, tiến hành thêm dữ liệu
                        foreach (var course in coursesToInsert)
                        {
                            string maMo = "M" + nextMaMoNumber.ToString("000");

                            // Chèn dữ liệu vào bảng
                            InsertIntoDSMH_MO_TRONG_HOC_KI(con, transaction, maMo, course.HocKy, namHoc, course.MaMonHoc, course.MaNganh);

                            // Tăng giá trị mã mở tiếp theo
                            nextMaMoNumber++;
                        }

                        // Commit transaction
                        transaction.Commit();

                        MessageBox.Show("Dữ liệu đã được cập nhật vào bảng DSMH_MO_TRONG_HOC_KI.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction nếu có lỗi
                        transaction.Rollback();
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }

            // Sau khi thêm dữ liệu, cập nhật lại hiển thị dữ liệu
            loaddata();
        }

        // Class lưu trữ thông tin môn học
        private class CourseInfo
        {
            public int HocKy { get; set; }
            public string MaMonHoc { get; set; }
            public string TenMonHoc { get; set; }
            public string MaNganh { get; set; }
        }

        // Hàm kiểm tra xem môn học đã tồn tại trong bảng hay chưa
        private bool IsSubjectExists(SqlConnection con, SqlTransaction transaction, int namHoc, int hocKy, string maMonHoc)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM DSMH_MO_TRONG_HOC_KI WHERE NamHoc = @NamHoc AND HocKy = @HocKy AND MaMonHoc = @MaMonHoc", con, transaction))
            {
                cmd.Parameters.AddWithValue("@NamHoc", namHoc);
                cmd.Parameters.AddWithValue("@HocKy", hocKy);
                cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void loaddata()
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                try
                {
                    con.Open();

                    // Tạo câu lệnh SQL để lấy dữ liệu từ bảng CTNGANH
                    string query = "SELECT * FROM CTNGANH";

                    // Sử dụng SqlDataAdapter để lấy dữ liệu
                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        // Tạo DataTable để chứa dữ liệu
                        DataTable dt = new DataTable();

                        // Đổ dữ liệu vào DataTable
                        da.Fill(dt);

                        // Gán DataTable làm nguồn dữ liệu cho DataGridView
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void InsertIntoDSMH_MO_TRONG_HOC_KI(SqlConnection con, SqlTransaction transaction, string maMo, int hocKy, int namHoc, string maMonHoc, string maNganh)
        {
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.Transaction = transaction;
                cmd.CommandText = @"
            INSERT INTO DSMH_MO_TRONG_HOC_KI (MaMo, HocKy, NamHoc, MaMonHoc, MaNganh) 
            VALUES (@MaMo, @HocKy, @NamHoc, @MaMonHoc, @MaNganh)";
                cmd.Parameters.AddWithValue("@MaMo", maMo);
                cmd.Parameters.AddWithValue("@HocKy", hocKy);
                cmd.Parameters.AddWithValue("@NamHoc", namHoc);
                cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);

                cmd.Parameters.AddWithValue("@MaNganh", maNganh);

                cmd.ExecuteNonQuery();
            }
        }





    }
}
