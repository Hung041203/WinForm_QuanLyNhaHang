namespace GUI
{
    partial class UC_DSMonAn
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
            this.dGV_DSMonAn = new System.Windows.Forms.DataGridView();
            this.maMonAnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonAnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongHienCoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monAnsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantManagementDataSet2 = new GUI.RestaurantManagementDataSet2();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_SoLuongHienCo = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_GiaTien = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TenMonAn = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_MaMonAn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.monAnsTableAdapter = new GUI.RestaurantManagementDataSet2TableAdapters.MonAnsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monAnsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_DSMonAn
            // 
            this.dGV_DSMonAn.AutoGenerateColumns = false;
            this.dGV_DSMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_DSMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMonAnDataGridViewTextBoxColumn,
            this.tenMonAnDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.soLuongHienCoDataGridViewTextBoxColumn});
            this.dGV_DSMonAn.DataSource = this.monAnsBindingSource;
            this.dGV_DSMonAn.Location = new System.Drawing.Point(578, 3);
            this.dGV_DSMonAn.Name = "dGV_DSMonAn";
            this.dGV_DSMonAn.RowHeadersWidth = 62;
            this.dGV_DSMonAn.RowTemplate.Height = 28;
            this.dGV_DSMonAn.Size = new System.Drawing.Size(900, 550);
            this.dGV_DSMonAn.TabIndex = 0;
            this.dGV_DSMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_DSMonAn_CellClick);
            // 
            // maMonAnDataGridViewTextBoxColumn
            // 
            this.maMonAnDataGridViewTextBoxColumn.DataPropertyName = "MaMonAn";
            this.maMonAnDataGridViewTextBoxColumn.HeaderText = "MaMonAn";
            this.maMonAnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maMonAnDataGridViewTextBoxColumn.Name = "maMonAnDataGridViewTextBoxColumn";
            this.maMonAnDataGridViewTextBoxColumn.ReadOnly = true;
            this.maMonAnDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenMonAnDataGridViewTextBoxColumn
            // 
            this.tenMonAnDataGridViewTextBoxColumn.DataPropertyName = "TenMonAn";
            this.tenMonAnDataGridViewTextBoxColumn.HeaderText = "TenMonAn";
            this.tenMonAnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenMonAnDataGridViewTextBoxColumn.Name = "tenMonAnDataGridViewTextBoxColumn";
            this.tenMonAnDataGridViewTextBoxColumn.Width = 150;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Gia";
            this.giaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            this.giaDataGridViewTextBoxColumn.Width = 150;
            // 
            // soLuongHienCoDataGridViewTextBoxColumn
            // 
            this.soLuongHienCoDataGridViewTextBoxColumn.DataPropertyName = "SoLuongHienCo";
            this.soLuongHienCoDataGridViewTextBoxColumn.HeaderText = "SoLuongHienCo";
            this.soLuongHienCoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soLuongHienCoDataGridViewTextBoxColumn.Name = "soLuongHienCoDataGridViewTextBoxColumn";
            this.soLuongHienCoDataGridViewTextBoxColumn.Width = 150;
            // 
            // monAnsBindingSource
            // 
            this.monAnsBindingSource.DataMember = "MonAns";
            this.monAnsBindingSource.DataSource = this.restaurantManagementDataSet2;
            // 
            // restaurantManagementDataSet2
            // 
            this.restaurantManagementDataSet2.DataSetName = "RestaurantManagementDataSet2";
            this.restaurantManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Linen;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.textBox_SoLuongHienCo);
            this.panel6.Location = new System.Drawing.Point(3, 500);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(520, 50);
            this.panel6.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(4, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng hiện có";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_SoLuongHienCo
            // 
            this.textBox_SoLuongHienCo.AllowDrop = true;
            this.textBox_SoLuongHienCo.BackColor = System.Drawing.Color.Linen;
            this.textBox_SoLuongHienCo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_SoLuongHienCo.Enabled = false;
            this.textBox_SoLuongHienCo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SoLuongHienCo.Location = new System.Drawing.Point(220, 3);
            this.textBox_SoLuongHienCo.Multiline = true;
            this.textBox_SoLuongHienCo.Name = "textBox_SoLuongHienCo";
            this.textBox_SoLuongHienCo.Size = new System.Drawing.Size(300, 40);
            this.textBox_SoLuongHienCo.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Linen;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.textBox_GiaTien);
            this.panel5.Location = new System.Drawing.Point(3, 350);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(520, 50);
            this.panel5.TabIndex = 14;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_TenMonAn);
            this.panel1.Location = new System.Drawing.Point(3, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 50);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên món ăn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_TenMonAn
            // 
            this.textBox_TenMonAn.AllowDrop = true;
            this.textBox_TenMonAn.BackColor = System.Drawing.Color.Linen;
            this.textBox_TenMonAn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_TenMonAn.Enabled = false;
            this.textBox_TenMonAn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenMonAn.Location = new System.Drawing.Point(220, 3);
            this.textBox_TenMonAn.Multiline = true;
            this.textBox_TenMonAn.Name = "textBox_TenMonAn";
            this.textBox_TenMonAn.Size = new System.Drawing.Size(300, 40);
            this.textBox_TenMonAn.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Linen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBox_MaMonAn);
            this.panel4.Location = new System.Drawing.Point(0, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 50);
            this.panel4.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(4, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã món ăn";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_MaMonAn
            // 
            this.textBox_MaMonAn.AllowDrop = true;
            this.textBox_MaMonAn.BackColor = System.Drawing.Color.Linen;
            this.textBox_MaMonAn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_MaMonAn.Enabled = false;
            this.textBox_MaMonAn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaMonAn.Location = new System.Drawing.Point(220, 3);
            this.textBox_MaMonAn.Multiline = true;
            this.textBox_MaMonAn.Name = "textBox_MaMonAn";
            this.textBox_MaMonAn.Size = new System.Drawing.Size(300, 40);
            this.textBox_MaMonAn.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Olive;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(545, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 690);
            this.label8.TabIndex = 16;
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
            this.panel7.TabIndex = 29;
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
            // monAnsTableAdapter
            // 
            this.monAnsTableAdapter.ClearBeforeFill = true;
            // 
            // UC_DSMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dGV_DSMonAn);
            this.Name = "UC_DSMonAn";
            this.Size = new System.Drawing.Size(1478, 690);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monAnsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_DSMonAn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_SoLuongHienCo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_GiaTien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TenMonAn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_MaMonAn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonAnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonAnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongHienCoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource monAnsBindingSource;
        private RestaurantManagementDataSet2 restaurantManagementDataSet2;
        private RestaurantManagementDataSet2TableAdapters.MonAnsTableAdapter monAnsTableAdapter;
    }
}
