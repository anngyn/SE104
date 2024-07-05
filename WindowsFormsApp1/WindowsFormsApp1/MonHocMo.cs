using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WindowsFormsApp1
{
    public partial class MonHocMo : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-MROI1QP;Initial Catalog=QLDKMHVTHP;Integrated Security=True";
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string Lenh;
        SqlDataReader dr;

        public MonHocMo()
        {
            InitializeComponent();
            con = new SqlConnection(str);
            loadHK();
            loadNam();
        }

        void loadHK()
        {
            Lenh = "SELECT DISTINCT HocKy FROM HOCKY_NAMHOC";
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
            Lenh = "SELECT DISTINCT NamHoc FROM HOCKY_NAMHOC";
            con.Open();
            cmd = new SqlCommand(Lenh, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbNam.Items.Add(dr[0].ToString());
            }
            con.Close();
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

        private void btnThemMHM_Click(object sender, EventArgs e)
        {
            // Add your implementation here
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            DN obj = new DN();
            obj.Show();
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Add your implementation here
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);

            // Truy vấn để lấy dữ liệu từ cơ sở dữ liệu
            Lenh = @"
                SELECT DSMH_MO_TRONG_HOC_KI.MaMonHoc, DSMH.TenMonHoc, DSMH_MO_TRONG_HOC_KI.MaNganh 
                FROM DSMH_MO_TRONG_HOC_KI
                JOIN DSMH ON DSMH_MO_TRONG_HOC_KI.MaMonHoc = DSMH.MaMonHoc
                WHERE DSMH_MO_TRONG_HOC_KI.HocKy = @HocKy AND DSMH_MO_TRONG_HOC_KI.NamHoc = @NamHoc";

            try
            {
                con.Open();
                cmd = new SqlCommand(Lenh, con);
                cmd.Parameters.AddWithValue("@HocKy", cbHK.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@NamHoc", cbNam.SelectedItem.ToString());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Kiểm tra xem DataTable có cột "TenMonHoc" hay không
                if (!dt.Columns.Contains("TenMonHoc"))
                {
                    MessageBox.Show("Cột 'TenMonHoc' không tồn tại trong kết quả truy vấn.");
                }

                // Gán DataTable mới cho DataGridView
                dtMHM.DataSource = dt;         
                dtMHM.Columns["TenMonHoc"].HeaderText = "Tên Môn Học";
                dtMHM.Columns["MaMonHoc"].HeaderText = "Mã Môn Học";
                dtMHM.Columns["MaNganh"].HeaderText = "Mã Ngành";
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

        private void MonHocMo_Load(object sender, EventArgs e)
        {
            // Add your implementation here
        }

        private void btnChinh_Click(object sender, EventArgs e)
        {
            test obj = new test();
            obj.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;

                foreach (DataGridViewRow row in dtMHM.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["Checkbox"];
                    if (chk != null && Convert.ToBoolean(chk.Value) == true)
                    {
                        string maMonHoc = row.Cells["MaMonHoc"].Value.ToString();
                        string maNganh = row.Cells["MaNganh"].Value.ToString();

                        // Truy vấn xóa
                        cmd.CommandText = "DELETE FROM DSMH_MO_TRONG_HOC_KI WHERE MaMonHoc = @MaMonHoc AND MaNganh = @MaNganh";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                        cmd.Parameters.AddWithValue("@MaNganh", maNganh);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Tải lại dữ liệu
                button1_Click(sender, e);
                MessageBox.Show("Xóa thành công!");
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
        
    }
}
