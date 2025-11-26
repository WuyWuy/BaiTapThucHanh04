namespace Bai4
{
    public partial class Bai04 : Form
    {

        bool isBold;
        bool isItalic;
        bool isUnderline;
        bool isLoading;
        string currentFile = "";
        public Bai04()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
        private void Bai04_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                cbFont.Items.Add(font.Name);
            }

            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

            foreach (int size in sizes)
            {
                cbSize.Items.Add(size);
            }

            cbFont.SelectedIndex = cbFont.Items.IndexOf("Tahoma");
            cbSize.SelectedIndex = cbSize.Items.IndexOf(14);

        }
        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (int.TryParse(cbSize.Text, out int size))
                richTextBox1.Font = new Font(cbFont.Text, size);
        }
        private void tạoXănToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetToDefault();
        }
        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cbSize.Text, out int size))
                richTextBox1.Font = new Font(cbFont.Text, size);
        }
        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fdlg = new FontDialog();

            fdlg.ShowColor = true;

            if (fdlg.ShowDialog() == DialogResult.OK)
            {

                string text = richTextBox1.Text;
                richTextBox1.Clear();

                richTextBox1.Font = fdlg.Font; 
                richTextBox1.ForeColor = fdlg.Color;
                richTextBox1.Text = text;

                cbFont.Text = fdlg.Font.Name;
                cbSize.Text = ((int)fdlg.Font.Size).ToString();

                bool isUnderline1 = fdlg.Font.Underline;

                if (isUnderline == false && isUnderline1 == true)
                {
                    toolStripButton5.BackColor = SystemColors.ActiveCaption;
                    isUnderline = true;
                }

            }

        }
        private void mởTậpTinCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void lưuNộiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Text files |*.txt|Rich text format |*.rtf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;

                if (Path.GetExtension(filename).ToLower() == ".rtf")
                {
                    richTextBox1.LoadFile(filename, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.LoadFile(filename, RichTextBoxStreamType.PlainText);
                }
            }
        }
        private void ToggleStyle(FontStyle style)
        {

            if (richTextBox1.SelectionFont == null) return;

            Font font = richTextBox1.SelectionFont;
            FontStyle newStyle;

            if (font.Style.HasFlag(style)) newStyle = font.Style & ~style;
            else newStyle = font.Style | style;

            richTextBox1.SelectionFont = new Font(font.FontFamily, font.Size, newStyle);

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            ToolStripButton btn = sender as ToolStripButton;

            if (btn == null) return;

            isBold = !isBold;
            if (isBold)
            {
                btn.BackColor = SystemColors.ActiveCaption;
            }
            else btn.BackColor = SystemColors.Control;

            ToggleStyle(FontStyle.Bold);

        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = sender as ToolStripButton;

            if (btn == null) return;

            isItalic = !isItalic;

            if (isItalic) btn.BackColor = SystemColors.ActiveCaption;
            else btn.BackColor = SystemColors.Control;

            ToggleStyle(FontStyle.Italic);

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = sender as ToolStripButton;

            if (btn == null) return;

            isUnderline = !isUnderline;

            if (isUnderline) btn.BackColor = SystemColors.ActiveCaption;
            else btn.BackColor = SystemColors.Control;

            ToggleStyle(FontStyle.Underline);
        }

        private void ResetToDefault()
        {
            richTextBox1.Text = "";

            cbFont.SelectedIndex = cbFont.Items.IndexOf("Tahoma");
            cbSize.SelectedIndex = cbSize.Items.IndexOf(14);

            richTextBox1.ForeColor = Color.Black;

            if (isBold)
            {
                isBold = false;
                toolStripButton3.BackColor = SystemColors.Control;
                ToggleStyle(FontStyle.Bold);
            }
            if (isItalic)
            {
                isItalic = false;
                toolStripButton4.BackColor = SystemColors.Control;
                ToggleStyle(FontStyle.Italic);
            }
            if (isUnderline)
            {
                isUnderline = false;
                toolStripButton5.BackColor = SystemColors.Control;
                ToggleStyle(FontStyle.Underline);
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ResetToDefault();
        }

        private void SaveFile()
        {
            if (string.IsNullOrEmpty(currentFile))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Rich text format |*.rtf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    currentFile = sfd.FileName;
                    richTextBox1.SaveFile(currentFile, RichTextBoxStreamType.RichText);

                    MessageBox.Show("Lưu văn bản thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                richTextBox1.SaveFile(currentFile, RichTextBoxStreamType.RichText);

                MessageBox.Show("Lưu văn bản thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void menuitemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
