namespace QuanLyKhachSan
{
    partial class frmDatPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grbThongTinDatPhong = new System.Windows.Forms.GroupBox();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.btnNext = new System.Windows.Forms.Button();
            this.radPhongVIP = new System.Windows.Forms.RadioButton();
            this.radPhongDoi = new System.Windows.Forms.RadioButton();
            this.radPhongDon = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.grbThongTinPhong = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.grbTongTien = new System.Windows.Forms.GroupBox();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.btnDV = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSLPhong = new System.Windows.Forms.TextBox();
            this.lbNgayHomNay = new System.Windows.Forms.Label();
            this.flpChonPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPhongDaChon = new System.Windows.Forms.FlowLayoutPanel();
            this.grbThongTinDatPhong.SuspendLayout();
            this.grbThongTinPhong.SuspendLayout();
            this.grbTongTien.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đặt Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(112, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông Tin Đặt Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày Đi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số Người";
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.Location = new System.Drawing.Point(120, 223);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.Size = new System.Drawing.Size(261, 23);
            this.txtSoNguoi.TabIndex = 8;
            this.txtSoNguoi.TextChanged += new System.EventHandler(this.txtSoNguoi_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Giới Tính";
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(120, 343);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(55, 21);
            this.rdbNam.TabIndex = 12;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            this.rdbNam.CheckedChanged += new System.EventHandler(this.rdbNam_CheckedChanged);
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(246, 343);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(44, 21);
            this.rdbNu.TabIndex = 13;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            this.rdbNu.CheckedChanged += new System.EventHandler(this.rdbNu_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(115, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Thông Tin Phòng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Chọn Phòng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Phòng đã chọn";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(153, 472);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 50);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Salmon;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnHuy.Location = new System.Drawing.Point(303, 472);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(106, 50);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // grbThongTinDatPhong
            // 
            this.grbThongTinDatPhong.Controls.Add(this.label6);
            this.grbThongTinDatPhong.Controls.Add(this.btnDV);
            this.grbThongTinDatPhong.Controls.Add(this.dtpNgayDi);
            this.grbThongTinDatPhong.Controls.Add(this.dtpNgayDen);
            this.grbThongTinDatPhong.Controls.Add(this.label2);
            this.grbThongTinDatPhong.Controls.Add(this.label3);
            this.grbThongTinDatPhong.Controls.Add(this.btnNext);
            this.grbThongTinDatPhong.Controls.Add(this.label4);
            this.grbThongTinDatPhong.Controls.Add(this.label5);
            this.grbThongTinDatPhong.Controls.Add(this.txtSLPhong);
            this.grbThongTinDatPhong.Controls.Add(this.txtSoNguoi);
            this.grbThongTinDatPhong.Controls.Add(this.radPhongVIP);
            this.grbThongTinDatPhong.Controls.Add(this.radPhongDoi);
            this.grbThongTinDatPhong.Controls.Add(this.rdbNu);
            this.grbThongTinDatPhong.Controls.Add(this.radPhongDon);
            this.grbThongTinDatPhong.Controls.Add(this.label11);
            this.grbThongTinDatPhong.Controls.Add(this.rdbNam);
            this.grbThongTinDatPhong.Controls.Add(this.label7);
            this.grbThongTinDatPhong.Location = new System.Drawing.Point(12, 54);
            this.grbThongTinDatPhong.Name = "grbThongTinDatPhong";
            this.grbThongTinDatPhong.Size = new System.Drawing.Size(415, 528);
            this.grbThongTinDatPhong.TabIndex = 21;
            this.grbThongTinDatPhong.TabStop = false;
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDi.Location = new System.Drawing.Point(120, 163);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(261, 23);
            this.dtpNgayDi.TabIndex = 20;
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDen.Location = new System.Drawing.Point(120, 100);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(261, 23);
            this.dtpNgayDen.TabIndex = 20;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Chartreuse;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNext.Location = new System.Drawing.Point(140, 472);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(106, 50);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Tiếp Theo";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // radPhongVIP
            // 
            this.radPhongVIP.AutoSize = true;
            this.radPhongVIP.Location = new System.Drawing.Point(317, 400);
            this.radPhongVIP.Name = "radPhongVIP";
            this.radPhongVIP.Size = new System.Drawing.Size(92, 21);
            this.radPhongVIP.TabIndex = 13;
            this.radPhongVIP.TabStop = true;
            this.radPhongVIP.Text = "Phòng VIP";
            this.radPhongVIP.UseVisualStyleBackColor = true;
            this.radPhongVIP.CheckedChanged += new System.EventHandler(this.radPhongVIP_CheckedChanged);
            // 
            // radPhongDoi
            // 
            this.radPhongDoi.AutoSize = true;
            this.radPhongDoi.Location = new System.Drawing.Point(223, 400);
            this.radPhongDoi.Name = "radPhongDoi";
            this.radPhongDoi.Size = new System.Drawing.Size(92, 21);
            this.radPhongDoi.TabIndex = 13;
            this.radPhongDoi.TabStop = true;
            this.radPhongDoi.Text = "Phòng Đôi";
            this.radPhongDoi.UseVisualStyleBackColor = true;
            this.radPhongDoi.CheckedChanged += new System.EventHandler(this.radPhongDoi_CheckedChanged);
            // 
            // radPhongDon
            // 
            this.radPhongDon.AutoSize = true;
            this.radPhongDon.Location = new System.Drawing.Point(120, 400);
            this.radPhongDon.Name = "radPhongDon";
            this.radPhongDon.Size = new System.Drawing.Size(97, 21);
            this.radPhongDon.TabIndex = 12;
            this.radPhongDon.TabStop = true;
            this.radPhongDon.Text = "Phòng Đơn";
            this.radPhongDon.UseVisualStyleBackColor = true;
            this.radPhongDon.CheckedChanged += new System.EventHandler(this.radPhongDon_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 402);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Loại Phòng";
            // 
            // grbThongTinPhong
            // 
            this.grbThongTinPhong.Controls.Add(this.flpPhongDaChon);
            this.grbThongTinPhong.Controls.Add(this.flpChonPhong);
            this.grbThongTinPhong.Controls.Add(this.btnXoa);
            this.grbThongTinPhong.Controls.Add(this.btnThem);
            this.grbThongTinPhong.Controls.Add(this.label9);
            this.grbThongTinPhong.Controls.Add(this.btnHuy);
            this.grbThongTinPhong.Controls.Add(this.btnBack);
            this.grbThongTinPhong.Controls.Add(this.btnSave);
            this.grbThongTinPhong.Controls.Add(this.label10);
            this.grbThongTinPhong.Controls.Add(this.label8);
            this.grbThongTinPhong.Location = new System.Drawing.Point(459, 54);
            this.grbThongTinPhong.Name = "grbThongTinPhong";
            this.grbThongTinPhong.Size = new System.Drawing.Size(415, 528);
            this.grbThongTinPhong.TabIndex = 22;
            this.grbThongTinPhong.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(303, 253);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 30);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(301, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 30);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.Location = new System.Drawing.Point(6, 472);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 50);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Trở Lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(112, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 23);
            this.label12.TabIndex = 23;
            this.label12.Text = "Thành Tiền";
            // 
            // grbTongTien
            // 
            this.grbTongTien.Controls.Add(this.lbNgayHomNay);
            this.grbTongTien.Controls.Add(this.btnThemPhong);
            this.grbTongTien.Controls.Add(this.btnXacNhan);
            this.grbTongTien.Controls.Add(this.lbThanhTien);
            this.grbTongTien.Controls.Add(this.label12);
            this.grbTongTien.Location = new System.Drawing.Point(894, 54);
            this.grbTongTien.Name = "grbTongTien";
            this.grbTongTien.Size = new System.Drawing.Size(329, 522);
            this.grbTongTien.TabIndex = 24;
            this.grbTongTien.TabStop = false;
            this.grbTongTien.Text = "Hóa Đơn";
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.BackColor = System.Drawing.Color.Chartreuse;
            this.btnThemPhong.Location = new System.Drawing.Point(12, 473);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(103, 43);
            this.btnThemPhong.TabIndex = 25;
            this.btnThemPhong.Text = "Thêm Phòng";
            this.btnThemPhong.UseVisualStyleBackColor = false;
            this.btnThemPhong.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Chartreuse;
            this.btnXacNhan.Location = new System.Drawing.Point(220, 473);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(103, 43);
            this.btnXacNhan.TabIndex = 25;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.Location = new System.Drawing.Point(6, 75);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(317, 362);
            this.lbThanhTien.TabIndex = 24;
            this.lbThanhTien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDV
            // 
            this.btnDV.BackColor = System.Drawing.Color.Cyan;
            this.btnDV.Location = new System.Drawing.Point(295, 472);
            this.btnDV.Name = "btnDV";
            this.btnDV.Size = new System.Drawing.Size(114, 30);
            this.btnDV.TabIndex = 21;
            this.btnDV.Text = "Thêm Dịch Vụ";
            this.btnDV.UseVisualStyleBackColor = false;
            this.btnDV.Click += new System.EventHandler(this.btnDV_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Số Lượng Phòng";
            // 
            // txtSLPhong
            // 
            this.txtSLPhong.Location = new System.Drawing.Point(135, 281);
            this.txtSLPhong.Name = "txtSLPhong";
            this.txtSLPhong.Size = new System.Drawing.Size(246, 23);
            this.txtSLPhong.TabIndex = 8;
            this.txtSLPhong.TextChanged += new System.EventHandler(this.txtSLPhong_TextChanged);
            // 
            // lbNgayHomNay
            // 
            this.lbNgayHomNay.AutoSize = true;
            this.lbNgayHomNay.Location = new System.Drawing.Point(9, 451);
            this.lbNgayHomNay.Name = "lbNgayHomNay";
            this.lbNgayHomNay.Size = new System.Drawing.Size(0, 17);
            this.lbNgayHomNay.TabIndex = 26;
            // 
            // flpChonPhong
            // 
            this.flpChonPhong.Location = new System.Drawing.Point(6, 60);
            this.flpChonPhong.Name = "flpChonPhong";
            this.flpChonPhong.Size = new System.Drawing.Size(391, 187);
            this.flpChonPhong.TabIndex = 22;
            this.flpChonPhong.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flpChonPhong_MouseDown);
            // 
            // flpPhongDaChon
            // 
            this.flpPhongDaChon.Location = new System.Drawing.Point(13, 284);
            this.flpPhongDaChon.Name = "flpPhongDaChon";
            this.flpPhongDaChon.Size = new System.Drawing.Size(384, 182);
            this.flpPhongDaChon.TabIndex = 23;
            this.flpPhongDaChon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flpPhongDaChon_MouseMove);
            // 
            // frmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(442, 600);
            this.Controls.Add(this.grbTongTien);
            this.Controls.Add(this.grbThongTinPhong);
            this.Controls.Add(this.grbThongTinDatPhong);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatPhong";
            this.Text = "Đặt Phòng";
            this.Load += new System.EventHandler(this.frmDatPhong_Load);
            this.grbThongTinDatPhong.ResumeLayout(false);
            this.grbThongTinDatPhong.PerformLayout();
            this.grbThongTinPhong.ResumeLayout(false);
            this.grbThongTinPhong.PerformLayout();
            this.grbTongTien.ResumeLayout(false);
            this.grbTongTien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox grbThongTinDatPhong;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox grbThongTinPhong;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RadioButton radPhongVIP;
        private System.Windows.Forms.RadioButton radPhongDoi;
        private System.Windows.Forms.RadioButton radPhongDon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbTongTien;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Button btnDV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSLPhong;
        private System.Windows.Forms.Label lbNgayHomNay;
        private System.Windows.Forms.FlowLayoutPanel flpChonPhong;
        private System.Windows.Forms.FlowLayoutPanel flpPhongDaChon;
    }
}