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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label lbDoiA;
            System.Windows.Forms.Label lbDoiB;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhapKetQuaThiDau));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.footballManagerDataSet = new FootballManager.FootballManagerDataSet();
            this.bangDiemThiDauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangDiemThiDauTableAdapter = new FootballManager.FootballManagerDataSetTableAdapters.BangDiemThiDauTableAdapter();
            this.tableAdapterManager = new FootballManager.FootballManagerDataSetTableAdapters.TableAdapterManager();
            this.bangDiemThiDauBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bangDiemThiDauBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tiSoTextBox = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.tenBangTextBox = new System.Windows.Forms.TextBox();
            this.tenDoiTextBox = new System.Windows.Forms.TextBox();
            this.tenDoiDoiThuTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lbDoiA = new System.Windows.Forms.Label();
            lbDoiB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauBindingNavigator)).BeginInit();
            this.bangDiemThiDauBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(51, 406);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 25);
            label1.TabIndex = 2;
            label1.Text = "Bảng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(51, 499);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 25);
            label2.TabIndex = 2;
            label2.Text = "Đội:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(51, 565);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 25);
            label3.TabIndex = 2;
            label3.Text = "Tỉ số:";
            // 
            // lbDoiA
            // 
            lbDoiA.AutoSize = true;
            lbDoiA.Location = new System.Drawing.Point(187, 468);
            lbDoiA.Name = "lbDoiA";
            lbDoiA.Size = new System.Drawing.Size(70, 25);
            lbDoiA.TabIndex = 2;
            lbDoiA.Text = "Đội A:";
            // 
            // lbDoiB
            // 
            lbDoiB.AutoSize = true;
            lbDoiB.Location = new System.Drawing.Point(402, 468);
            lbDoiB.Name = "lbDoiB";
            lbDoiB.Size = new System.Drawing.Size(70, 25);
            lbDoiB.TabIndex = 2;
            lbDoiB.Text = "Đội B:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(611, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // bangDiemThiDauBindingNavigator
            // 
            this.bangDiemThiDauBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bangDiemThiDauBindingNavigator.BindingSource = this.bangDiemThiDauBindingSource;
            this.bangDiemThiDauBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bangDiemThiDauBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bangDiemThiDauBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.bangDiemThiDauBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bangDiemThiDauBindingNavigatorSaveItem});
            this.bangDiemThiDauBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bangDiemThiDauBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bangDiemThiDauBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bangDiemThiDauBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bangDiemThiDauBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bangDiemThiDauBindingNavigator.Name = "bangDiemThiDauBindingNavigator";
            this.bangDiemThiDauBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bangDiemThiDauBindingNavigator.Size = new System.Drawing.Size(611, 42);
            this.bangDiemThiDauBindingNavigator.TabIndex = 1;
            this.bangDiemThiDauBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // bangDiemThiDauBindingNavigatorSaveItem
            // 
            this.bangDiemThiDauBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bangDiemThiDauBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bangDiemThiDauBindingNavigatorSaveItem.Image")));
            this.bangDiemThiDauBindingNavigatorSaveItem.Name = "bangDiemThiDauBindingNavigatorSaveItem";
            this.bangDiemThiDauBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
            this.bangDiemThiDauBindingNavigatorSaveItem.Text = "Save Data";
            this.bangDiemThiDauBindingNavigatorSaveItem.Click += new System.EventHandler(this.bangDiemThiDauBindingNavigatorSaveItem_Click);
            // 
            // tiSoTextBox
            // 
            this.tiSoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bangDiemThiDauBindingSource, "TiSo", true));
            this.tiSoTextBox.Location = new System.Drawing.Point(158, 565);
            this.tiSoTextBox.Name = "tiSoTextBox";
            this.tiSoTextBox.Size = new System.Drawing.Size(344, 31);
            this.tiSoTextBox.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(158, 635);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(344, 65);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tenBangTextBox
            // 
            this.tenBangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bangDiemThiDauBindingSource, "TenBang", true));
            this.tenBangTextBox.Location = new System.Drawing.Point(158, 403);
            this.tenBangTextBox.Name = "tenBangTextBox";
            this.tenBangTextBox.Size = new System.Drawing.Size(344, 31);
            this.tenBangTextBox.TabIndex = 11;
            // 
            // tenDoiTextBox
            // 
            this.tenDoiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bangDiemThiDauBindingSource, "TenDoi", true));
            this.tenDoiTextBox.Location = new System.Drawing.Point(158, 496);
            this.tenDoiTextBox.Name = "tenDoiTextBox";
            this.tenDoiTextBox.Size = new System.Drawing.Size(128, 31);
            this.tenDoiTextBox.TabIndex = 12;
            // 
            // tenDoiDoiThuTextBox
            // 
            this.tenDoiDoiThuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bangDiemThiDauBindingSource, "TenDoiDoiThu", true));
            this.tenDoiDoiThuTextBox.Location = new System.Drawing.Point(374, 496);
            this.tenDoiDoiThuTextBox.Name = "tenDoiDoiThuTextBox";
            this.tenDoiDoiThuTextBox.Size = new System.Drawing.Size(128, 31);
            this.tenDoiDoiThuTextBox.TabIndex = 13;
            // 
            // FrmNhapKetQuaThiDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 725);
            this.Controls.Add(this.tenDoiDoiThuTextBox);
            this.Controls.Add(this.tenDoiTextBox);
            this.Controls.Add(this.tenBangTextBox);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tiSoTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(lbDoiB);
            this.Controls.Add(lbDoiA);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.bangDiemThiDauBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNhapKetQuaThiDau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập kết quả thi đấu";
            this.Load += new System.EventHandler(this.FrmNhapKetQuaThiDau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauBindingNavigator)).EndInit();
            this.bangDiemThiDauBindingNavigator.ResumeLayout(false);
            this.bangDiemThiDauBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FootballManagerDataSet footballManagerDataSet;
        private System.Windows.Forms.BindingSource bangDiemThiDauBindingSource;
        private FootballManagerDataSetTableAdapters.BangDiemThiDauTableAdapter bangDiemThiDauTableAdapter;
        private FootballManagerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bangDiemThiDauBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bangDiemThiDauBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox tiSoTextBox;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox tenBangTextBox;
        private System.Windows.Forms.TextBox tenDoiTextBox;
        private System.Windows.Forms.TextBox tenDoiDoiThuTextBox;
    }
}