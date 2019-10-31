namespace FootballManager.Functions
{
    partial class FrmBangXepHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tenDoiDoiThuLabel;
            this.footballManagerDataSet = new FootballManager.FootballManagerDataSet();
            this.bangDiemThiDauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new FootballManager.FootballManagerDataSetTableAdapters.TableAdapterManager();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThongKeXepHang = new System.Windows.Forms.Button();
            this.bangDiemThiDauTableAdapter = new FootballManager.FootballManagerDataSetTableAdapters.BangDiemThiDauTableAdapter();
            this.bangDiemThiDauDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tenDoiDoiThuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.footballManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tenDoiDoiThuLabel
            // 
            tenDoiDoiThuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tenDoiDoiThuLabel.AutoSize = true;
            tenDoiDoiThuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenDoiDoiThuLabel.Location = new System.Drawing.Point(321, 22);
            tenDoiDoiThuLabel.Name = "tenDoiDoiThuLabel";
            tenDoiDoiThuLabel.Size = new System.Drawing.Size(529, 67);
            tenDoiDoiThuLabel.TabIndex = 7;
            tenDoiDoiThuLabel.Text = "BẢNG XẾP HẠNG";
            // 
            // footballManagerDataSet
            // 
            this.footballManagerDataSet.DataSetName = "FootballManagerDataSet";
            this.footballManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangDiemThiDauBindingSource
            // 
            this.bangDiemThiDauBindingSource.DataMember = "BangDiemThiDau";
            this.bangDiemThiDauBindingSource.DataSource = this.footballManagerDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangDiemThiDauTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = FootballManager.FootballManagerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(931, 592);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(246, 63);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThongKeXepHang
            // 
            this.btnThongKeXepHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThongKeXepHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeXepHang.Location = new System.Drawing.Point(479, 592);
            this.btnThongKeXepHang.Name = "btnThongKeXepHang";
            this.btnThongKeXepHang.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnThongKeXepHang.Size = new System.Drawing.Size(425, 63);
            this.btnThongKeXepHang.TabIndex = 2;
            this.btnThongKeXepHang.Text = "Thống kê xếp hạng";
            this.btnThongKeXepHang.UseVisualStyleBackColor = true;
            this.btnThongKeXepHang.Click += new System.EventHandler(this.btnThongKeXepHang_Click);
            // 
            // bangDiemThiDauTableAdapter
            // 
            this.bangDiemThiDauTableAdapter.ClearBeforeFill = true;
            // 
            // bangDiemThiDauDataGridView
            // 
            this.bangDiemThiDauDataGridView.AutoGenerateColumns = false;
            this.bangDiemThiDauDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangDiemThiDauDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.bangDiemThiDauDataGridView.DataSource = this.bangDiemThiDauBindingSource;
            this.bangDiemThiDauDataGridView.Location = new System.Drawing.Point(12, 108);
            this.bangDiemThiDauDataGridView.Name = "bangDiemThiDauDataGridView";
            this.bangDiemThiDauDataGridView.RowHeadersWidth = 82;
            this.bangDiemThiDauDataGridView.RowTemplate.Height = 33;
            this.bangDiemThiDauDataGridView.Size = new System.Drawing.Size(1165, 466);
            this.bangDiemThiDauDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "STT";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TenDoi";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên Đội";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TiSo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tỉ số";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SoTranDaThiDau";
            this.dataGridViewTextBoxColumn7.HeaderText = "Số trận đã đấu";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "HieuSo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Hiệu số";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Diem";
            this.dataGridViewTextBoxColumn9.HeaderText = "Điểm";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // FrmBangXepHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 667);
            this.Controls.Add(this.bangDiemThiDauDataGridView);
            this.Controls.Add(tenDoiDoiThuLabel);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThongKeXepHang);
            this.Name = "FrmBangXepHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng xếp hạng";
            this.Load += new System.EventHandler(this.FrmBangXepHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.footballManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FootballManagerDataSet footballManagerDataSet;
        private System.Windows.Forms.BindingSource bangDiemThiDauBindingSource;
        private FootballManagerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThongKeXepHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private FootballManagerDataSetTableAdapters.BangDiemThiDauTableAdapter bangDiemThiDauTableAdapter;
        private System.Windows.Forms.DataGridView bangDiemThiDauDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}