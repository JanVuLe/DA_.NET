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
    public partial class frmKhachDP : Form
    {
        public frmKhachDP()
        {
            InitializeComponent();
        }
        int n, k;

        private void frmKhachDP_Load(object sender, EventArgs e)
        {

        }

        private void btnNhapN_Click(object sender, EventArgs e)
        {
            n = int.Parse(txtNhap.Text);
            txtNhap.Enabled = false;
            btnNhapN.Enabled = false;
            grbThongtin.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            k++;
            if (k == n)
                btnDone.Enabled = true;
            //sql

            xoadl();
        }
        void xoadl()
        {
            txtTen.Text = "";
            txtSDT.Text = "";
            txtQuocTich.Text = "";
            txtNamSinh.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtCCCD.Text = "";
            rdbNu.Checked = false;
            rdbNam.Checked = false;
        }
    }
}
