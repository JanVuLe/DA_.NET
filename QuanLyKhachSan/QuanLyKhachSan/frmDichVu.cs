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

        private void frmDichVu_Load(object sender, EventArgs e)
        {

        }
        public int TongDV;
        public int sldv;
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int com = int.Parse(txtCom.Text);
            int mi = int.Parse(txtMi.Text);
            int traicay = int.Parse(txtTraiCay.Text);
            int snack = int.Parse(txtSnack.Text);
            int ruou = int.Parse(txtRuou.Text);
            int sting = int.Parse(txtSting.Text);
            int mirinda = int.Parse(txtMirinda.Text);
            int coca = int.Parse(txtCocaCola.Text);
            int olong = int.Parse(txtOLong.Text);

            if (txtCom.Text == "")
                com = 0;
            if (txtMi.Text == "")
                mi = 0;
            if (txtTraiCay.Text == "")
                traicay = 0;
            if (txtSnack.Text == "")
                snack = 0;
            if (txtRuou.Text == "")
                ruou = 0;
            if (txtSting.Text == "")
                sting = 0;
            if (txtMirinda.Text == "")
                mirinda = 0;
            if (txtCocaCola.Text == "")
                coca = 0;
            if (txtOLong.Text == "")
                olong = 0;

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
        }
    }
}
