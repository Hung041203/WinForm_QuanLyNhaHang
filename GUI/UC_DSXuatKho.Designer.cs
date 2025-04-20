namespace GUI
{
    partial class UC_DSXuatKho
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
            this.dGV_DSXuatKho = new System.Windows.Forms.DataGridView();
            this.maXuatKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNguyenLieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguyenNhanXuatKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLuuTruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewXuatKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantManagementDataSet10 = new GUI.RestaurantManagementDataSet10();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dTP_NgayXuat = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_MaXuatKho = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SoLuong = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_TenNguyenLieu = new System.Windows.Forms.TextBox();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox_MaLuuTru = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.view_XuatKhoTableAdapter = new GUI.RestaurantManagementDataSet10TableAdapters.View_XuatKhoTableAdapter();
            this.textBox_NguyenNhanXuat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSXuatKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewXuatKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet10)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_DSXuatKho
            // 
            this.dGV_DSXuatKho.AutoGenerateColumns = false;
            this.dGV_DSXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_DSXuatKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maXuatKhoDataGridViewTextBoxColumn,
            this.tenNhanVienDataGridViewTextBoxColumn,
            this.tenNguyenLieuDataGridViewTextBoxColumn,
            this.ngayXuatDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.nguyenNhanXuatKhoDataGridViewTextBoxColumn,
            this.maLuuTruDataGridViewTextBoxColumn});
            this.dGV_DSXuatKho.DataSource = this.viewXuatKhoBindingSource;
            this.dGV_DSXuatKho.Location = new System.Drawing.Point(578, 3);
            this.dGV_DSXuatKho.Name = "dGV_DSXuatKho";
            this.dGV_DSXuatKho.RowHeadersWidth = 62;
            this.dGV_DSXuatKho.RowTemplate.Height = 28;
            this.dGV_DSXuatKho.Size = new System.Drawing.Size(900, 550);
            this.dGV_DSXuatKho.TabIndex = 0;
            this.dGV_DSXuatKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_DSXuatKho_CellClick);
            // 
            // maXuatKhoDataGridViewTextBoxColumn
            // 
            this.maXuatKhoDataGridViewTextBoxColumn.DataPropertyName = "MaXuatKho";
            this.maXuatKhoDataGridViewTextBoxColumn.HeaderText = "MaXuatKho";
            this.maXuatKhoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maXuatKhoDataGridViewTextBoxColumn.Name = "maXuatKhoDataGridViewTextBoxColumn";
            this.maXuatKhoDataGridViewTextBoxColumn.Width = 150;
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
            // ngayXuatDataGridViewTextBoxColumn
            // 
            this.ngayXuatDataGridViewTextBoxColumn.DataPropertyName = "NgayXuat";
            this.ngayXuatDataGridViewTextBoxColumn.HeaderText = "NgayXuat";
            this.ngayXuatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngayXuatDataGridViewTextBoxColumn.Name = "ngayXuatDataGridViewTextBoxColumn";
            this.ngayXuatDataGridViewTextBoxColumn.Width = 150;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.Width = 150;
            // 
            // nguyenNhanXuatKhoDataGridViewTextBoxColumn
            // 
            this.nguyenNhanXuatKhoDataGridViewTextBoxColumn.DataPropertyName = "NguyenNhanXuatKho";
            this.nguyenNhanXuatKhoDataGridViewTextBoxColumn.HeaderText = "NguyenNhanXuatKho";
            this.nguyenNhanXuatKhoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nguyenNhanXuatKhoDataGridViewTextBoxColumn.Name = "nguyenNhanXuatKhoDataGridViewTextBoxColumn";
            this.nguyenNhanXuatKhoDataGridViewTextBoxColumn.Width = 150;
            // 
            // maLuuTruDataGridViewTextBoxColumn
            // 
            this.maLuuTruDataGridViewTextBoxColumn.DataPropertyName = "MaLuuTru";
            this.maLuuTruDataGridViewTextBoxColumn.HeaderText = "MaLuuTru";
            this.maLuuTruDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maLuuTruDataGridViewTextBoxColumn.Name = "maLuuTruDataGridViewTextBoxColumn";
            this.maLuuTruDataGridViewTextBoxColumn.Width = 150;
            // 
            // viewXuatKhoBindingSource
            // 
            this.viewXuatKhoBindingSource.DataMember = "View_XuatKho";
            this.viewXuatKhoBindingSource.DataSource = this.restaurantManagementDataSet10;
            // 
            // restaurantManagementDataSet10
            // 
            this.restaurantManagementDataSet10.DataSetName = "RestaurantManagementDataSet10";
            this.restaurantManagementDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Linen;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.dTP_NgayXuat);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(0, 340);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(520, 50);
            this.panel9.TabIndex = 33;
            // 
            // dTP_NgayXuat
            // 
            this.dTP_NgayXuat.CalendarMonthBackground = System.Drawing.Color.Linen;
            this.dTP_NgayXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_NgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_NgayXuat.Location = new System.Drawing.Point(220, 3);
            this.dTP_NgayXuat.Name = "dTP_NgayXuat";
            this.dTP_NgayXuat.Size = new System.Drawing.Size(300, 39);
            this.dTP_NgayXuat.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(4, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày xuất";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Linen;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.textBox_MaXuatKho);
            this.panel8.Location = new System.Drawing.Point(0, 20);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(520, 50);
            this.panel8.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(4, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã xuất kho";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_MaXuatKho
            // 
            this.textBox_MaXuatKho.AllowDrop = true;
            this.textBox_MaXuatKho.BackColor = System.Drawing.Color.Linen;
            this.textBox_MaXuatKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_MaXuatKho.Enabled = false;
            this.textBox_MaXuatKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaXuatKho.Location = new System.Drawing.Point(220, 3);
            this.textBox_MaXuatKho.Multiline = true;
            this.textBox_MaXuatKho.Name = "textBox_MaXuatKho";
            this.textBox_MaXuatKho.Size = new System.Drawing.Size(300, 40);
            this.textBox_MaXuatKho.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Linen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox_SoLuong);
            this.panel3.Location = new System.Drawing.Point(0, 420);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 50);
            this.panel3.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.panel1.Controls.Add(this.textBox_TenNguyenLieu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 50);
            this.panel1.TabIndex = 39;
            // 
            // textBox_TenNguyenLieu
            // 
            this.textBox_TenNguyenLieu.AllowDrop = true;
            this.textBox_TenNguyenLieu.BackColor = System.Drawing.Color.Linen;
            this.textBox_TenNguyenLieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_TenNguyenLieu.Enabled = false;
            this.textBox_TenNguyenLieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenNguyenLieu.Location = new System.Drawing.Point(220, 3);
            this.textBox_TenNguyenLieu.Multiline = true;
            this.textBox_TenNguyenLieu.Name = "textBox_TenNguyenLieu";
            this.textBox_TenNguyenLieu.Size = new System.Drawing.Size(300, 40);
            this.textBox_TenNguyenLieu.TabIndex = 2;
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
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 50);
            this.panel2.TabIndex = 42;
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
            this.panel7.TabIndex = 41;
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
            this.label8.TabIndex = 40;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Linen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.comboBox_MaLuuTru);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 50);
            this.panel4.TabIndex = 40;
            // 
            // comboBox_MaLuuTru
            // 
            this.comboBox_MaLuuTru.BackColor = System.Drawing.Color.Linen;
            this.comboBox_MaLuuTru.Enabled = false;
            this.comboBox_MaLuuTru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MaLuuTru.FormattingEnabled = true;
            this.comboBox_MaLuuTru.Location = new System.Drawing.Point(220, 3);
            this.comboBox_MaLuuTru.Name = "comboBox_MaLuuTru";
            this.comboBox_MaLuuTru.Size = new System.Drawing.Size(300, 40);
            this.comboBox_MaLuuTru.TabIndex = 29;
            this.comboBox_MaLuuTru.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaLuuTru_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(4, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã lưu trữ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // view_XuatKhoTableAdapter
            // 
            this.view_XuatKhoTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_NguyenNhanXuat
            // 
            this.textBox_NguyenNhanXuat.AllowDrop = true;
            this.textBox_NguyenNhanXuat.BackColor = System.Drawing.Color.Linen;
            this.textBox_NguyenNhanXuat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_NguyenNhanXuat.Enabled = false;
            this.textBox_NguyenNhanXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NguyenNhanXuat.Location = new System.Drawing.Point(220, 3);
            this.textBox_NguyenNhanXuat.Multiline = true;
            this.textBox_NguyenNhanXuat.Name = "textBox_NguyenNhanXuat";
            this.textBox_NguyenNhanXuat.Size = new System.Drawing.Size(300, 90);
            this.textBox_NguyenNhanXuat.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(4, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nguyên nhân xuất";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Linen;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.textBox_NguyenNhanXuat);
            this.panel5.Location = new System.Drawing.Point(0, 500);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(520, 100);
            this.panel5.TabIndex = 30;
            // 
            // UC_DSXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dGV_DSXuatKho);
            this.Name = "UC_DSXuatKho";
            this.Size = new System.Drawing.Size(1478, 690);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSXuatKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewXuatKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet10)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_DSXuatKho;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DateTimePicker dTP_NgayXuat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_MaXuatKho;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SoLuong;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox_MaLuuTru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn maXuatKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNguyenLieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguyenNhanXuatKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLuuTruDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewXuatKhoBindingSource;
        private RestaurantManagementDataSet10 restaurantManagementDataSet10;
        private RestaurantManagementDataSet10TableAdapters.View_XuatKhoTableAdapter view_XuatKhoTableAdapter;
        private System.Windows.Forms.TextBox textBox_NguyenNhanXuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox_TenNguyenLieu;
    }
}
