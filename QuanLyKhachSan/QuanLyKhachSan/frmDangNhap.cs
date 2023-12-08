using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtDangNhap.Text == "" || txtMatKhau.text == "")
                MessageBox.Show("Hãy nhập tài khoản!", "Thông báo");
            else
            {
                
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
