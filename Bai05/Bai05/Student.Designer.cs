namespace Bai05
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbMSSV = new TextBox();
            tbTenSV = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbAvg = new TextBox();
            label4 = new Label();
            btnAdd = new Button();
            btnExit = new Button();
            this.cbKhoa = new ComboBox();
            SuspendLayout();
            // 
            // cbKhoa
            // 
            cbKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKhoa.Font = new Font("Segoe UI", 12F);
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Items.AddRange(new object[] { "Công nghệ thông tin", "Khoa học máy tính", "Công nghệ phần mềm", "Kỹ thuật máy tính", "Khoa học & kỹ thuật thông tin", "Hệ thống thông tin", "Mạng máy tính & truyền thông" });
            cbKhoa.Location = new Point(260, 208);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(280, 40);
            cbKhoa.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(64, 45);
            label1.Name = "label1";
            label1.Size = new Size(191, 32);
            label1.TabIndex = 0;
            label1.Text = "Mã Số Sinh Viên";
            // 
            // tbMSSV
            // 
            tbMSSV.Font = new Font("Segoe UI", 12F);
            tbMSSV.Location = new Point(261, 42);
            tbMSSV.Name = "tbMSSV";
            tbMSSV.Size = new Size(479, 39);
            tbMSSV.TabIndex = 1;
            // 
            // tbTenSV
            // 
            tbTenSV.Font = new Font("Segoe UI", 12F);
            tbTenSV.Location = new Point(261, 124);
            tbTenSV.Name = "tbTenSV";
            tbTenSV.Size = new Size(479, 39);
            tbTenSV.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(64, 127);
            label2.Name = "label2";
            label2.Size = new Size(161, 32);
            label2.TabIndex = 2;
            label2.Text = "Tên Sinh Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(62, 211);
            label3.Name = "label3";
            label3.Size = new Size(68, 32);
            label3.TabIndex = 4;
            label3.Text = "Khoa";
            // 
            // tbAvg
            // 
            tbAvg.Font = new Font("Segoe UI", 12F);
            tbAvg.Location = new Point(260, 290);
            tbAvg.Name = "tbAvg";
            tbAvg.Size = new Size(160, 39);
            tbAvg.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(63, 293);
            label4.Name = "label4";
            label4.Size = new Size(105, 32);
            label4.TabIndex = 6;
            label4.Text = "Điểm TB";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.PaleGreen;
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(420, 376);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 51);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm Mới";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 128, 0);
            btnExit.Font = new Font("Segoe UI", 12F);
            btnExit.Location = new Point(610, 376);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(130, 51);
            btnExit.TabIndex = 10;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += button2_Click;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(cbKhoa);
            Controls.Add(tbAvg);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbTenSV);
            Controls.Add(label2);
            Controls.Add(tbMSSV);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Student";
            Text = "Thêm Sinh Viên";
            Load += Student_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbMSSV;
        private TextBox tbTenSV;
        private Label label2;
        private Label label3;
        private TextBox tbAvg;
        private Label label4;
        private ComboBox cbKhoa;
        private Button btnAdd;
        private Button btnExit;
    }
}