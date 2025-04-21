namespace GUI
{
    partial class UC_DSLuuTru
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dTP_NgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_MaLuuTru = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_SoLuong = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_NguyenLieu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_NhanVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dGV_DSLuuTru = new System.Windows.Forms.DataGridView();
            this.restaurantManagementDataSet11 = new GUI.RestaurantManagementDataSet11();
            this.viewLuuTruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_LuuTruTableAdapter = new GUI.RestaurantManagementDataSet11TableAdapters.View_LuuTruTableAdapter();
            this.maLuuTruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNguyenLieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSLuuTru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLuuTruBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Linen;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.dTP_NgayHetHan);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(0, 500);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(520, 50);
            this.panel9.TabIndex = 33;
            // 
            // dTP_NgayHetHan
            // 
            this.dTP_NgayHetHan.CalendarMonthBackground = System.Drawing.Color.Linen;
            this.dTP_NgayHetHan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_NgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_NgayHetHan.Location = new System.Drawing.Point(220, 3);
            this.dTP_NgayHetHan.Name = "dTP_NgayHetHan";
            this.dTP_NgayHetHan.Size = new System.Drawing.Size(300, 39);
            this.dTP_NgayHetHan.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(4, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày hết hạn";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Linen;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.textBox_MaLuuTru);
            this.panel8.Location = new System.Drawing.Point(0, 20);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(520, 50);
            this.panel8.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(4, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã lưu trữ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_MaLuuTru
            // 
            this.textBox_MaLuuTru.AllowDrop = true;
            this.textBox_MaLuuTru.BackColor = System.Drawing.Color.Linen;
            this.textBox_MaLuuTru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_MaLuuTru.Enabled = false;
            this.textBox_MaLuuTru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaLuuTru.Location = new System.Drawing.Point(220, 3);
            this.textBox_MaLuuTru.Multiline = true;
            this.textBox_MaLuuTru.Name = "textBox_MaLuuTru";
            this.textBox_MaLuuTru.Size = new System.Drawing.Size(300, 40);
            this.textBox_MaLuuTru.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Linen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBox_SoLuong);
            this.panel4.Location = new System.Drawing.Point(0, 380);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 50);
            this.panel4.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(4, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_SoLuong
            // 
            this.textBox_SoLuong.AllowDrop = true;
            this.textBox_SoLuong.BackColor = System.Drawing.Color.Linen;
            this.textBox_SoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_SoLuong.Enabled = false;
            this.textBox_SoLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SoLuong.Location = new System.Drawing.Point(220, 3);
            this.textBox_SoLuong.Multiline = true;
            this.textBox_SoLuong.Name = "textBox_SoLuong";
            this.textBox_SoLuong.Size = new System.Drawing.Size(300, 40);
            this.textBox_SoLuong.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBox_NguyenLieu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 50);
            this.panel1.TabIndex = 36;
            // 
            // comboBox_NguyenLieu
            // 
            this.comboBox_NguyenLieu.BackColor = System.Drawing.Color.Linen;
            this.comboBox_NguyenLieu.Enabled = false;
            this.comboBox_NguyenLieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_NguyenLieu.FormattingEnabled = true;
            this.comboBox_NguyenLieu.Location = new System.Drawing.Point(220, 3);
            this.comboBox_NguyenLieu.Name = "comboBox_NguyenLieu";
            this.comboBox_NguyenLieu.Size = new System.Drawing.Size(300, 40);
            this.comboBox_NguyenLieu.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nguyên liệu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBox_NhanVien);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 50);
            this.panel2.TabIndex = 39;
            // 
            // comboBox_NhanVien
            // 
            this.comboBox_NhanVien.BackColor = System.Drawing.Color.Linen;
            this.comboBox_NhanVien.Enabled = false;
            this.comboBox_NhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_NhanVien.FormattingEnabled = true;
            this.comboBox_NhanVien.Location = new System.Drawing.Point(220, 3);
            this.comboBox_NhanVien.Name = "comboBox_NhanVien";
            this.comboBox_NhanVien.Size = new System.Drawing.Size(300, 40);
            this.comboBox_NhanVien.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(4, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhân viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnHuyBo);
            this.panel7.Controls.Add(this.btnReload);
            this.panel7.Controls.Add(this.btnLuu);
            this.panel7.Controls.Add(this.btnThem);
            this.panel7.Controls.Add(this.btnSua);
            this.panel7.Location = new System.Drawing.Point(578, 590);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(900, 100);
            this.panel7.TabIndex = 38;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.Location = new System.Drawing.Point(585, 22);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(120, 60);
            this.btnHuyBo.TabIndex = 25;
            this.btnHuyBo.Text = "Xóa";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(780, 22);
            this.btnReload.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(120, 60);
            this.btnReload.TabIndex = 26;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(195, 22);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 60);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(0, 22);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 60);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(390, 22);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 60);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Olive;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(545, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 690);
            this.label8.TabIndex = 37;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dGV_DSLuuTru
            // 
            this.dGV_DSLuuTru.AutoGenerateColumns = false;
            this.dGV_DSLuuTru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_DSLuuTru.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLuuTruDataGridViewTextBoxColumn,
            this.tenNhanVienDataGridViewTextBoxColumn,
            this.tenNguyenLieuDataGridViewTextBoxColumn,
            this.ngayHetHanDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn});
            this.dGV_DSLuuTru.DataSource = this.viewLuuTruBindingSource;
            this.dGV_DSLuuTru.Location = new System.Drawing.Point(578, 3);
            this.dGV_DSLuuTru.Name = "dGV_DSLuuTru";
            this.dGV_DSLuuTru.RowHeadersWidth = 62;
            this.dGV_DSLuuTru.RowTemplate.Height = 28;
            this.dGV_DSLuuTru.Size = new System.Drawing.Size(900, 550);
            this.dGV_DSLuuTru.TabIndex = 40;
            this.dGV_DSLuuTru.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_DSLuuTru_CellClick);
            // 
            // restaurantManagementDataSet11
            // 
            this.restaurantManagementDataSet11.DataSetName = "RestaurantManagementDataSet11";
            this.restaurantManagementDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewLuuTruBindingSource
            // 
            this.viewLuuTruBindingSource.DataMember = "View_LuuTru";
            this.viewLuuTruBindingSource.DataSource = this.restaurantManagementDataSet11;
            // 
            // view_LuuTruTableAdapter
            // 
            this.view_LuuTruTableAdapter.ClearBeforeFill = true;
            // 
            // maLuuTruDataGridViewTextBoxColumn
            // 
            this.maLuuTruDataGridViewTextBoxColumn.DataPropertyName = "MaLuuTru";
            this.maLuuTruDataGridViewTextBoxColumn.HeaderText = "MaLuuTru";
            this.maLuuTruDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maLuuTruDataGridViewTextBoxColumn.Name = "maLuuTruDataGridViewTextBoxColumn";
            this.maLuuTruDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenNhanVienDataGridViewTextBoxColumn
            // 
            this.tenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "TenNhanVien";
            this.tenNhanVienDataGridViewTextBoxColumn.HeaderText = "TenNhanVien";
            this.tenNhanVienDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenNhanVienDataGridViewTextBoxColumn.Name = "tenNhanVienDataGridViewTextBoxColumn";
            this.tenNhanVienDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenNguyenLieuDataGridViewTextBoxColumn
            // 
            this.tenNguyenLieuDataGridViewTextBoxColumn.DataPropertyName = "TenNguyenLieu";
            this.tenNguyenLieuDataGridViewTextBoxColumn.HeaderText = "TenNguyenLieu";
            this.tenNguyenLieuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenNguyenLieuDataGridViewTextBoxColumn.Name = "tenNguyenLieuDataGridViewTextBoxColumn";
            this.tenNguyenLieuDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngayHetHanDataGridViewTextBoxColumn
            // 
            this.ngayHetHanDataGridViewTextBoxColumn.DataPropertyName = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.HeaderText = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngayHetHanDataGridViewTextBoxColumn.Name = "ngayHetHanDataGridViewTextBoxColumn";
            this.ngayHetHanDataGridViewTextBoxColumn.Width = 150;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.Width = 150;
            // 
            // UC_DSLuuTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.dGV_DSLuuTru);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label8);
            this.Name = "UC_DSLuuTru";
            this.Size = new System.Drawing.Size(1478, 690);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSLuuTru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLuuTruBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DateTimePicker dTP_NgayHetHan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_MaLuuTru;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_SoLuong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_NguyenLieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_NhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dGV_DSLuuTru;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLuuTruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNguyenLieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewLuuTruBindingSource;
        private RestaurantManagementDataSet11 restaurantManagementDataSet11;
        private RestaurantManagementDataSet11TableAdapters.View_LuuTruTableAdapter view_LuuTruTableAdapter;
    }
}
