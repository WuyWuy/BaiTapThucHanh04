using Microsoft.Data.SqlClient;

namespace Bai05
{
    public partial class Student : Form
    {
        private string connStr = @"Server=[Ten Host];Database=NguyenHuy;Trusted_Connection=True;TrustServerCertificate=True;";
        private SqlConnection conn;
        private Bai05 parentForm;
        public Student(Bai05 parent)
        {
            InitializeComponent();
            this.parentForm = parent;
            conn = new SqlConnection(connStr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isSame(string mssv)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM DSSinhVien WHERE MaSoSV = @mssv";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mssv", mssv);

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }
        private bool isName(string s)
        {
            return s.All(ch => char.IsLetter(ch) || ch == ' ');
        }
        private bool checkError()
        {
            if (tbMSSV.Text == string.Empty ||
                tbTenSV.Text == string.Empty ||
                tbAvg.Text == string.Empty)
            {
                MessageBox.Show("Thông tin chưa nhập", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            foreach (char x in tbMSSV.Text)
            {
                if (x < '0' || x > '9')
                {
                    MessageBox.Show("MSSV chỉ chứa số", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbMSSV.Text = "";
                    return true;
                }
            }

            if ( isSame(tbMSSV.Text) )
            {
                MessageBox.Show("MSSV bị trùng lặp", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMSSV.Text = "";
                return true;
            }

            if ( !isName(tbTenSV.Text) )
            {
                MessageBox.Show("Tên sinh viên không hợp lệ", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTenSV.Text = "";
                return true;
            }

            string GPA = tbAvg.Text; bool hasDot = false;

            if (GPA[0] < '0' || GPA[0] > '9')
            {
                MessageBox.Show("Nhập lại Điểm TB", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbAvg.Text = "";
                return true;
            }

            foreach (char x in GPA)
            {

                if (x == '.')
                {
                    if (!hasDot) hasDot = true;
                    else
                    {
                        MessageBox.Show("Nhập lại Điểm TB", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbAvg.Text = "";
                        return true;
                    }
                } else 

                if (x < '0' || x > '9')
                {
                    MessageBox.Show("Nhập lại Điểm TB", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbAvg.Text = "";
                    return true;
                }
            }

            if (float.Parse(GPA) > 10)
            {
                MessageBox.Show("Nhập lại Điểm TB", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbAvg.Text = "";
                return true;
            }

            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (checkError()) return;
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                conn.Open();

                string sqlStr = @"INSERT INTO DSSinhVien values (@MaSoSV, @TenSinhVien, @Khoa, @DiemTB)";

                SqlCommand comm = new SqlCommand(sqlStr, conn);

                comm.Parameters.AddWithValue("@MaSoSV", int.Parse(tbMSSV.Text));
                comm.Parameters.AddWithValue("@TenSinhVien", tbTenSV.Text);
                comm.Parameters.AddWithValue("@Khoa", cbKhoa.Text);
                comm.Parameters.AddWithValue("@DiemTB", Math.Round(float.Parse(tbAvg.Text), 2));

                comm.ExecuteNonQuery();
            }
            parentForm.LoadData();
            MessageBox.Show("Thêm thành công!"); 
            this.Close();

        }
        private void Student_Load(object sender, EventArgs e)
        {
            cbKhoa.SelectedIndex = 0;
        }
    }
}

