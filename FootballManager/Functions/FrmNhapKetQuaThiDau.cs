using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FootballManager.Functions
{
    public partial class FrmNhapKetQuaThiDau : Form
    {
        /// <summary>
        /// Chuỗi kết nối
        /// Lấy từ cấu hình (settings) của Project
        /// </summary>
        string connectionString = FootballManager.Properties.Settings.Default.FootballManagerConnectionString;

        public FrmNhapKetQuaThiDau()
        {
            InitializeComponent();
        }

        public void BangDiemThiDau()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = "SELECT * FROM BangDiemThiDau";

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

        private void FrmNhapKetQuaThiDau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'footballManagerDataSet.BangDiemThiDau' table. You can move, or remove it, as needed.
            this.bangDiemThiDauTableAdapter.Fill(this.footballManagerDataSet.BangDiemThiDau);
            BangDiemThiDau();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(tenBangComboBox.Text) || String.IsNullOrEmpty(tenDoiComboBox.Text) ||
                String.IsNullOrEmpty(tenDoiDoiThuComboBox.Text) || String.IsNullOrEmpty(tenBangComboBox.Text) ||
                String.IsNullOrEmpty(tenBangComboBox.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập");
                return;
            }

            String doiA = tenDoiComboBox.Text;
            String doiB = tenDoiDoiThuComboBox.Text;

            string Str  = tiSoTextBox.Text;
            string Str1 = Str.Split('-')[0];
            string Str2 = Str.Split('-')[1];
            string tisodao = Str2 + '-' + Str1;

            int hieuso1 = Convert.ToInt32(Str1) - Convert.ToInt32(Str2);
            int hieuso2 = Convert.ToInt32(Str2) - Convert.ToInt32(Str1);
            int diem1, diem2;
            if (hieuso1 == hieuso2)
            {
                diem1 = 1;
                diem2 = 1;
            }
            else if (hieuso1 > hieuso2)
            {
                diem1 = 3;
                diem2 = 0;
            }
            else if (hieuso1 < hieuso2)
            {
                diem1 = 0;
                diem2 = 3;
            }
            else
            {
                diem1 = diem2 = 0;
            }

            // Tạo câu lệnh để thực thi đến database
            string queryInsert = @"INSERT INTO BangDiemThiDau([TenBang], [TenDoi], [TenDoiDoiThu], [SoTranDaThiDau], [TiSo], [HieuSo], [Diem]) VALUES(@tenbang, @tendoi, @tendoidoithu, @sotrandathidau, @tiso, @hieuso, @diem)";

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryInsert, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Truyền dữ liệu vào đúng tham số


                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@tenbang", tenBangComboBox.Text);
                        command.Parameters.AddWithValue("@tendoi", doiA);
                        command.Parameters.AddWithValue("@tendoidoithu", doiB);
                        command.Parameters.AddWithValue("@tiso", tiSoTextBox.Text);
                        command.Parameters.AddWithValue("@sotrandathidau", 1);
                        command.Parameters.AddWithValue("@hieuso", hieuso1);
                        command.Parameters.AddWithValue("@diem", diem1);

                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();


                        // Ngắt kết nối đến Database Server
                        connection.Close();

                        // Load lại danh sách cấu hình
                        BangDiemThiDau();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            string queryInsert1 = @"INSERT INTO BangDiemThiDau([TenBang], [TenDoi], [TenDoiDoiThu], [SoTranDaThiDau], [TiSo], [HieuSo], [Diem]) VALUES(@tenbang, @tendoi, @tendoidoithu, @sotrandathidau, @tiso, @hieuso, @diem)";
            using (SqlConnection connection1 = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command1 = new SqlCommand(queryInsert1, connection1))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection1.Open();

                        // Truyền dữ liệu vào đúng tham số

                        //string Str = tiSoTextBox.Text;
                        //string Str1 = Str.Split('-')[0];
                        //string Str2 = Str.Split('-')[1];
                        //string tisodao = Str2 + '-' + Str1;
                        //int hieuso1 = Convert.ToInt32(Str1);
                        //int hieuso2 = Convert.ToInt32(Str2);
                        //int diem1, diem2;
                        //if (hieuso1 == hieuso2)
                        //{
                        //    diem1 = 1;
                        //    diem2 = 1;
                        //}
                        //else
                        //{
                        //    diem1 = hieuso1;
                        //    diem2 = hieuso2;
                        //}

                        command1.CommandType = CommandType.Text;
                        command1.Parameters.AddWithValue("@tenbang", tenBangComboBox.Text);
                        command1.Parameters.AddWithValue("@tendoi", doiB);
                        command1.Parameters.AddWithValue("@tendoidoithu", doiA);
                        command1.Parameters.AddWithValue("@tiso", tisodao);
                        command1.Parameters.AddWithValue("@sotrandathidau", 1);
                        command1.Parameters.AddWithValue("@hieuso", hieuso2);
                        command1.Parameters.AddWithValue("@diem", diem2);

                        // Thực thi câu lệnh
                        int effect = command1.ExecuteNonQuery();


                        // Ngắt kết nối đến Database Server
                        connection1.Close();

                        // Load lại danh sách cấu hình
                        BangDiemThiDau();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        
    }
}
