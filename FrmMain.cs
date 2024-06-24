using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_DETHITHU
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string hovaten = "Trần Lê Thanh Bảo";
            string mssv = "1234567890";
            string monthi = "Lập trình Windows 2 - C#";

            lblInfo.Text = "Họ và tên: " + hovaten;
            lblInfo.Text = "\nMSSV: " + mssv;
            lblInfo.Text = "\nNgày thi: " + System.DateTime.Now.ToString();
            lblInfo.Text = "\nMôn thi: " + monthi;
        }

        private void giảiPhươngTrìnhBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giaiptbac2 giaiptbac2 = new Giaiptbac2();
            giaiptbac2.ShowDialog();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DinhDang dinhDang = new DinhDang();
            dinhDang.ShowDialog();
        }

        private void đăngKíMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangkimonhoc dangkimonhoc = new Dangkimonhoc();
            dangkimonhoc.ShowDialog();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình tiện ích", "Thông tin", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
