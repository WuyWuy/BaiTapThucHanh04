using System.Data;
using Microsoft.Data.SqlClient;

namespace Bai05
{
    public partial class Bai05 : Form
    {
        private string connStr = @"Server=X1-CARBON-GEN6\SQLEXPRESS;Database=NguyenHuy;User Id=NguyenHuy;Password=12345;TrustServerCertificate=True;Encrypt=False";
        private SqlConnection conn;
        private SqlDataAdapter myAdap;
        private DataSet ds;
        private DataTable dt;
        public Bai05()
        {
            InitializeComponent();
            dgvSV.AutoGenerateColumns = true;
            dgvSV.AllowUserToAddRows = false;
        }
        public void LoadData()
        {
            conn = new SqlConnection(connStr);
            conn.Open();

            string sqlStr = "Select * from DSSinhVien";
            myAdap = new SqlDataAdapter(sqlStr, conn);

            ds = new DataSet();
            myAdap.Fill(ds, "DSSinhVien");
            dt = ds.Tables["DSSinhVien"];

            dgvSV.DataSource = dt;

            for (int i = 0; i < dgvSV.Rows.Count; i++)
            {
                dgvSV.Rows[i].Cells["SoTT"].Value = i + 1;
            }

            conn.Close();

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenForm();
        }
        private void OpenForm()
        {
            Student NewForm = new Student(this);

            NewForm.Show();

        }
        private void Bai05_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm();
        }
        private void reloadSoTT()
        {
            int index = 0;

            foreach (DataGridViewRow x in dgvSV.Rows)
            {
                x.Cells["SoTT"].Value = ++index;
            }
        }
        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchItem = toolStripTextBox1.Text;

            if (searchItem == string.Empty)
            {
                dt.DefaultView.RowFilter = "";
            }
            else
            {
                dt.DefaultView.RowFilter = $"TenSinhVien LIKE '%{searchItem}%'";
            }

            reloadSoTT();

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
