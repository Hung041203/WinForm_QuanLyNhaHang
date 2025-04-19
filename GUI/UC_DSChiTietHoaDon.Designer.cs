namespace GUI
{
    partial class UC_DSChiTietHoaDon
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
            this.label8 = new System.Windows.Forms.Label();
            this.dGV_DSChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.maChiTietHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonAnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewChiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantManagementDataSet8 = new GUI.RestaurantManagementDataSet8();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.view_ChiTietHoaDonTableAdapter = new GUI.RestaurantManagementDataSet8TableAdapters.View_ChiTietHoaDonTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_MaHoaDon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MaChiTietHoaDon = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SoLuong = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_GiaTien = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ThanhTien = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox_TenMonAn = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewChiTietHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet8)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Olive;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(545, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 690);
            this.label8.TabIndex = 19;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dGV_DSChiTietHoaDon
            // 
            this.dGV_DSChiTietHoaDon.AutoGenerateColumns = false;
            this.dGV_DSChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_DSChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maChiTietHoaDonDataGridViewTextBoxColumn,
            this.tenMonAnDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn});
            this.dGV_DSChiTietHoaDon.DataSource = this.viewChiTietHoaDonBindingSource;
            this.dGV_DSChiTietHoaDon.Location = new System.Drawing.Point(578, 3);
            this.dGV_DSChiTietHoaDon.Name = "dGV_DSChiTietHoaDon";
            this.dGV_DSChiTietHoaDon.RowHeadersWidth = 62;
            this.dGV_DSChiTietHoaDon.RowTemplate.Height = 28;
            this.dGV_DSChiTietHoaDon.Size = new System.Drawing.Size(900, 550);
            this.dGV_DSChiTietHoaDon.TabIndex = 20;
            this.dGV_DSChiTietHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_DSChiTietHoaDon_CellClick);
            // 
            // maChiTietHoaDonDataGridViewTextBoxColumn
            // 
            this.maChiTietHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaChiTietHoaDon";
            this.maChiTietHoaDonDataGridViewTextBoxColumn.HeaderText = "MaChiTietHoaDon";
            this.maChiTietHoaDonDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maChiTietHoaDonDataGridViewTextBoxColumn.Name = "maChiTietHoaDonDataGridViewTextBoxColumn";
            this.maChiTietHoaDonDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenMonAnDataGridViewTextBoxColumn
            // 
            this.tenMonAnDataGridViewTextBoxColumn.DataPropertyName = "TenMonAn";
            this.tenMonAnDataGridViewTextBoxColumn.HeaderText = "TenMonAn";
            this.tenMonAnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenMonAnDataGridViewTextBoxColumn.Name = "tenMonAnDataGridViewTextBoxColumn";
            this.tenMonAnDataGridViewTextBoxColumn.Width = 150;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.Width = 150;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Gia";
            this.giaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            this.giaDataGridViewTextBoxColumn.Width = 150;
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            this.thanhTienDataGridViewTextBoxColumn.Width = 150;
            // 
            // viewChiTietHoaDonBindingSource
            // 
            this.viewChiTietHoaDonBindingSource.DataMember = "View_ChiTietHoaDon";
            this.viewChiTietHoaDonBindingSource.DataSource = this.restaurantManagementDataSet8;
            // 
            // restaurantManagementDataSet8
            // 
            this.restaurantManagementDataSet8.DataSetName = "RestaurantManagementDataSet8";
            this.restaurantManagementDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel7.TabIndex = 30;
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
            // view_ChiTietHoaDonTableAdapter
            // 
            this.view_ChiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBox_MaHoaDon);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 50);
            this.panel2.TabIndex = 31;
            // 
            // comboBox_MaHoaDon
            // 
            this.comboBox_MaHoaDon.BackColor = System.Drawing.Color.Linen;
            this.comboBox_MaHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MaHoaDon.FormattingEnabled = true;
            this.comboBox_MaHoaDon.Location = new System.Drawing.Point(220, 3);
            this.comboBox_MaHoaDon.Name = "comboBox_MaHoaDon";
            this.comboBox_MaHoaDon.Size = new System.Drawing.Size(300, 40);
            this.comboBox_MaHoaDon.TabIndex = 29;
            this.comboBox_MaHoaDon.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaHoaDon_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(4, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_MaChiTietHoaDon);
            this.panel1.Location = new System.Drawing.Point(0, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 50);
            this.panel1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã CTHĐ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_MaChiTietHoaDon
            // 
            this.textBox_MaChiTietHoaDon.AllowDrop = true;
            this.textBox_MaChiTietHoaDon.BackColor = System.Drawing.Color.Linen;
            this.textBox_MaChiTietHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_MaChiTietHoaDon.Enabled = false;
            this.textBox_MaChiTietHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaChiTietHoaDon.Location = new System.Drawing.Point(220, 3);
            this.textBox_MaChiTietHoaDon.Multiline = true;
            this.textBox_MaChiTietHoaDon.Name = "textBox_MaChiTietHoaDon";
            this.textBox_MaChiTietHoaDon.Size = new System.Drawing.Size(300, 40);
            this.textBox_MaChiTietHoaDon.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Linen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox_SoLuong);
            this.panel3.Location = new System.Drawing.Point(0, 460);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 50);
            this.panel3.TabIndex = 26;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Linen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBox_GiaTien);
            this.panel4.Location = new System.Drawing.Point(0, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 50);
            this.panel4.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(4, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá tiền";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_GiaTien
            // 
            this.textBox_GiaTien.AllowDrop = true;
            this.textBox_GiaTien.BackColor = System.Drawing.Color.Linen;
            this.textBox_GiaTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_GiaTien.Enabled = false;
            this.textBox_GiaTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_GiaTien.Location = new System.Drawing.Point(220, 3);
            this.textBox_GiaTien.Multiline = true;
            this.textBox_GiaTien.Name = "textBox_GiaTien";
            this.textBox_GiaTien.Size = new System.Drawing.Size(300, 40);
            this.textBox_GiaTien.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Linen;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.textBox_ThanhTien);
            this.panel6.Location = new System.Drawing.Point(0, 570);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(520, 50);
            this.panel6.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(4, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thành tiền";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ThanhTien
            // 
            this.textBox_ThanhTien.AllowDrop = true;
            this.textBox_ThanhTien.BackColor = System.Drawing.Color.Linen;
            this.textBox_ThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ThanhTien.Enabled = false;
            this.textBox_ThanhTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ThanhTien.Location = new System.Drawing.Point(220, 3);
            this.textBox_ThanhTien.Multiline = true;
            this.textBox_ThanhTien.Name = "textBox_ThanhTien";
            this.textBox_ThanhTien.Size = new System.Drawing.Size(300, 40);
            this.textBox_ThanhTien.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Linen;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.comboBox_TenMonAn);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(0, 240);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(520, 50);
            this.panel5.TabIndex = 32;
            // 
            // comboBox_TenMonAn
            // 
            this.comboBox_TenMonAn.BackColor = System.Drawing.Color.Linen;
            this.comboBox_TenMonAn.Enabled = false;
            this.comboBox_TenMonAn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TenMonAn.FormattingEnabled = true;
            this.comboBox_TenMonAn.Location = new System.Drawing.Point(220, 3);
            this.comboBox_TenMonAn.Name = "comboBox_TenMonAn";
            this.comboBox_TenMonAn.Size = new System.Drawing.Size(300, 40);
            this.comboBox_TenMonAn.TabIndex = 29;
            this.comboBox_TenMonAn.SelectedIndexChanged += new System.EventHandler(this.comboBox_TenMonAn_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(4, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên món ăn";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UC_DSChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.dGV_DSChiTietHoaDon);
            this.Controls.Add(this.label8);
            this.Name = "UC_DSChiTietHoaDon";
            this.Size = new System.Drawing.Size(1478, 690);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewChiTietHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet8)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dGV_DSChiTietHoaDon;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChiTietHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonAnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewChiTietHoaDonBindingSource;
        private RestaurantManagementDataSet8 restaurantManagementDataSet8;
        private RestaurantManagementDataSet8TableAdapters.View_ChiTietHoaDonTableAdapter view_ChiTietHoaDonTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_MaHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MaChiTietHoaDon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SoLuong;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_GiaTien;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ThanhTien;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboBox_TenMonAn;
        private System.Windows.Forms.Label label5;
    }
}
