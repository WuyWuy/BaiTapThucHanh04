namespace Bai03
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            timer1.Start();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Media|*.mp3;*mp4;*.avi;*.mpeg;*.wav;*.mid";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    axWindowsMediaPlayer1.URL = openFileDialog.FileName;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }

            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.uiMode = "full";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string formatHour = now.ToString("hh:mm:ss tt");
            string formatDate = now.ToString("dd/MM/yyyy");
            toolStripStatusLabel1.Text = "Hôm nay là ngày " + formatDate
                     + " - Bây giờ là " + formatHour;
        }
    }
}
