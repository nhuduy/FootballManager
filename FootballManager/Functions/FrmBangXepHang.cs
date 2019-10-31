using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FootballManager.Functions
{
    public partial class FrmBangXepHang : Form
    {
        /// <summary>
        /// Chuỗi kết nối
        /// Lấy từ cấu hình (settings) của Project
        /// </summary>
        string connectionString = FootballManager.Properties.Settings.Default.FootballManagerConnectionString;

        public FrmBangXepHang()
        {
            InitializeComponent();
        }

        private void FrmBangXepHang_Load(object sender, EventArgs e)
        {
            LoadBangKetQua();
        }

        // Hàm xử lý
        private void LoadBangKetQua()
        {

            // Tạo câu lệnh để thực thi đến database
            string queryString = @"select [TenDoi], sum([SoTranDaThiDau]) as SoTranDaDau, sum(HieuSo) as HieuSo, sum([Diem]) as TongDiem from BangDiemThiDau group by [TenDoi] order by sum([Diem]) desc, sum(HieuSo) desc";

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        footballManagerDataSet.BangDiemThiDau.Clear();
                        adapter.Fill(footballManagerDataSet.BangDiemThiDau);
                        int i = 1;
                        foreach (DataRow row in footballManagerDataSet.BangDiemThiDau.Rows)
                        {
                            row["Stt"] = i;
                            i++;
                        }

                        // Hiển thị dữ liệu
                        bangDiemThiDauBindingSource.DataSource = footballManagerDataSet.BangDiemThiDau;
                        bangDiemThiDauDataGridView.DataSource = bangDiemThiDauBindingSource;

                        bangDiemThiDauDataGridView.Refresh();

                        // Ngắt kết nối đến Database Server
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void bangDiemThiDauBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bangDiemThiDauBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.footballManagerDataSet);

        }

        // Chức năng button
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThongKeXepHang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang xem Thống kê xếp hạng");
        }
    }
}
