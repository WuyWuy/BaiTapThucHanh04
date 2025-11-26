namespace Bai05
{
    partial class Bai05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai05));
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            thêmMớiToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            dgvSV = new DataGridView();
            SoTT = new DataGridViewTextBoxColumn();
            MaSoSV = new DataGridViewTextBoxColumn();
            TenSinhVien = new DataGridViewTextBoxColumn();
            Khoa = new DataGridViewTextBoxColumn();
            DiemTB = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSV).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1008, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmMớiToolStripMenuItem, thoátToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(116, 29);
            chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // thêmMớiToolStripMenuItem
            // 
            thêmMớiToolStripMenuItem.Image = (Image)resources.GetObject("thêmMớiToolStripMenuItem.Image");
            thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            thêmMớiToolStripMenuItem.Size = new Size(270, 34);
            thêmMớiToolStripMenuItem.Text = "Thêm mới";
            thêmMớiToolStripMenuItem.Click += thêmMớiToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Image = (Image)resources.GetObject("thoátToolStripMenuItem.Image");
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(270, 34);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // dgvSV
            // 
            dgvSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSV.Columns.AddRange(new DataGridViewColumn[] { SoTT, MaSoSV, TenSinhVien, Khoa, DiemTB });
            dgvSV.Location = new Point(0, 82);
            dgvSV.MultiSelect = false;
            dgvSV.Name = "dgvSV";
            dgvSV.ReadOnly = true;
            dgvSV.RowHeadersWidth = 62;
            dgvSV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSV.Size = new Size(1046, 502);
            dgvSV.TabIndex = 1;
            // 
            // SoTT
            // 
            SoTT.HeaderText = "Số TT";
            SoTT.MinimumWidth = 8;
            SoTT.Name = "SoTT";
            SoTT.ReadOnly = true;
            SoTT.Width = 150;
            // 
            // MaSoSV
            // 
            MaSoSV.DataPropertyName = "MaSoSV";
            MaSoSV.HeaderText = "Mã Số SV";
            MaSoSV.MinimumWidth = 8;
            MaSoSV.Name = "MaSoSV";
            MaSoSV.ReadOnly = true;
            MaSoSV.Width = 150;
            // 
            // TenSinhVien
            // 
            TenSinhVien.DataPropertyName = "TenSinhVien";
            TenSinhVien.HeaderText = "Tên Sinh Viên";
            TenSinhVien.MinimumWidth = 8;
            TenSinhVien.Name = "TenSinhVien";
            TenSinhVien.ReadOnly = true;
            TenSinhVien.Width = 300;
            // 
            // Khoa
            // 
            Khoa.DataPropertyName = "Khoa";
            Khoa.HeaderText = "Khoa";
            Khoa.MinimumWidth = 8;
            Khoa.Name = "Khoa";
            Khoa.ReadOnly = true;
            Khoa.Width = 250;
            // 
            // DiemTB
            // 
            DiemTB.DataPropertyName = "DiemTB";
            DiemTB.HeaderText = "Điểm TB";
            DiemTB.MinimumWidth = 8;
            DiemTB.Name = "DiemTB";
            DiemTB.ReadOnly = true;
            DiemTB.Width = 150;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripLabel1, toolStripSeparator1, toolStripLabel2, toolStripTextBox1 });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1008, 46);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 41);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Segoe UI", 15F);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(152, 41);
            toolStripLabel1.Text = "Thêm mới";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 46);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(240, 41);
            toolStripLabel2.Text = "                 Tìm kiếm theo tên";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.BorderStyle = BorderStyle.None;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(500, 46);
            toolStripTextBox1.TextChanged += toolStripTextBox1_TextChanged;
            // 
            // Bai05
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1008, 579);
            Controls.Add(toolStrip1);
            Controls.Add(dgvSV);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Bai05";
            Text = "Quản lý sinh viên";
            Load += Bai05_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSV).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem thêmMớiToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private DataGridView dgvSV;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripTextBox toolStripTextBox1;
        private DataGridViewTextBoxColumn SoTT;
        private DataGridViewTextBoxColumn MaSoSV;
        private DataGridViewTextBoxColumn TenSinhVien;
        private DataGridViewTextBoxColumn Khoa;
        private DataGridViewTextBoxColumn DiemTB;
    }
}
