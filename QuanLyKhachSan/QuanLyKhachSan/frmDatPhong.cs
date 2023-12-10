using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmDatPhong : Form
    {
        public frmDatPhong()
        {
            InitializeComponent();
        }
        private List<Button> buttons;
        int[] mang = new int[30];
        public Button btn;
        int j = 0, NgayO, TienDV, slphong, k = 0;
        DateTime homnay = DateTime.Now;
        frmDichVu fdv = new frmDichVu();

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (DialogResult == DialogResult.Cancel) { this.Close(); }
        }
        public void AnGrb()
        {
            this.grbThongTinPhong.Visible = false;
            this.grbThongTinDatPhong.Visible = false;
            this.grbHoaDon.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DateTime ngaydi = this.dtpNgayDi.Value;
            DateTime ngayden = this.dtpNgayDen.Value;

            if (txtSLPhong.Text == "" || txtSoNguoi.Text == "" || ngayden > ngaydi || ngayden < homnay || (radPhongDoi.Checked == false && radPhongDon.Checked == false && radPhongVIP.Checked == false))
            {
                MessageBox.Show("Thông Tin Chưa Phù Hợp!\nNhập Lại!", "Thông Báo");
            }
            else
            {
                TimeSpan NgayThue = ngaydi - ngayden;
                NgayO = (int)NgayThue.TotalDays;
                slphong = int.Parse(txtSLPhong.Text);
                int slnguoi = int.Parse(txtSoNguoi.Text);
                AnGrb();
                this.grbThongTinPhong.Visible = true;
                this.grbThongTinPhong.Location = new Point(12, 54);

                lbSLP.Text = "Số lượng phòng đã đặt: " + slphong.ToString();
                lbSLNguoi.Text = "Số lượng người đã đặt: " + slnguoi.ToString();
                lbNgayOLai.Text = "Số ngày ở lại: " + NgayO.ToString();
                if (radPhongDon.Checked == true)
                {
                    buttons = new List<Button>();
                    for (int i = 0; i < 10; i++)
                    {
                        btn = new Button();
                        btn.Name = "10" + (1 + i.ToString());
                        btn.Size = new System.Drawing.Size(70, 70);
                        btn.Text = "10" + (i + 1).ToString();
                        btn.BackColor = Color.White;
                        if (i == 5)
                            btn.BackColor = Color.Red;
                        btn.TextAlign = ContentAlignment.TopLeft;
                        //btn.BorderStyle = BorderStyle.Fixed3D;
                        buttons.Add(btn);
                        flpChonPhong.Controls.Add(btn);
                        btn.Click += button_Click;
                    }
                    //Controls.Add(flpChonPhong);
                    lbLoaiphong.Text = "Loại Phòng: Phòng Đơn";
                }
                if (radPhongDoi.Checked == true)
                {
                    buttons = new List<Button>();
                    for (int i = 0; i < 10; i++)
                    {
                        btn = new Button();
                        btn.Name = "20" + (1 + i.ToString());
                        btn.Size = new System.Drawing.Size(70, 70);
                        btn.Text = "20" + (i + 1).ToString();
                        btn.BackColor = Color.White;
                        if (i == 1)
                            btn.BackColor = Color.Red;
                        btn.TextAlign = ContentAlignment.TopLeft;
                        //btn.BorderStyle = BorderStyle.Fixed3D;
                        buttons.Add(btn);
                        flpChonPhong.Controls.Add(btn);
                        btn.Click += button_Click;
                    }
                    //Controls.Add(flpChonPhong);
                    lbLoaiphong.Text = "Loại Phòng: Phòng Đôi";
                }
                if (radPhongVIP.Checked == true)
                {
                    buttons = new List<Button>();
                    for (int i = 0; i < 10; i++)
                    {
                        btn = new Button();
                        btn.Name = "30" + (1 + i.ToString());
                        btn.Size = new System.Drawing.Size(74, 74);
                        btn.Text = "30" + (i + 1).ToString();
                        btn.BackColor = Color.White;
                        if (i == 3)
                            btn.BackColor = Color.Red;
                        btn.TextAlign = ContentAlignment.TopLeft;
                        //btn.BorderStyle = BorderStyle.Fixed3D;
                        buttons.Add(btn);
                        flpChonPhong.Controls.Add(btn);
                        btn.Click += button_Click;
                    }
                    //Controls.Add(flpChonPhong);
                    lbLoaiphong.ForeColor = Color.DarkViolet;
                    lbLoaiphong.Text = "Loại Phòng: Phòng VIP";
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AnGrb();
            this.grbThongTinDatPhong.Visible = true;
            this.flpChonPhong.ResetText();
        }
        int sophongdat;
        private void frmDatPhong_Load(object sender, EventArgs e)
        {

        }
        void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.Cyan)
            {
                button.BackColor = Color.White;
                k--;
            }
            else if (k >= slphong)
            {
                MessageBox.Show("Số lượng đạt giới hạn!");
            }
            else if (button.BackColor == Color.White)
            {
                button.BackColor = Color.Cyan;
                k++;
            }
            else if (button.BackColor == Color.Red)
            {
                MessageBox.Show("Phòng này đã có người đặt");
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtSoNguoi_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSoNguoi.Text, "[^0-9]"))
            {
                MessageBox.Show("Chỉ Nhập Số!", "Thông Báo");
                txtSoNguoi.Text = txtSoNguoi.Text.Remove(txtSoNguoi.Text.Length - 1);
            }
        }

        private void txtSLPhong_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSLPhong.Text, "[^0-9]"))
            {
                MessageBox.Show("Chỉ Nhập Số!", "Thông Báo");
                txtSLPhong.Text = txtSLPhong.Text.Remove(txtSLPhong.Text.Length - 1);
            }
        }

        private void radPhongDon_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radPhongDoi_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radPhongVIP_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdbNu_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnDV_Click(object sender, EventArgs e)
        {
            fdv.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (k < slphong)
            {
                DialogResult dg = MessageBox.Show("Số lượng phòng chưa đủ, bạn muốn tiếp tục?", "Thông Báo", MessageBoxButtons.OKCancel);
                if (dg == DialogResult.OK)
                {
                    double tongtien = 0;
                    AnGrb();
                    this.grbHoaDon.Visible = true;
                    this.grbHoaDon.Location = new Point(12, 54);
                    TienDV = fdv.TongDV;
                    int sldv = fdv.sldv;
                    string ctdv = fdv.chitietdv;
                    if (radPhongDon.Checked == true)
                    {
                        tongtien += 250 * NgayO * slphong + TienDV;
                    }
                    if (radPhongDoi.Checked == true)
                    {
                        tongtien += 350 * NgayO * slphong + TienDV;
                    }
                    if (radPhongVIP.Checked == true)
                    {
                        tongtien += 600 * NgayO * slphong + TienDV;
                    }
                    lbThanhTien.Text = "Số Phòng Đã Đặt: " + slphong + "\nSố Ngày Ở: " + NgayO + "\nSố Lượng Dịch Vụ:  " + sldv + "\nChi Tiết Dịch Vụ: " + ctdv + "\nTổng Tiền: " + tongtien + "000 Đồng" + "\n\n\n\nNgày: " + homnay;

                }
            }
            else
            {
                double tongtien = 0;
                AnGrb();
                this.grbHoaDon.Visible = true;
                this.grbHoaDon.Location = new Point(12, 54);
                TienDV = fdv.TongDV;
                int sldv = fdv.sldv;
                string ctdv = fdv.chitietdv;
                if (radPhongDon.Checked == true)
                {
                    tongtien += 250 * NgayO * slphong + TienDV;
                }
                if (radPhongDoi.Checked == true)
                {
                    tongtien += 350 * NgayO * slphong + TienDV;
                }
                if (radPhongVIP.Checked == true)
                {
                    tongtien += 600 * NgayO * slphong + TienDV;
                }
                lbThanhTien.Text = "Số Phòng Đã Đặt: " + slphong + "\nSố Ngày Ở: " + NgayO + "\nSố Lượng Dịch Vụ:  " + sldv + "\nChi Tiết Dịch Vụ: " + ctdv + "\nTổng Tiền: " + tongtien + "000 Đồng" + "\n\n\n\nNgày: " + homnay;
            }
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            frmDatPhong fdp = new frmDatPhong();
            fdp.ShowDialog();
            this.Close();
        }

    }
}
