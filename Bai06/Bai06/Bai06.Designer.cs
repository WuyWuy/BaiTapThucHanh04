namespace Bai06
{
    partial class Bai06
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
            toolStrip1 = new ToolStrip();
            lblStatus = new ToolStripLabel();
            groupBox1 = new GroupBox();
            btnCP = new Button();
            btnDes = new Button();
            tbDes = new TextBox();
            label2 = new Label();
            btnSrc = new Button();
            tbSrc = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            pbCopying = new ProgressBar();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            toolStrip1.Location = new Point(0, 413);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1066, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "tool";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCP);
            groupBox1.Controls.Add(btnDes);
            groupBox1.Controls.Add(tbDes);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSrc);
            groupBox1.Controls.Add(tbSrc);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1042, 231);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sao chép tập tin";
            // 
            // btnCP
            // 
            btnCP.ForeColor = Color.Black;
            btnCP.Location = new Point(418, 181);
            btnCP.Name = "btnCP";
            btnCP.Size = new Size(190, 31);
            btnCP.TabIndex = 6;
            btnCP.Text = "Sao chép";
            btnCP.UseVisualStyleBackColor = true;
            btnCP.Click += button3_Click;
            // 
            // btnDes
            // 
            btnDes.Location = new Point(925, 123);
            btnDes.Name = "btnDes";
            btnDes.Size = new Size(79, 31);
            btnDes.TabIndex = 5;
            btnDes.Text = "...";
            btnDes.UseVisualStyleBackColor = true;
            btnDes.Click += btnDes_Click;
            // 
            // tbDes
            // 
            tbDes.Location = new Point(306, 123);
            tbDes.Name = "tbDes";
            tbDes.ReadOnly = true;
            tbDes.Size = new Size(587, 31);
            tbDes.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(35, 123);
            label2.Name = "label2";
            label2.Size = new Size(233, 25);
            label2.TabIndex = 3;
            label2.Text = "Đường Dẫn Thư Mục Đích";
            // 
            // btnSrc
            // 
            btnSrc.Location = new Point(925, 51);
            btnSrc.Name = "btnSrc";
            btnSrc.Size = new Size(79, 31);
            btnSrc.TabIndex = 2;
            btnSrc.Text = "...";
            btnSrc.UseVisualStyleBackColor = true;
            btnSrc.Click += btnSrc_Click;
            // 
            // tbSrc
            // 
            tbSrc.Location = new Point(306, 51);
            tbSrc.Name = "tbSrc";
            tbSrc.ReadOnly = true;
            tbSrc.Size = new Size(587, 31);
            tbSrc.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(35, 51);
            label1.Name = "label1";
            label1.Size = new Size(253, 25);
            label1.TabIndex = 0;
            label1.Text = "Đường Dẫn Thư Mục Nguồn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pbCopying);
            groupBox2.ForeColor = Color.Blue;
            groupBox2.Location = new Point(12, 281);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1042, 115);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tiến trình sao chép";
            // 
            // pbCopying
            // 
            pbCopying.Location = new Point(35, 48);
            pbCopying.Name = "pbCopying";
            pbCopying.Size = new Size(969, 34);
            pbCopying.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1066, 438);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Sao chép tập tin";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnCP;
        private Button btnDes;
        private TextBox tbDes;
        private Label label2;
        private Button btnSrc;
        private TextBox tbSrc;
        private GroupBox groupBox2;
        private ProgressBar pbCopying;
        private ToolStripLabel lblStatus;
    }
}
