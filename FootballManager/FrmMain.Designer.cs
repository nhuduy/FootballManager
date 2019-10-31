namespace FootballManager
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.imgMain = new System.Windows.Forms.PictureBox();
            this.btnNhapKetQuaThiDau = new System.Windows.Forms.Button();
            this.btnBangXepHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMain
            // 
            this.imgMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMain.Image = ((System.Drawing.Image)(resources.GetObject("imgMain.Image")));
            this.imgMain.Location = new System.Drawing.Point(12, 12);
            this.imgMain.Name = "imgMain";
            this.imgMain.Size = new System.Drawing.Size(1027, 406);
            this.imgMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMain.TabIndex = 0;
            this.imgMain.TabStop = false;
            this.imgMain.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnNhapKetQuaThiDau
            // 
            this.btnNhapKetQuaThiDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNhapKetQuaThiDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhapKetQuaThiDau.Location = new System.Drawing.Point(12, 443);
            this.btnNhapKetQuaThiDau.Name = "btnNhapKetQuaThiDau";
            this.btnNhapKetQuaThiDau.Size = new System.Drawing.Size(425, 63);
            this.btnNhapKetQuaThiDau.TabIndex = 1;
            this.btnNhapKetQuaThiDau.Text = "Nhập kết quả thi đấu";
            this.btnNhapKetQuaThiDau.UseVisualStyleBackColor = true;
            this.btnNhapKetQuaThiDau.Click += new System.EventHandler(this.btnNhapKetQuaThiDau_Click);
            // 
            // btnBangXepHang
            // 
            this.btnBangXepHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBangXepHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBangXepHang.Location = new System.Drawing.Point(605, 443);
            this.btnBangXepHang.Name = "btnBangXepHang";
            this.btnBangXepHang.Size = new System.Drawing.Size(425, 63);
            this.btnBangXepHang.TabIndex = 1;
            this.btnBangXepHang.Text = "Bảng xếp hạng";
            this.btnBangXepHang.UseVisualStyleBackColor = true;
            this.btnBangXepHang.Click += new System.EventHandler(this.btnBangXepHang_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 532);
            this.Controls.Add(this.btnBangXepHang);
            this.Controls.Add(this.btnNhapKetQuaThiDau);
            this.Controls.Add(this.imgMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Football Manager";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMain;
        private System.Windows.Forms.Button btnNhapKetQuaThiDau;
        private System.Windows.Forms.Button btnBangXepHang;
    }
}

