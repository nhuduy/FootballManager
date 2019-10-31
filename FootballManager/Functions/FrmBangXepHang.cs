using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FootballManager.Functions
{
    public partial class FrmBangXepHang : Form
    {
        public FrmBangXepHang()
        {
            InitializeComponent();
        }

        private void bangDiemThiDauBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bangDiemThiDauBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.footballManagerDataSet);

        }

        private void FrmBangXepHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'footballManagerDataSet.BangDiemThiDau' table. You can move, or remove it, as needed.
            this.bangDiemThiDauTableAdapter.Fill(this.footballManagerDataSet.BangDiemThiDau);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThongKeXepHang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang ở mở Thống kê xếp hạng");
        }

        private void bangDiemThiDauDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
