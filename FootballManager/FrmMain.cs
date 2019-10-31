using FootballManager.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FootballManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnNhapKetQuaThiDau_Click(object sender, EventArgs e)
        {
            FrmNhapKetQuaThiDau nhapKetQuaThiDau = new FrmNhapKetQuaThiDau();
            nhapKetQuaThiDau.Show();
        }

        private void btnBangXepHang_Click(object sender, EventArgs e)
        {
            FrmBangXepHang bangXepHang = new FrmBangXepHang();
            bangXepHang.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
