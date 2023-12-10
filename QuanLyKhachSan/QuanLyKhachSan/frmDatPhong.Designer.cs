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
            radPhongVIP = new RadioButton();
            radPhongDoi = new RadioButton();
            radPhongDon = new RadioButton();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSoNguoi = new TextBox();
            label8 = new Label();
            label9 = new Label();
            btnNext2 = new Button();
            btnHuy = new Button();
            grbThongTinDatPhong = new GroupBox();
            label6 = new Label();
            btnDV = new Button();
            dtpNgayDi = new DateTimePicker();
            dtpNgayDen = new DateTimePicker();
            btnNext = new Button();
            txtSLPhong = new TextBox();
            label11 = new Label();
            grbThongTinPhong = new GroupBox();
            lbSLNguoi = new Label();
            lbNgayOLai = new Label();
            lbSLP = new Label();
            lbLoaiphong = new Label();
            flpChonPhong = new FlowLayoutPanel();
            btnBack = new Button();
            label12 = new Label();
            grbHoaDon = new GroupBox();
            btnThemPhong = new Button();
            btnXacNhan = new Button();
            lbThanhTien = new Label();
            grbThongTinDatPhong.SuspendLayout();
            grbThongTinPhong.SuspendLayout();
            grbHoaDon.SuspendLayout();
            SuspendLayout();
            // 
            // radPhongVIP
            // 
            radPhongVIP.AllowDrop = true;
            radPhongVIP.AutoSize = true;
            radPhongVIP.Location = new Point(312, 331);
            radPhongVIP.Name = "radPhongVIP";
            radPhongVIP.Size = new Size(92, 21);
            radPhongVIP.TabIndex = 13;
            radPhongVIP.Text = "Phòng VIP";
            radPhongVIP.UseVisualStyleBackColor = true;
            radPhongVIP.CheckedChanged += radPhongVIP_CheckedChanged;
            // 
            // radPhongDoi
            // 
            radPhongDoi.AllowDrop = true;
            radPhongDoi.AutoSize = true;
            radPhongDoi.Location = new Point(218, 331);
            radPhongDoi.Name = "radPhongDoi";
            radPhongDoi.Size = new Size(92, 21);
            radPhongDoi.TabIndex = 13;
            radPhongDoi.Text = "Phòng Đôi";
            radPhongDoi.UseVisualStyleBackColor = true;
            radPhongDoi.CheckedChanged += radPhongDoi_CheckedChanged;
            // 
            // radPhongDon
            // 
            radPhongDon.AllowDrop = true;
            radPhongDon.AutoSize = true;
            radPhongDon.Location = new Point(115, 331);
            radPhongDon.Name = "radPhongDon";
            radPhongDon.Size = new Size(97, 21);
            radPhongDon.TabIndex = 12;
            radPhongDon.Text = "Phòng Đơn";
            radPhongDon.UseVisualStyleBackColor = true;
            radPhongDon.CheckedChanged += radPhongDon_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 26);
            label1.TabIndex = 1;
            label1.Text = "Đặt Phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 105);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 3;
            label3.Text = "Ngày Đến";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(112, 37);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 2;
            label2.Text = "Thông Tin Đặt Phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 163);
            label4.Name = "label4";
            label4.Size = new Size(58, 17);
            label4.TabIndex = 5;
            label4.Text = "Ngày Đi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 226);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 7;
            label5.Text = "Số Người";
            // 
            // txtSoNguoi
            // 
            txtSoNguoi.Location = new Point(120, 223);
            txtSoNguoi.Name = "txtSoNguoi";
            txtSoNguoi.Size = new Size(261, 23);
            txtSoNguoi.TabIndex = 8;
            txtSoNguoi.TextChanged += txtSoNguoi_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(136, 19);
            label8.Name = "label8";
            label8.Size = new Size(144, 20);
            label8.TabIndex = 14;
            label8.Text = "Thông Tin Phòng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 40);
            label9.Name = "label9";
            label9.Size = new Size(86, 17);
            label9.TabIndex = 15;
            label9.Text = "Chọn Phòng";
            // 
            // btnNext2
            // 
            btnNext2.BackColor = Color.Chartreuse;
            btnNext2.FlatStyle = FlatStyle.Popup;
            btnNext2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext2.ForeColor = SystemColors.Highlight;
            btnNext2.Location = new Point(255, 383);
            btnNext2.Name = "btnNext2";
            btnNext2.Size = new Size(106, 50);
            btnNext2.TabIndex = 19;
            btnNext2.Text = "Tiếp Theo";
            btnNext2.UseVisualStyleBackColor = false;
            btnNext2.Click += btnSave_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Salmon;
            btnHuy.DialogResult = DialogResult.Cancel;
            btnHuy.FlatStyle = FlatStyle.Popup;
            btnHuy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy.ForeColor = SystemColors.Highlight;
            btnHuy.Location = new Point(321, 421);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(88, 37);
            btnHuy.TabIndex = 20;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // grbThongTinDatPhong
            // 
            grbThongTinDatPhong.Controls.Add(label6);
            grbThongTinDatPhong.Controls.Add(btnDV);
            grbThongTinDatPhong.Controls.Add(dtpNgayDi);
            grbThongTinDatPhong.Controls.Add(dtpNgayDen);
            grbThongTinDatPhong.Controls.Add(label2);
            grbThongTinDatPhong.Controls.Add(label3);
            grbThongTinDatPhong.Controls.Add(btnNext);
            grbThongTinDatPhong.Controls.Add(label4);
            grbThongTinDatPhong.Controls.Add(label5);
            grbThongTinDatPhong.Controls.Add(txtSLPhong);
            grbThongTinDatPhong.Controls.Add(txtSoNguoi);
            grbThongTinDatPhong.Controls.Add(radPhongVIP);
            grbThongTinDatPhong.Controls.Add(radPhongDoi);
            grbThongTinDatPhong.Controls.Add(radPhongDon);
            grbThongTinDatPhong.Controls.Add(label11);
            grbThongTinDatPhong.Location = new Point(12, 54);
            grbThongTinDatPhong.Name = "grbThongTinDatPhong";
            grbThongTinDatPhong.Size = new Size(415, 467);
            grbThongTinDatPhong.TabIndex = 21;
            grbThongTinDatPhong.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 284);
            label6.Name = "label6";
            label6.Size = new Size(114, 17);
            label6.TabIndex = 22;
            label6.Text = "Số Lượng Phòng";
            // 
            // btnDV
            // 
            btnDV.BackColor = Color.Cyan;
            btnDV.Location = new Point(290, 403);
            btnDV.Name = "btnDV";
            btnDV.Size = new Size(114, 30);
            btnDV.TabIndex = 21;
            btnDV.Text = "Thêm Dịch Vụ";
            btnDV.UseVisualStyleBackColor = false;
            btnDV.Click += btnDV_Click;
            // 
            // dtpNgayDi
            // 
            dtpNgayDi.Format = DateTimePickerFormat.Short;
            dtpNgayDi.Location = new Point(120, 163);
            dtpNgayDi.Name = "dtpNgayDi";
            dtpNgayDi.Size = new Size(261, 23);
            dtpNgayDi.TabIndex = 20;
            // 
            // dtpNgayDen
            // 
            dtpNgayDen.Format = DateTimePickerFormat.Short;
            dtpNgayDen.Location = new Point(120, 100);
            dtpNgayDen.Name = "dtpNgayDen";
            dtpNgayDen.Size = new Size(261, 23);
            dtpNgayDen.TabIndex = 20;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Chartreuse;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = SystemColors.Highlight;
            btnNext.Location = new Point(152, 403);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(106, 50);
            btnNext.TabIndex = 19;
            btnNext.Text = "Tiếp Theo";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // txtSLPhong
            // 
            txtSLPhong.Location = new Point(135, 281);
            txtSLPhong.Name = "txtSLPhong";
            txtSLPhong.Size = new Size(246, 23);
            txtSLPhong.TabIndex = 8;
            txtSLPhong.TextChanged += txtSLPhong_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 333);
            label11.Name = "label11";
            label11.Size = new Size(80, 17);
            label11.TabIndex = 11;
            label11.Text = "Loại Phòng";
            // 
            // grbThongTinPhong
            // 
            grbThongTinPhong.Controls.Add(lbSLNguoi);
            grbThongTinPhong.Controls.Add(lbNgayOLai);
            grbThongTinPhong.Controls.Add(lbSLP);
            grbThongTinPhong.Controls.Add(lbLoaiphong);
            grbThongTinPhong.Controls.Add(flpChonPhong);
            grbThongTinPhong.Controls.Add(label9);
            grbThongTinPhong.Controls.Add(btnBack);
            grbThongTinPhong.Controls.Add(btnNext2);
            grbThongTinPhong.Controls.Add(label8);
            grbThongTinPhong.Location = new Point(456, 54);
            grbThongTinPhong.Name = "grbThongTinPhong";
            grbThongTinPhong.Size = new Size(415, 467);
            grbThongTinPhong.TabIndex = 22;
            grbThongTinPhong.TabStop = false;
            // 
            // lbSLNguoi
            // 
            lbSLNguoi.AutoSize = true;
            lbSLNguoi.Location = new Point(17, 169);
            lbSLNguoi.Name = "lbSLNguoi";
            lbSLNguoi.Size = new Size(0, 17);
            lbSLNguoi.TabIndex = 28;
            // 
            // lbNgayOLai
            // 
            lbNgayOLai.AutoSize = true;
            lbNgayOLai.Location = new Point(17, 138);
            lbNgayOLai.Name = "lbNgayOLai";
            lbNgayOLai.Size = new Size(0, 17);
            lbNgayOLai.TabIndex = 27;
            // 
            // lbSLP
            // 
            lbSLP.AutoSize = true;
            lbSLP.Location = new Point(17, 106);
            lbSLP.Name = "lbSLP";
            lbSLP.Size = new Size(0, 17);
            lbSLP.TabIndex = 26;
            // 
            // lbLoaiphong
            // 
            lbLoaiphong.AutoSize = true;
            lbLoaiphong.Location = new Point(17, 75);
            lbLoaiphong.Name = "lbLoaiphong";
            lbLoaiphong.Size = new Size(0, 17);
            lbLoaiphong.TabIndex = 25;
            // 
            // flpChonPhong
            // 
            flpChonPhong.BackColor = Color.DimGray;
            flpChonPhong.Location = new Point(6, 218);
            flpChonPhong.Name = "flpChonPhong";
            flpChonPhong.Size = new Size(400, 159);
            flpChonPhong.TabIndex = 24;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Yellow;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.Highlight;
            btnBack.Location = new Point(49, 383);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(106, 50);
            btnBack.TabIndex = 19;
            btnBack.Text = "Trở Lại";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Highlight;
            label12.Location = new Point(160, 34);
            label12.Name = "label12";
            label12.Size = new Size(106, 23);
            label12.TabIndex = 23;
            label12.Text = "Thành Tiền";
            // 
            // grbHoaDon
            // 
            grbHoaDon.Controls.Add(btnThemPhong);
            grbHoaDon.Controls.Add(btnHuy);
            grbHoaDon.Controls.Add(btnXacNhan);
            grbHoaDon.Controls.Add(lbThanhTien);
            grbHoaDon.Controls.Add(label12);
            grbHoaDon.Location = new Point(877, 54);
            grbHoaDon.Name = "grbHoaDon";
            grbHoaDon.Size = new Size(415, 467);
            grbHoaDon.TabIndex = 24;
            grbHoaDon.TabStop = false;
            grbHoaDon.Text = "Hóa Đơn";
            // 
            // btnThemPhong
            // 
            btnThemPhong.BackColor = Color.Chartreuse;
            btnThemPhong.Location = new Point(0, 418);
            btnThemPhong.Name = "btnThemPhong";
            btnThemPhong.Size = new Size(103, 43);
            btnThemPhong.TabIndex = 25;
            btnThemPhong.Text = "Thêm Phòng";
            btnThemPhong.UseVisualStyleBackColor = false;
            btnThemPhong.Click += btnThemPhong_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.Chartreuse;
            btnXacNhan.Location = new Point(163, 418);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(103, 43);
            btnXacNhan.TabIndex = 25;
            btnXacNhan.Text = "Xác Nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // lbThanhTien
            // 
            lbThanhTien.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbThanhTien.Location = new Point(6, 75);
            lbThanhTien.Name = "lbThanhTien";
            lbThanhTien.Size = new Size(403, 340);
            lbThanhTien.TabIndex = 24;
            lbThanhTien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmDatPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 536);
            Controls.Add(grbHoaDon);
            Controls.Add(grbThongTinPhong);
            Controls.Add(grbThongTinDatPhong);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmDatPhong";
            Text = "Đặt Phòng";
            Load += frmDatPhong_Load;
            grbThongTinDatPhong.ResumeLayout(false);
            grbThongTinDatPhong.PerformLayout();
            grbThongTinPhong.ResumeLayout(false);
            grbThongTinPhong.PerformLayout();
            grbHoaDon.ResumeLayout(false);
            grbHoaDon.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtSoNguoi;
        private Label label8;
        private Label label9;
        private Button btnNext2;
        private Button btnHuy;
        private GroupBox grbThongTinDatPhong;
        private Button btnNext;
        private GroupBox grbThongTinPhong;
        private Button btnBack;
        private Label label11;
        private Label label12;
        private GroupBox grbHoaDon;
        private Label lbThanhTien;
        private Button btnXacNhan;
        private DateTimePicker dtpNgayDi;
        private DateTimePicker dtpNgayDen;
        private Button btnThemPhong;
        private Button btnDV;
        private Label label6;
        private TextBox txtSLPhong;
        private RadioButton radPhongVIP;
        private RadioButton radPhongDoi;
        private RadioButton radPhongDon;
        private FlowLayoutPanel flpChonPhong;
        private Label lbLoaiphong;
        private Label lbSLP;
        private Label lbSLNguoi;
        private Label lbNgayOLai;
    }
}