namespace GUI
{
    partial class UC_DSChucVu
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
            this.dataGridView_DSChucVu = new System.Windows.Forms.DataGridView();
            this.restaurantManagementDataSet3 = new GUI.RestaurantManagementDataSet3();
            this.chucVusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chucVusTableAdapter = new GUI.RestaurantManagementDataSet3TableAdapters.ChucVusTableAdapter();
            this.maChucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenChucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_DSChucVu
            // 
            this.dataGridView_DSChucVu.AutoGenerateColumns = false;
            this.dataGridView_DSChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maChucVuDataGridViewTextBoxColumn,
            this.tenChucVuDataGridViewTextBoxColumn});
            this.dataGridView_DSChucVu.DataSource = this.chucVusBindingSource;
            this.dataGridView_DSChucVu.Location = new System.Drawing.Point(439, 70);
            this.dataGridView_DSChucVu.Name = "dataGridView_DSChucVu";
            this.dataGridView_DSChucVu.RowHeadersWidth = 62;
            this.dataGridView_DSChucVu.RowTemplate.Height = 28;
            this.dataGridView_DSChucVu.Size = new System.Drawing.Size(600, 500);
            this.dataGridView_DSChucVu.TabIndex = 0;
            // 
            // restaurantManagementDataSet3
            // 
            this.restaurantManagementDataSet3.DataSetName = "RestaurantManagementDataSet3";
            this.restaurantManagementDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chucVusBindingSource
            // 
            this.chucVusBindingSource.DataMember = "ChucVus";
            this.chucVusBindingSource.DataSource = this.restaurantManagementDataSet3;
            // 
            // chucVusTableAdapter
            // 
            this.chucVusTableAdapter.ClearBeforeFill = true;
            // 
            // maChucVuDataGridViewTextBoxColumn
            // 
            this.maChucVuDataGridViewTextBoxColumn.DataPropertyName = "MaChucVu";
            this.maChucVuDataGridViewTextBoxColumn.HeaderText = "MaChucVu";
            this.maChucVuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maChucVuDataGridViewTextBoxColumn.Name = "maChucVuDataGridViewTextBoxColumn";
            this.maChucVuDataGridViewTextBoxColumn.ReadOnly = true;
            this.maChucVuDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenChucVuDataGridViewTextBoxColumn
            // 
            this.tenChucVuDataGridViewTextBoxColumn.DataPropertyName = "TenChucVu";
            this.tenChucVuDataGridViewTextBoxColumn.HeaderText = "TenChucVu";
            this.tenChucVuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenChucVuDataGridViewTextBoxColumn.Name = "tenChucVuDataGridViewTextBoxColumn";
            this.tenChucVuDataGridViewTextBoxColumn.Width = 150;
            // 
            // UC_ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.dataGridView_DSChucVu);
            this.Name = "UC_ChucVu";
            this.Size = new System.Drawing.Size(1478, 690);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_DSChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenChucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource chucVusBindingSource;
        private RestaurantManagementDataSet3 restaurantManagementDataSet3;
        private RestaurantManagementDataSet3TableAdapters.ChucVusTableAdapter chucVusTableAdapter;
    }
}
