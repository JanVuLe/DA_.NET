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
    public partial class frmDichVu : Form
    {
        public frmDichVu()
        {
            InitializeComponent();
        }

        public int TongDV;
        public int sldv;
        public string chitietdv;
        private void frmDichVu_Load(object sender, EventArgs e)
        {

        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int com, mi, traicay, snack, ruou, sting, mirinda, coca, olong;

            if (txtCom.Text == "")
                com = 0;
            else
            {
                chitietdv += "Cơm Phần";
                com = int.Parse(txtCom.Text);
            }    

            if (txtMi.Text == "")
                mi = 0;
            else
            {
                chitietdv += ", Mì Ý";
                mi = int.Parse(txtMi.Text);
            }

            if (txtTraiCay.Text == "")
                traicay = 0;
            else
            {
                chitietdv += ", Trái Cây";
                traicay = int.Parse(txtTraiCay.Text);
            }

            if (txtSnack.Text == "")
                snack = 0;
            else
            {
                chitietdv += ", Snack";
                snack = int.Parse(txtSnack.Text);
            }

            if (txtRuou.Text == "")
                ruou = 0;
            else
            {
                chitietdv += ", Rượu Vang";
                ruou = int.Parse(txtRuou.Text);
            }

            if (txtSting.Text == "")
                sting = 0;
            else
            {
                chitietdv += ", Sting";
                sting = int.Parse(txtSting.Text);
            }

            if (txtMirinda.Text == "")
                mirinda = 0;
            else
            {
                chitietdv += ", Mirinda";
                mirinda = int.Parse(txtMirinda.Text);
            }

            if (txtCocaCola.Text == "")
                coca = 0;
            else
            {
                chitietdv += ", Coca cola";
                coca = int.Parse(txtCocaCola.Text);
            }

            if (txtOLong.Text == "")
                olong = 0;
            else
            {
                chitietdv += ", Trà Ô Long";
                olong = int.Parse(txtOLong.Text);
            }

            sldv = com + mi + traicay + snack + ruou + sting + mirinda + coca + olong;

            com *= 100;
            mi *= 80;
            traicay *= 20;
            snack *= 5;
            ruou *= 200;
            sting *= 10;
            mirinda *= 10;
            coca *= 10;
            olong *= 10;

            TongDV = com + mi + traicay + snack + ruou + sting + mirinda + coca + olong;

            this.Close();
        }
    }
}
