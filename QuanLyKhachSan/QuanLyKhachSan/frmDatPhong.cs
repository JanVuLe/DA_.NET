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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        int j = 0, NgayO, TienDV, slphong;
        string sp = "";
        DateTime homnay = DateTime.Now;
        frmDichVu fdv = new frmDichVu();

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(DialogResult == DialogResult.Cancel) { this.Close();}
        }
        public void AnGrb()
        {
            this.grbThongTinPhong.Visible = false;
            this.grbThongTinDatPhong.Visible = false;
            this.grbTongTien.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DateTime ngaydi = this.dtpNgayDi.Value;
            DateTime ngayden = this.dtpNgayDen.Value;
            TimeSpan NgayO = ngaydi - ngayden;
            if (txtSLPhong.Text == "" || txtSoNguoi.Text == "" || ngayden > ngaydi || ngayden < homnay)
            {
                MessageBox.Show("Thông Tin Chưa Phù Hợp!\nNhập Lại!", "Thông Báo");
                if(rdbNam.Checked == false && rdbNu.Checked == false)
            }
            else
            {
                AnGrb();
                this.grbThongTinPhong.Visible = true;
                this.grbThongTinPhong.Location = new Point(12, 54);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AnGrb();
            this.grbThongTinDatPhong.Visible = true;
        }
        int sophongdat;
        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            buttons = new List<Button>();
            for (int i = 0; i < 10; i++)
            {
                btn = new Button();
                btn.Name = "1" + i.ToString();
                btn.Size = new System.Drawing.Size(20, 20);
                btn.Text = (i + 1).ToString();
                btn.BackColor = Color.White;
                btn.TextAlign = ContentAlignment.TopLeft;
                btn.BorderStyle = BorderStyle.Fixed3D;
                buttons.Add(btn);
                flpChonPhong.Controls.Add(btn);
                btn.Click += button_Click;
            }
            Controls.Add(flpChonPhong);
        }
        void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.White)
            {
                button.BackColor = Color.Blue;
            }
            else if (button.BackColor == Color.Blue)
            {
                button.BackColor = Color.White;
            }
            else if (button.BackColor == Color.Red)
            {
                MessageBox.Show("Phòng này đã có người đặt");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                if (buttons[i].BackColor == Color.Blue)
                {
                    buttons[i].BackColor = Color.Red;
                    mang[j] = i + 1;
                    j++;
                    //Thêm btn
                    buttons = new List<Button>();
                    btn = new Button();
                    btn.Name = "" + i.ToString();
                    btn.Size = new System.Drawing.Size(20, 20);
                    btn.Text = (i + 1).ToString();
                    btn.BackColor = Color.Blue;
                    btn.TextAlign = ContentAlignment.TopLeft;
                    btn.BorderStyle = BorderStyle.Fixed3D;
                    buttons.Add(btn);
                    flpPhongDaChon.Controls.Add(btn);
                    btn.Click += button_Click;
                    Controls.Add(flpPhongDaChon);
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            rdbNu.Checked = false;
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
            radPhongDoi.Checked = false;
            radPhongVIP.Checked = false;
        }

        private void radPhongDoi_CheckedChanged(object sender, EventArgs e)
        {
            radPhongDon.Checked = false;
            radPhongVIP.Checked = false;
        }

        private void radPhongVIP_CheckedChanged(object sender, EventArgs e)
        {
            radPhongDoi.Checked = false;
            radPhongDon.Checked = false;
        }

        private void flpChonPhong_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void flpPhongDaChon_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void rdbNu_CheckedChanged(object sender, EventArgs e)
        {
            rdbNam.Checked = false;
        }

        private void btnDV_Click(object sender, EventArgs e)
        {
            fdv.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double tongtien = 0;
            AnGrb();
            this.grbTongTien.Visible = true;
            this.grbTongTien.Location = new Point(12,54);
            TienDV = fdv.TongDV;
            int sldv = fdv.sldv;
            for (int a = 0; a < j; a++)
            {
                if(radPhongDon.Checked == true)
                {
                    tongtien += 300 * NgayO + TienDV;
                }
                if (radPhongDoi.Checked == true)
                {
                    tongtien += 500 * NgayO + TienDV;
                }
                if (radPhongVIP.Checked == true)
                {
                    tongtien += 1000 * NgayO + TienDV;
                }
            }
            lbThanhTien.Text = "Số Phòng Đã Đặt: " + sp + "\nSố Ngày Ở: " + NgayO + "\nSố Lượng Dịch Vụ:  " + sldv + "\nTổng Tiền: " + tongtien;
            lbNgayHomNay.Text = "Ngày: " + homnay;
        }
    }
}
