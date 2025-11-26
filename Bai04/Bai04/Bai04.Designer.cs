namespace Bai4
{
    partial class Bai04
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai04));
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            menuitemNewFile = new ToolStripMenuItem();
            menuitemOpenFile = new ToolStripMenuItem();
            menuitemSave = new ToolStripMenuItem();
            menuitemExit = new ToolStripMenuItem();
            địnhDạngToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            cbFont = new ToolStripComboBox();
            cbSize = new ToolStripComboBox();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, địnhDạngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuitemNewFile, menuitemOpenFile, menuitemSave, menuitemExit });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(103, 29);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // menuitemNewFile
            // 
            menuitemNewFile.Image = (Image)resources.GetObject("menuitemNewFile.Image");
            menuitemNewFile.Name = "menuitemNewFile";
            menuitemNewFile.ShortcutKeys = Keys.Control | Keys.N;
            menuitemNewFile.Size = new Size(349, 34);
            menuitemNewFile.Text = " Tạo văn bản mới";
            menuitemNewFile.Click += tạoXănToolStripMenuItem_Click;
            // 
            // menuitemOpenFile
            // 
            menuitemOpenFile.Image = (Image)resources.GetObject("menuitemOpenFile.Image");
            menuitemOpenFile.Name = "menuitemOpenFile";
            menuitemOpenFile.Size = new Size(349, 34);
            menuitemOpenFile.Text = "Mở tập tin";
            menuitemOpenFile.Click += mởTậpTinCtrlOToolStripMenuItem_Click;
            // 
            // menuitemSave
            // 
            menuitemSave.Image = (Image)resources.GetObject("menuitemSave.Image");
            menuitemSave.Name = "menuitemSave";
            menuitemSave.ShortcutKeys = Keys.Control | Keys.S;
            menuitemSave.Size = new Size(349, 34);
            menuitemSave.Text = "Lưu nội dung văn bản";
            menuitemSave.Click += lưuNộiDungToolStripMenuItem_Click;
            // 
            // menuitemExit
            // 
            menuitemExit.Name = "menuitemExit";
            menuitemExit.Size = new Size(349, 34);
            menuitemExit.Text = "Thoát";
            menuitemExit.Click += menuitemExit_Click;
            // 
            // địnhDạngToolStripMenuItem
            // 
            địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            địnhDạngToolStripMenuItem.Size = new Size(111, 29);
            địnhDạngToolStripMenuItem.Text = "Định dạng";
            địnhDạngToolStripMenuItem.Click += địnhDạngToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, cbFont, cbSize, toolStripButton3, toolStripButton4, toolStripButton5 });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 33);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 28);
            toolStripButton1.Text = "btnNew";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(34, 28);
            toolStripButton2.Text = "btnSave";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // cbFont
            // 
            cbFont.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFont.Name = "cbFont";
            cbFont.Size = new Size(121, 33);
            cbFont.SelectedIndexChanged += cbFont_SelectedIndexChanged;
            // 
            // cbSize
            // 
            cbSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSize.Name = "cbSize";
            cbSize.Size = new Size(121, 33);
            cbSize.SelectedIndexChanged += cbSize_SelectedIndexChanged;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(34, 28);
            toolStripButton3.Text = "btnBold";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(34, 28);
            toolStripButton4.Text = "btnItalic";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(34, 28);
            toolStripButton5.Text = "btnUnderlined";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 69);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 383);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // Bai04
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Bai04";
            Text = "Soạn thảo văn bản";
            Load += Bai04_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem menuitemNewFile;
        private ToolStripMenuItem địnhDạngToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripComboBox cbFont;
        private ToolStripComboBox cbSize;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripMenuItem menuitemOpenFile;
        private ToolStripMenuItem menuitemSave;
        private ToolStripMenuItem menuitemExit;
        private RichTextBox richTextBox1;
    }
}
