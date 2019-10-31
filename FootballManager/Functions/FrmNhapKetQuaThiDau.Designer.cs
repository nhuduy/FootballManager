namespace FootballManager.Functions
{
    partial class FrmNhapKetQuaThiDau
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
            System.Windows.Forms.Label tenBangLabel;
            System.Windows.Forms.Label tenDoiLabel;
            System.Windows.Forms.Label tenDoiDoiThuLabel;
            System.Windows.Forms.Label tiSoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhapKetQuaThiDau));
            System.Windows.Forms.Label label1;
            this.imgNhapKetQuaThiDau = new System.Windows.Forms.PictureBox();
            this.footballManagerDataSet = new FootballManager.FootballManagerDataSet();
            this.bangDiemThiDauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangDiemThiDauTableAdapter = new FootballManager.FootballManagerDataSetTableAdapters.BangDiemThiDauTableAdapter();
            this.tableAdapterManager = new FootballManager.FootballManagerDataSetTableAdapters.TableAdapterManager();
            this.tenBangComboBox = new System.Windows.Forms.ComboBox();
            this.tenDoiComboBox = new System.Windows.Forms.ComboBox();
            this.tenDoiDoiThuComboBox = new System.Windows.Forms.ComboBox();
            this.tiSoTextBox = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            tenBangLabel = new System.Windows.Forms.Label();
            tenDoiLabel = new System.Windows.Forms.Label();
            tenDoiDoiThuLabel = new System.Windows.Forms.Label();
            tiSoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgNhapKetQuaThiDau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tenBangLabel
            // 
            tenBangLabel.AutoSize = true;
            tenBangLabel.Location = new System.Drawing.Point(82, 456);
            tenBangLabel.Name = "tenBangLabel";
            tenBangLabel.Size = new System.Drawing.Size(68, 25);
            tenBangLabel.TabIndex = 2;
            tenBangLabel.Text = "Bảng:";
            // 
            // tenDoiLabel
            // 
            tenDoiLabel.AutoSize = true;
            tenDoiLabel.Location = new System.Drawing.Point(245, 507);
            tenDoiLabel.Name = "tenDoiLabel";
            tenDoiLabel.Size = new System.Drawing.Size(64, 25);
            tenDoiLabel.TabIndex = 4;
            tenDoiLabel.Text = "Đội A";
            // 
            // tenDoiDoiThuLabel
            // 
            tenDoiDoiThuLabel.AutoSize = true;
            tenDoiDoiThuLabel.Location = new System.Drawing.Point(467, 507);
            tenDoiDoiThuLabel.Name = "tenDoiDoiThuLabel";
            tenDoiDoiThuLabel.Size = new System.Drawing.Size(64, 25);
            tenDoiDoiThuLabel.TabIndex = 6;
            tenDoiDoiThuLabel.Text = "Đội B";
            // 
            // tiSoLabel
            // 
            tiSoLabel.AutoSize = true;
            tiSoLabel.Location = new System.Drawing.Point(82, 602);
            tiSoLabel.Name = "tiSoLabel";
            tiSoLabel.Size = new System.Drawing.Size(65, 25);
            tiSoLabel.TabIndex = 8;
            tiSoLabel.Text = "Tỉ số:";
            // 
            // imgNhapKetQuaThiDau
            // 
            this.imgNhapKetQuaThiDau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgNhapKetQuaThiDau.Image = ((System.Drawing.Image)(resources.GetObject("imgNhapKetQuaThiDau.Image")));
            this.imgNhapKetQuaThiDau.Location = new System.Drawing.Point(12, 12);
            this.imgNhapKetQuaThiDau.Name = "imgNhapKetQuaThiDau";
            this.imgNhapKetQuaThiDau.Size = new System.Drawing.Size(655, 425);
            this.imgNhapKetQuaThiDau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNhapKetQuaThiDau.TabIndex = 1;
            this.imgNhapKetQuaThiDau.TabStop = false;
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
            // bangDiemThiDauTableAdapter
            // 
            this.bangDiemThiDauTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangDiemThiDauTableAdapter = this.bangDiemThiDauTableAdapter;
            this.tableAdapterManager.UpdateOrder = FootballManager.FootballManagerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tenBangComboBox
            // 
            this.tenBangComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bangDiemThiDauBindingSource, "TenBang", true));
            this.tenBangComboBox.FormattingEnabled = true;
            this.tenBangComboBox.Location = new System.Drawing.Point(199, 453);
            this.tenBangComboBox.Name = "tenBangComboBox";
            this.tenBangComboBox.Size = new System.Drawing.Size(366, 33);
            this.tenBangComboBox.TabIndex = 3;
            // 
            // tenDoiComboBox
            // 
            this.tenDoiComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bangDiemThiDauBindingSource, "TenDoi", true));
            this.tenDoiComboBox.FormattingEnabled = true;
            this.tenDoiComboBox.Location = new System.Drawing.Point(199, 537);
            this.tenDoiComboBox.Name = "tenDoiComboBox";
            this.tenDoiComboBox.Size = new System.Drawing.Size(141, 33);
            this.tenDoiComboBox.TabIndex = 5;
            // 
            // tenDoiDoiThuComboBox
            // 
            this.tenDoiDoiThuComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bangDiemThiDauBindingSource, "TenDoiDoiThu", true));
            this.tenDoiDoiThuComboBox.FormattingEnabled = true;
            this.tenDoiDoiThuComboBox.Location = new System.Drawing.Point(424, 537);
            this.tenDoiDoiThuComboBox.Name = "tenDoiDoiThuComboBox";
            this.tenDoiDoiThuComboBox.Size = new System.Drawing.Size(141, 33);
            this.tenDoiDoiThuComboBox.TabIndex = 7;
            // 
            // tiSoTextBox
            // 
            this.tiSoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bangDiemThiDauBindingSource, "TiSo", true));
            this.tiSoTextBox.Location = new System.Drawing.Point(199, 599);
            this.tiSoTextBox.Name = "tiSoTextBox";
            this.tiSoTextBox.Size = new System.Drawing.Size(366, 31);
            this.tiSoTextBox.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(199, 660);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(366, 55);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(82, 540);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 25);
            label1.TabIndex = 2;
            label1.Text = "Đội:";
            // 
            // FrmNhapKetQuaThiDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 738);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(tiSoLabel);
            this.Controls.Add(this.tiSoTextBox);
            this.Controls.Add(tenDoiDoiThuLabel);
            this.Controls.Add(this.tenDoiDoiThuComboBox);
            this.Controls.Add(tenDoiLabel);
            this.Controls.Add(this.tenDoiComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(tenBangLabel);
            this.Controls.Add(this.tenBangComboBox);
            this.Controls.Add(this.imgNhapKetQuaThiDau);
            this.Name = "FrmNhapKetQuaThiDau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập kết quả thi đấu";
            this.Load += new System.EventHandler(this.FrmNhapKetQuaThiDau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgNhapKetQuaThiDau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgNhapKetQuaThiDau;
        private FootballManagerDataSet footballManagerDataSet;
        private System.Windows.Forms.BindingSource bangDiemThiDauBindingSource;
        private FootballManagerDataSetTableAdapters.BangDiemThiDauTableAdapter bangDiemThiDauTableAdapter;
        private FootballManagerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox tenBangComboBox;
        private System.Windows.Forms.ComboBox tenDoiComboBox;
        private System.Windows.Forms.ComboBox tenDoiDoiThuComboBox;
        private System.Windows.Forms.TextBox tiSoTextBox;
        private System.Windows.Forms.Button btnThem;
    }
}