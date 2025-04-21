namespace GUI
{
    partial class UC_DSKhuyenMai
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dTP_NgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TinhTrang = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_TenKhachHang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TenKhuyenMai = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_MaKhuyenMai = new System.Windows.Forms.TextBox();
            this.dGV_DSKhuyenMai = new System.Windows.Forms.DataGridView();
            this.restaurantManagementDataSet13 = new GUI.RestaurantManagementDataSet13();
            this.viewKhuyenMaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_KhuyenMaiTableAdapter = new GUI.RestaurantManagementDataSet13TableAdapters.View_KhuyenMaiTableAdapter();
            this.maKhuyenMaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhuyenMaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daDungDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ngayHetHanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_DaDung = new System.Windows.Forms.CheckBox();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSKhuyenMai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewKhuyenMaiBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
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
            this.panel7.TabIndex = 36;
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
            this.label8.TabIndex = 35;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Linen;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.dTP_NgayHetHan);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(0, 520);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(520, 50);
            this.panel5.TabIndex = 31;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(4, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày hết hạn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Linen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox_TinhTrang);
            this.panel3.Location = new System.Drawing.Point(0, 420);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 50);
            this.panel3.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tình trạng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_TinhTrang
            // 
            this.textBox_TinhTrang.AllowDrop = true;
            this.textBox_TinhTrang.BackColor = System.Drawing.Color.Linen;
            this.textBox_TinhTrang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_TinhTrang.Enabled = false;
            this.textBox_TinhTrang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TinhTrang.Location = new System.Drawing.Point(220, 3);
            this.textBox_TinhTrang.Multiline = true;
            this.textBox_TinhTrang.Name = "textBox_TinhTrang";
            this.textBox_TinhTrang.Size = new System.Drawing.Size(300, 40);
            this.textBox_TinhTrang.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBox_TenKhachHang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 50);
            this.panel2.TabIndex = 34;
            // 
            // comboBox_TenKhachHang
            // 
            this.comboBox_TenKhachHang.BackColor = System.Drawing.Color.Linen;
            this.comboBox_TenKhachHang.Enabled = false;
            this.comboBox_TenKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TenKhachHang.FormattingEnabled = true;
            this.comboBox_TenKhachHang.Location = new System.Drawing.Point(220, 0);
            this.comboBox_TenKhachHang.Name = "comboBox_TenKhachHang";
            this.comboBox_TenKhachHang.Size = new System.Drawing.Size(300, 40);
            this.comboBox_TenKhachHang.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(4, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_TenKhuyenMai);
            this.panel1.Location = new System.Drawing.Point(0, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 50);
            this.panel1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khuyến mãi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_TenKhuyenMai
            // 
            this.textBox_TenKhuyenMai.AllowDrop = true;
            this.textBox_TenKhuyenMai.BackColor = System.Drawing.Color.Linen;
            this.textBox_TenKhuyenMai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_TenKhuyenMai.Enabled = false;
            this.textBox_TenKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenKhuyenMai.Location = new System.Drawing.Point(220, 3);
            this.textBox_TenKhuyenMai.Multiline = true;
            this.textBox_TenKhuyenMai.Name = "textBox_TenKhuyenMai";
            this.textBox_TenKhuyenMai.Size = new System.Drawing.Size(300, 40);
            this.textBox_TenKhuyenMai.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Linen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBox_MaKhuyenMai);
            this.panel4.Location = new System.Drawing.Point(0, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 50);
            this.panel4.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(4, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã khuyến mãi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_MaKhuyenMai
            // 
            this.textBox_MaKhuyenMai.AllowDrop = true;
            this.textBox_MaKhuyenMai.BackColor = System.Drawing.Color.Linen;
            this.textBox_MaKhuyenMai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_MaKhuyenMai.Enabled = false;
            this.textBox_MaKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaKhuyenMai.Location = new System.Drawing.Point(220, 3);
            this.textBox_MaKhuyenMai.Multiline = true;
            this.textBox_MaKhuyenMai.Name = "textBox_MaKhuyenMai";
            this.textBox_MaKhuyenMai.Size = new System.Drawing.Size(300, 40);
            this.textBox_MaKhuyenMai.TabIndex = 1;
            // 
            // dGV_DSKhuyenMai
            // 
            this.dGV_DSKhuyenMai.AutoGenerateColumns = false;
            this.dGV_DSKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_DSKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhuyenMaiDataGridViewTextBoxColumn,
            this.tenKhuyenMaiDataGridViewTextBoxColumn,
            this.tenKhachHangDataGridViewTextBoxColumn,
            this.daDungDataGridViewCheckBoxColumn,
            this.ngayHetHanDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn});
            this.dGV_DSKhuyenMai.DataSource = this.viewKhuyenMaiBindingSource;
            this.dGV_DSKhuyenMai.Location = new System.Drawing.Point(578, 3);
            this.dGV_DSKhuyenMai.Name = "dGV_DSKhuyenMai";
            this.dGV_DSKhuyenMai.RowHeadersWidth = 62;
            this.dGV_DSKhuyenMai.RowTemplate.Height = 28;
            this.dGV_DSKhuyenMai.Size = new System.Drawing.Size(900, 550);
            this.dGV_DSKhuyenMai.TabIndex = 37;
            this.dGV_DSKhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_DSKhuyenMai_CellClick);
            // 
            // restaurantManagementDataSet13
            // 
            this.restaurantManagementDataSet13.DataSetName = "RestaurantManagementDataSet13";
            this.restaurantManagementDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewKhuyenMaiBindingSource
            // 
            this.viewKhuyenMaiBindingSource.DataMember = "View_KhuyenMai";
            this.viewKhuyenMaiBindingSource.DataSource = this.restaurantManagementDataSet13;
            // 
            // view_KhuyenMaiTableAdapter
            // 
            this.view_KhuyenMaiTableAdapter.ClearBeforeFill = true;
            // 
            // maKhuyenMaiDataGridViewTextBoxColumn
            // 
            this.maKhuyenMaiDataGridViewTextBoxColumn.DataPropertyName = "MaKhuyenMai";
            this.maKhuyenMaiDataGridViewTextBoxColumn.HeaderText = "MaKhuyenMai";
            this.maKhuyenMaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maKhuyenMaiDataGridViewTextBoxColumn.Name = "maKhuyenMaiDataGridViewTextBoxColumn";
            this.maKhuyenMaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenKhuyenMaiDataGridViewTextBoxColumn
            // 
            this.tenKhuyenMaiDataGridViewTextBoxColumn.DataPropertyName = "TenKhuyenMai";
            this.tenKhuyenMaiDataGridViewTextBoxColumn.HeaderText = "TenKhuyenMai";
            this.tenKhuyenMaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenKhuyenMaiDataGridViewTextBoxColumn.Name = "tenKhuyenMaiDataGridViewTextBoxColumn";
            this.tenKhuyenMaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenKhachHangDataGridViewTextBoxColumn
            // 
            this.tenKhachHangDataGridViewTextBoxColumn.DataPropertyName = "TenKhachHang";
            this.tenKhachHangDataGridViewTextBoxColumn.HeaderText = "TenKhachHang";
            this.tenKhachHangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenKhachHangDataGridViewTextBoxColumn.Name = "tenKhachHangDataGridViewTextBoxColumn";
            this.tenKhachHangDataGridViewTextBoxColumn.Width = 150;
            // 
            // daDungDataGridViewCheckBoxColumn
            // 
            this.daDungDataGridViewCheckBoxColumn.DataPropertyName = "DaDung";
            this.daDungDataGridViewCheckBoxColumn.HeaderText = "DaDung";
            this.daDungDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.daDungDataGridViewCheckBoxColumn.Name = "daDungDataGridViewCheckBoxColumn";
            this.daDungDataGridViewCheckBoxColumn.Width = 150;
            // 
            // ngayHetHanDataGridViewTextBoxColumn
            // 
            this.ngayHetHanDataGridViewTextBoxColumn.DataPropertyName = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.HeaderText = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngayHetHanDataGridViewTextBoxColumn.Name = "ngayHetHanDataGridViewTextBoxColumn";
            this.ngayHetHanDataGridViewTextBoxColumn.Width = 150;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            this.trangThaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.trangThaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Linen;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.checkBox_DaDung);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(0, 320);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(520, 50);
            this.panel6.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(4, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đã dùng?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox_DaDung
            // 
            this.checkBox_DaDung.AutoSize = true;
            this.checkBox_DaDung.Location = new System.Drawing.Point(351, 10);
            this.checkBox_DaDung.Name = "checkBox_DaDung";
            this.checkBox_DaDung.Size = new System.Drawing.Size(22, 21);
            this.checkBox_DaDung.TabIndex = 2;
            this.checkBox_DaDung.UseVisualStyleBackColor = true;
            // 
            // UC_DSKhuyenMai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dGV_DSKhuyenMai);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "UC_DSKhuyenMai2";
            this.Size = new System.Drawing.Size(1478, 690);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSKhuyenMai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewKhuyenMaiBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dTP_NgayHetHan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TinhTrang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_TenKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TenKhuyenMai;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_MaKhuyenMai;
        private System.Windows.Forms.DataGridView dGV_DSKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhuyenMaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhuyenMaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn daDungDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewKhuyenMaiBindingSource;
        private RestaurantManagementDataSet13 restaurantManagementDataSet13;
        private RestaurantManagementDataSet13TableAdapters.View_KhuyenMaiTableAdapter view_KhuyenMaiTableAdapter;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_DaDung;
    }
}
