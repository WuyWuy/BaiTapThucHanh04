namespace Bai06
{
    public partial class Bai06 : Form
    {

        string src;
        string des;
        public Bai06()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(src))
            {
                MessageBox.Show("Thư mục nguồn không tồn tại", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(des))
            {
                MessageBox.Show("Thư mục đích không tồn tại", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] files = Directory.GetFiles(src);

            pbCopying.Minimum = 0;
            pbCopying.Maximum = files.Length;
            pbCopying.Value = 0;
            pbCopying.Step = 1;

            ToolTip tool = new ToolTip();

            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string dest = Path.Combine(des, fileName);

                File.Copy(file, dest, true);

                tool.SetToolTip(pbCopying, "Đang sao chép " + tbSrc.Text + '\\' + fileName);

                pbCopying.PerformStep();

                lblStatus.Text = "Đang sao chép: " + tbSrc.Text + '\\' + fileName;
                Application.DoEvents();

            }

            MessageBox.Show("Hoàn tất sao chép!");
            lblStatus.Text = "Hoàn tất";

        }

        private void btnSrc_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                src = fbd.SelectedPath;
                tbSrc.Text = src;
            }

        }
        private void btnDes_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                des = fbd.SelectedPath;
                tbDes.Text = des;
            }

        }
    }
}
