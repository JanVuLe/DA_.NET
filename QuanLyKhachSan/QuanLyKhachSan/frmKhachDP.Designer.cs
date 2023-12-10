namespace QuanLyKhachSan
{
    partial class frmKhachDP
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
            txtDiaChi = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtTen = new TextBox();
            label4 = new Label();
            txtCCCD = new TextBox();
            label5 = new Label();
            txtSDT = new TextBox();
            rdbNu = new RadioButton();
            label6 = new Label();
            rdbNam = new RadioButton();
            label7 = new Label();
            grbThongtin = new GroupBox();
            btnNext = new Button();
            txtQuocTich = new TextBox();
            txtEmail = new TextBox();
            label8 = new Label();
            label1 = new Label();
            label9 = new Label();
            txtNamSinh = new TextBox();
            label10 = new Label();
            txtNhap = new TextBox();
            btnNhapN = new Button();
            btnDone = new Button();
            grbThongtin.SuspendLayout();
            SuspendLayout();
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(115, 153);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(264, 26);
            txtDiaChi.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(75, 15);
            label2.Name = "label2";
            label2.Size = new Size(250, 20);
            label2.TabIndex = 14;
            label2.Text = "Thông Tin Khách Trong Phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 28);
            label3.Name = "label3";
            label3.Size = new Size(32, 19);
            label3.TabIndex = 15;
            label3.Text = "Tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(115, 25);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(264, 26);
            txtTen.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 92);
            label4.Name = "label4";
            label4.Size = new Size(105, 19);
            label4.TabIndex = 17;
            label4.Text = "CCCD/CMND";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(115, 89);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(264, 26);
            txtCCCD.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 124);
            label5.Name = "label5";
            label5.Size = new Size(38, 19);
            label5.TabIndex = 19;
            label5.Text = "SDT";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(115, 121);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(264, 26);
            txtSDT.TabIndex = 20;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(239, 265);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(48, 23);
            rdbNu.TabIndex = 25;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 156);
            label6.Name = "label6";
            label6.Size = new Size(55, 19);
            label6.TabIndex = 21;
            label6.Text = "Địa Chỉ";
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(156, 265);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(57, 23);
            rdbNam.TabIndex = 24;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 267);
            label7.Name = "label7";
            label7.Size = new Size(64, 19);
            label7.TabIndex = 23;
            label7.Text = "Giới Tính";
            // 
            // grbThongtin
            // 
            grbThongtin.Controls.Add(btnNext);
            grbThongtin.Controls.Add(txtTen);
            grbThongtin.Controls.Add(txtQuocTich);
            grbThongtin.Controls.Add(txtEmail);
            grbThongtin.Controls.Add(txtDiaChi);
            grbThongtin.Controls.Add(label7);
            grbThongtin.Controls.Add(label8);
            grbThongtin.Controls.Add(rdbNam);
            grbThongtin.Controls.Add(label1);
            grbThongtin.Controls.Add(label3);
            grbThongtin.Controls.Add(label6);
            grbThongtin.Controls.Add(rdbNu);
            grbThongtin.Controls.Add(label9);
            grbThongtin.Controls.Add(label4);
            grbThongtin.Controls.Add(txtSDT);
            grbThongtin.Controls.Add(txtNamSinh);
            grbThongtin.Controls.Add(txtCCCD);
            grbThongtin.Controls.Add(label5);
            grbThongtin.Enabled = false;
            grbThongtin.Location = new Point(12, 78);
            grbThongtin.Name = "grbThongtin";
            grbThongtin.Size = new Size(385, 338);
            grbThongtin.TabIndex = 26;
            grbThongtin.TabStop = false;
            grbThongtin.Text = "Nhập thông tin";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Yellow;
            btnNext.Location = new Point(141, 304);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(96, 28);
            btnNext.TabIndex = 26;
            btnNext.Text = "Tiếp Theo";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // txtQuocTich
            // 
            txtQuocTich.Location = new Point(115, 217);
            txtQuocTich.Name = "txtQuocTich";
            txtQuocTich.Size = new Size(264, 26);
            txtQuocTich.TabIndex = 22;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(115, 185);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(264, 26);
            txtEmail.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 220);
            label8.Name = "label8";
            label8.Size = new Size(73, 19);
            label8.TabIndex = 21;
            label8.Text = "Quốc Tịch";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 188);
            label1.Name = "label1";
            label1.Size = new Size(42, 19);
            label1.TabIndex = 21;
            label1.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 60);
            label9.Name = "label9";
            label9.Size = new Size(69, 19);
            label9.TabIndex = 17;
            label9.Text = "Năm Sinh";
            // 
            // txtNamSinh
            // 
            txtNamSinh.Location = new Point(115, 57);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(264, 26);
            txtNamSinh.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 47);
            label10.Name = "label10";
            label10.Size = new Size(183, 19);
            label10.TabIndex = 27;
            label10.Text = "Số lượng khách trong phòng:";
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(199, 44);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(117, 26);
            txtNhap.TabIndex = 28;
            // 
            // btnNhapN
            // 
            btnNhapN.Location = new Point(316, 44);
            btnNhapN.Name = "btnNhapN";
            btnNhapN.Size = new Size(81, 28);
            btnNhapN.TabIndex = 29;
            btnNhapN.Text = "Nhập";
            btnNhapN.UseVisualStyleBackColor = true;
            btnNhapN.Click += btnNhapN_Click;
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.Lime;
            btnDone.Enabled = false;
            btnDone.Location = new Point(132, 422);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(131, 46);
            btnDone.TabIndex = 30;
            btnDone.Text = "Hoàn Thành";
            btnDone.UseVisualStyleBackColor = false;
            // 
            // frmKhachDP
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(409, 481);
            Controls.Add(btnDone);
            Controls.Add(btnNhapN);
            Controls.Add(txtNhap);
            Controls.Add(label10);
            Controls.Add(grbThongtin);
            Controls.Add(label2);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmKhachDP";
            Text = "Khách Đặt Phòng";
            Load += frmKhachDP_Load;
            grbThongtin.ResumeLayout(false);
            grbThongtin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDiaChi;
        private Label label2;
        private Label label3;
        private TextBox txtTen;
        private Label label4;
        private TextBox txtCCCD;
        private Label label5;
        private TextBox txtSDT;
        private RadioButton rdbNu;
        private Label label6;
        private RadioButton rdbNam;
        private Label label7;
        private GroupBox grbThongtin;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtQuocTich;
        private Label label8;
        private Label label9;
        private TextBox txtNamSinh;
        private Label label10;
        private TextBox txtNhap;
        private Button btnNhapN;
        private Button btnDone;
        private Button btnNext;
    }
}