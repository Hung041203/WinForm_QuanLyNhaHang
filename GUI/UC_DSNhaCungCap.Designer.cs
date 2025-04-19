namespace GUI
{
    partial class UC_DSNhaCungCap
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
            this.dGV_DSNhaCungCap = new System.Windows.Forms.DataGridView();
            this.maNhaCungCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhaCungCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaCungCapsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantManagementDataSet1 = new GUI.RestaurantManagementDataSet1();
            this.restaurantManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungCapsTableAdapter = new GUI.RestaurantManagementDataSet1TableAdapters.NhaCungCapsTableAdapter();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_SoDienThoai = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_DiaChi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TenNCC = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_MaNCC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSetBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_DSNhaCungCap
            // 
            this.dGV_DSNhaCungCap.AutoGenerateColumns = false;
            this.dGV_DSNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_DSNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhaCungCapDataGridViewTextBoxColumn,
            this.tenNhaCungCapDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dGV_DSNhaCungCap.DataSource = this.nhaCungCapsBindingSource;
            this.dGV_DSNhaCungCap.Location = new System.Drawing.Point(578, 3);
            this.dGV_DSNhaCungCap.Name = "dGV_DSNhaCungCap";
            this.dGV_DSNhaCungCap.RowHeadersWidth = 62;
            this.dGV_DSNhaCungCap.RowTemplate.Height = 28;
            this.dGV_DSNhaCungCap.Size = new System.Drawing.Size(900, 550);
            this.dGV_DSNhaCungCap.TabIndex = 0;
            this.dGV_DSNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_DSNhaCungCap_CellClick);
            // 
            // maNhaCungCapDataGridViewTextBoxColumn
            // 
            this.maNhaCungCapDataGridViewTextBoxColumn.DataPropertyName = "MaNhaCungCap";
            this.maNhaCungCapDataGridViewTextBoxColumn.HeaderText = "MaNhaCungCap";
            this.maNhaCungCapDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maNhaCungCapDataGridViewTextBoxColumn.Name = "maNhaCungCapDataGridViewTextBoxColumn";
            this.maNhaCungCapDataGridViewTextBoxColumn.ReadOnly = true;
            this.maNhaCungCapDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenNhaCungCapDataGridViewTextBoxColumn
            // 
            this.tenNhaCungCapDataGridViewTextBoxColumn.DataPropertyName = "TenNhaCungCap";
            this.tenNhaCungCapDataGridViewTextBoxColumn.HeaderText = "TenNhaCungCap";
            this.tenNhaCungCapDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenNhaCungCapDataGridViewTextBoxColumn.Name = "tenNhaCungCapDataGridViewTextBoxColumn";
            this.tenNhaCungCapDataGridViewTextBoxColumn.Width = 150;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 150;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // nhaCungCapsBindingSource
            // 
            this.nhaCungCapsBindingSource.DataMember = "NhaCungCaps";
            this.nhaCungCapsBindingSource.DataSource = this.restaurantManagementDataSet1;
            // 
            // restaurantManagementDataSet1
            // 
            this.restaurantManagementDataSet1.DataSetName = "RestaurantManagementDataSet1";
            this.restaurantManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaCungCapsTableAdapter
            // 
            this.nhaCungCapsTableAdapter.ClearBeforeFill = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Linen;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.textBox_Email);
            this.panel6.Location = new System.Drawing.Point(0, 590);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(520, 50);
            this.panel6.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(4, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Email
            // 
            this.textBox_Email.AllowDrop = true;
            this.textBox_Email.BackColor = System.Drawing.Color.Linen;
            this.textBox_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Email.Enabled = false;
            this.textBox_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.Location = new System.Drawing.Point(220, 3);
            this.textBox_Email.Multiline = true;
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(300, 40);
            this.textBox_Email.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Linen;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.textBox_SoDienThoai);
            this.panel5.Location = new System.Drawing.Point(0, 460);
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
            this.label4.Size = new System.Drawing.Size(156, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_SoDienThoai
            // 
            this.textBox_SoDienThoai.AllowDrop = true;
            this.textBox_SoDienThoai.BackColor = System.Drawing.Color.Linen;
            this.textBox_SoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_SoDienThoai.Enabled = false;
            this.textBox_SoDienThoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SoDienThoai.Location = new System.Drawing.Point(220, 3);
            this.textBox_SoDienThoai.Multiline = true;
            this.textBox_SoDienThoai.Name = "textBox_SoDienThoai";
            this.textBox_SoDienThoai.Size = new System.Drawing.Size(300, 40);
            this.textBox_SoDienThoai.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Linen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox_DiaChi);
            this.panel3.Location = new System.Drawing.Point(0, 280);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 100);
            this.panel3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_DiaChi
            // 
            this.textBox_DiaChi.AllowDrop = true;
            this.textBox_DiaChi.BackColor = System.Drawing.Color.Linen;
            this.textBox_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_DiaChi.Enabled = false;
            this.textBox_DiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DiaChi.Location = new System.Drawing.Point(220, 3);
            this.textBox_DiaChi.Multiline = true;
            this.textBox_DiaChi.Name = "textBox_DiaChi";
            this.textBox_DiaChi.Size = new System.Drawing.Size(300, 90);
            this.textBox_DiaChi.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_TenNCC);
            this.panel1.Location = new System.Drawing.Point(0, 150);
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
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhà cung cấp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_TenNCC
            // 
            this.textBox_TenNCC.AllowDrop = true;
            this.textBox_TenNCC.BackColor = System.Drawing.Color.Linen;
            this.textBox_TenNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_TenNCC.Enabled = false;
            this.textBox_TenNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenNCC.Location = new System.Drawing.Point(220, 3);
            this.textBox_TenNCC.Multiline = true;
            this.textBox_TenNCC.Name = "textBox_TenNCC";
            this.textBox_TenNCC.Size = new System.Drawing.Size(300, 40);
            this.textBox_TenNCC.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Linen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBox_MaNCC);
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
            this.label7.Size = new System.Drawing.Size(199, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã nhà cung cấp";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_MaNCC
            // 
            this.textBox_MaNCC.AllowDrop = true;
            this.textBox_MaNCC.BackColor = System.Drawing.Color.Linen;
            this.textBox_MaNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_MaNCC.Enabled = false;
            this.textBox_MaNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaNCC.Location = new System.Drawing.Point(220, 3);
            this.textBox_MaNCC.Multiline = true;
            this.textBox_MaNCC.Name = "textBox_MaNCC";
            this.textBox_MaNCC.Size = new System.Drawing.Size(300, 40);
            this.textBox_MaNCC.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Olive;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(545, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 690);
            this.label8.TabIndex = 12;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // UC_DSNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dGV_DSNhaCungCap);
            this.Name = "UC_DSNhaCungCap";
            this.Size = new System.Drawing.Size(1478, 690);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSetBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_DSNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhaCungCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhaCungCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nhaCungCapsBindingSource;
        private RestaurantManagementDataSet1 restaurantManagementDataSet1;
        private System.Windows.Forms.BindingSource restaurantManagementDataSetBindingSource;
        private RestaurantManagementDataSet1TableAdapters.NhaCungCapsTableAdapter nhaCungCapsTableAdapter;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_SoDienThoai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_DiaChi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TenNCC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_MaNCC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
    }
}
