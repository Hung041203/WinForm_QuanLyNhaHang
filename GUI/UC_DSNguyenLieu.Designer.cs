namespace GUI
{
    partial class UC_DSNguyenLieu
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
            this.dGV_DSNguyenLieu = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Gia = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_DonViTinh = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_TenNCC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TenNguyenLieu = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_MaNguyenLieu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.restaurantManagementDataSet5 = new GUI.RestaurantManagementDataSet5();
            this.viewNguyenLieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_NguyenLieuTableAdapter = new GUI.RestaurantManagementDataSet5TableAdapters.View_NguyenLieuTableAdapter();
            this.maNguyenLieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNguyenLieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhaCungCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSNguyenLieu)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNguyenLieuBindingSource)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_DSNguyenLieu
            // 
            this.dGV_DSNguyenLieu.AutoGenerateColumns = false;
            this.dGV_DSNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_DSNguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNguyenLieuDataGridViewTextBoxColumn,
            this.tenNguyenLieuDataGridViewTextBoxColumn,
            this.donViTinhDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.tenNhaCungCapDataGridViewTextBoxColumn});
            this.dGV_DSNguyenLieu.DataSource = this.viewNguyenLieuBindingSource;
            this.dGV_DSNguyenLieu.Location = new System.Drawing.Point(578, 3);
            this.dGV_DSNguyenLieu.Name = "dGV_DSNguyenLieu";
            this.dGV_DSNguyenLieu.RowHeadersWidth = 62;
            this.dGV_DSNguyenLieu.RowTemplate.Height = 28;
            this.dGV_DSNguyenLieu.Size = new System.Drawing.Size(900, 550);
            this.dGV_DSNguyenLieu.TabIndex = 0;
            this.dGV_DSNguyenLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_DSNguyenLieu_CellClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Linen;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.textBox_Gia);
            this.panel5.Location = new System.Drawing.Point(0, 580);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(520, 50);
            this.panel5.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(4, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Gia
            // 
            this.textBox_Gia.AllowDrop = true;
            this.textBox_Gia.BackColor = System.Drawing.Color.Linen;
            this.textBox_Gia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Gia.Enabled = false;
            this.textBox_Gia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Gia.Location = new System.Drawing.Point(220, 3);
            this.textBox_Gia.Multiline = true;
            this.textBox_Gia.Name = "textBox_Gia";
            this.textBox_Gia.Size = new System.Drawing.Size(300, 40);
            this.textBox_Gia.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Linen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox_DonViTinh);
            this.panel3.Location = new System.Drawing.Point(0, 440);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 50);
            this.panel3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn vị tính";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_DonViTinh
            // 
            this.textBox_DonViTinh.AllowDrop = true;
            this.textBox_DonViTinh.BackColor = System.Drawing.Color.Linen;
            this.textBox_DonViTinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_DonViTinh.Enabled = false;
            this.textBox_DonViTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DonViTinh.Location = new System.Drawing.Point(220, 3);
            this.textBox_DonViTinh.Multiline = true;
            this.textBox_DonViTinh.Name = "textBox_DonViTinh";
            this.textBox_DonViTinh.Size = new System.Drawing.Size(300, 40);
            this.textBox_DonViTinh.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBox_TenNCC);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 50);
            this.panel2.TabIndex = 12;
            // 
            // comboBox_TenNCC
            // 
            this.comboBox_TenNCC.BackColor = System.Drawing.Color.Linen;
            this.comboBox_TenNCC.Enabled = false;
            this.comboBox_TenNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TenNCC.FormattingEnabled = true;
            this.comboBox_TenNCC.Location = new System.Drawing.Point(220, 0);
            this.comboBox_TenNCC.Name = "comboBox_TenNCC";
            this.comboBox_TenNCC.Size = new System.Drawing.Size(300, 40);
            this.comboBox_TenNCC.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(4, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhà cung cấp";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_TenNguyenLieu);
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 50);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nguyên liệu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.textBox_TenNguyenLieu.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Linen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBox_MaNguyenLieu);
            this.panel4.Location = new System.Drawing.Point(0, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 50);
            this.panel4.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(4, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã nguyên liệu";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_MaNguyenLieu
            // 
            this.textBox_MaNguyenLieu.AllowDrop = true;
            this.textBox_MaNguyenLieu.BackColor = System.Drawing.Color.Linen;
            this.textBox_MaNguyenLieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_MaNguyenLieu.Enabled = false;
            this.textBox_MaNguyenLieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaNguyenLieu.Location = new System.Drawing.Point(220, 3);
            this.textBox_MaNguyenLieu.Multiline = true;
            this.textBox_MaNguyenLieu.Name = "textBox_MaNguyenLieu";
            this.textBox_MaNguyenLieu.Size = new System.Drawing.Size(300, 40);
            this.textBox_MaNguyenLieu.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Olive;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(545, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 690);
            this.label8.TabIndex = 13;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restaurantManagementDataSet5
            // 
            this.restaurantManagementDataSet5.DataSetName = "RestaurantManagementDataSet5";
            this.restaurantManagementDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewNguyenLieuBindingSource
            // 
            this.viewNguyenLieuBindingSource.DataMember = "View_NguyenLieu";
            this.viewNguyenLieuBindingSource.DataSource = this.restaurantManagementDataSet5;
            // 
            // view_NguyenLieuTableAdapter
            // 
            this.view_NguyenLieuTableAdapter.ClearBeforeFill = true;
            // 
            // maNguyenLieuDataGridViewTextBoxColumn
            // 
            this.maNguyenLieuDataGridViewTextBoxColumn.DataPropertyName = "MaNguyenLieu";
            this.maNguyenLieuDataGridViewTextBoxColumn.HeaderText = "MaNguyenLieu";
            this.maNguyenLieuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maNguyenLieuDataGridViewTextBoxColumn.Name = "maNguyenLieuDataGridViewTextBoxColumn";
            this.maNguyenLieuDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenNguyenLieuDataGridViewTextBoxColumn
            // 
            this.tenNguyenLieuDataGridViewTextBoxColumn.DataPropertyName = "TenNguyenLieu";
            this.tenNguyenLieuDataGridViewTextBoxColumn.HeaderText = "TenNguyenLieu";
            this.tenNguyenLieuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenNguyenLieuDataGridViewTextBoxColumn.Name = "tenNguyenLieuDataGridViewTextBoxColumn";
            this.tenNguyenLieuDataGridViewTextBoxColumn.Width = 150;
            // 
            // donViTinhDataGridViewTextBoxColumn
            // 
            this.donViTinhDataGridViewTextBoxColumn.DataPropertyName = "DonViTinh";
            this.donViTinhDataGridViewTextBoxColumn.HeaderText = "DonViTinh";
            this.donViTinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.donViTinhDataGridViewTextBoxColumn.Name = "donViTinhDataGridViewTextBoxColumn";
            this.donViTinhDataGridViewTextBoxColumn.Width = 150;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Gia";
            this.giaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            this.giaDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenNhaCungCapDataGridViewTextBoxColumn
            // 
            this.tenNhaCungCapDataGridViewTextBoxColumn.DataPropertyName = "TenNhaCungCap";
            this.tenNhaCungCapDataGridViewTextBoxColumn.HeaderText = "TenNhaCungCap";
            this.tenNhaCungCapDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenNhaCungCapDataGridViewTextBoxColumn.Name = "tenNhaCungCapDataGridViewTextBoxColumn";
            this.tenNhaCungCapDataGridViewTextBoxColumn.Width = 150;
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
            this.panel7.TabIndex = 28;
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
            // UC_DSNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dGV_DSNguyenLieu);
            this.Name = "UC_DSNguyenLieu";
            this.Size = new System.Drawing.Size(1478, 690);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSNguyenLieu)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNguyenLieuBindingSource)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_DSNguyenLieu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Gia;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_DonViTinh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_TenNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TenNguyenLieu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_MaNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNguyenLieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNguyenLieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhaCungCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewNguyenLieuBindingSource;
        private RestaurantManagementDataSet5 restaurantManagementDataSet5;
        private System.Windows.Forms.Label label8;
        private RestaurantManagementDataSet5TableAdapters.View_NguyenLieuTableAdapter view_NguyenLieuTableAdapter;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
    }
}
