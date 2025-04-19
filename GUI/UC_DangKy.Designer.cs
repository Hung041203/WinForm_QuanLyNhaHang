namespace GUI
{
    partial class UC_DangKy
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Position = new System.Windows.Forms.TextBox();
            this.label_TenChucVu = new System.Windows.Forms.Label();
            this.comboBox_ID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ConfirmPass = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_ShowPassWord = new System.Windows.Forms.CheckBox();
            this.button_DangKy = new System.Windows.Forms.Button();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_MaNhanVien = new System.Windows.Forms.Label();
            this.button_QuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.DangKy;
            this.pictureBox1.Location = new System.Drawing.Point(552, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(261, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 55);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quản Lý Nhà Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Position);
            this.groupBox1.Controls.Add(this.label_TenChucVu);
            this.groupBox1.Controls.Add(this.comboBox_ID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_ConfirmPass);
            this.groupBox1.Controls.Add(this.textBox_Password);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox_ShowPassWord);
            this.groupBox1.Controls.Add(this.button_DangKy);
            this.groupBox1.Controls.Add(this.textBox_Username);
            this.groupBox1.Controls.Add(this.label_Password);
            this.groupBox1.Controls.Add(this.label_MaNhanVien);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 427);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng ký tài khoản mới";
            // 
            // textBox_Position
            // 
            this.textBox_Position.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_Position.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Position.Location = new System.Drawing.Point(170, 107);
            this.textBox_Position.Name = "textBox_Position";
            this.textBox_Position.ReadOnly = true;
            this.textBox_Position.Size = new System.Drawing.Size(360, 34);
            this.textBox_Position.TabIndex = 14;
            // 
            // label_TenChucVu
            // 
            this.label_TenChucVu.AutoSize = true;
            this.label_TenChucVu.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenChucVu.Location = new System.Drawing.Point(10, 110);
            this.label_TenChucVu.Name = "label_TenChucVu";
            this.label_TenChucVu.Size = new System.Drawing.Size(100, 27);
            this.label_TenChucVu.TabIndex = 13;
            this.label_TenChucVu.Text = "Positions";
            // 
            // comboBox_ID
            // 
            this.comboBox_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox_ID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ID.FormattingEnabled = true;
            this.comboBox_ID.Location = new System.Drawing.Point(170, 47);
            this.comboBox_ID.Name = "comboBox_ID";
            this.comboBox_ID.Size = new System.Drawing.Size(360, 36);
            this.comboBox_ID.TabIndex = 1;
            this.comboBox_ID.SelectedIndexChanged += new System.EventHandler(this.comboBox_ID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Confirm:";
            // 
            // textBox_ConfirmPass
            // 
            this.textBox_ConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_ConfirmPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ConfirmPass.Location = new System.Drawing.Point(170, 287);
            this.textBox_ConfirmPass.Name = "textBox_ConfirmPass";
            this.textBox_ConfirmPass.Size = new System.Drawing.Size(360, 34);
            this.textBox_ConfirmPass.TabIndex = 4;
            this.textBox_ConfirmPass.UseSystemPasswordChar = true;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_Password.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(170, 227);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(360, 34);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password:";
            // 
            // checkBox_ShowPassWord
            // 
            this.checkBox_ShowPassWord.AutoSize = true;
            this.checkBox_ShowPassWord.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ShowPassWord.Location = new System.Drawing.Point(170, 327);
            this.checkBox_ShowPassWord.Name = "checkBox_ShowPassWord";
            this.checkBox_ShowPassWord.Size = new System.Drawing.Size(125, 23);
            this.checkBox_ShowPassWord.TabIndex = 7;
            this.checkBox_ShowPassWord.Text = "Hiện mật khẩu";
            this.checkBox_ShowPassWord.UseVisualStyleBackColor = true;
            this.checkBox_ShowPassWord.CheckedChanged += new System.EventHandler(this.checkBox_ShowPassWord_CheckedChanged);
            // 
            // button_DangKy
            // 
            this.button_DangKy.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_DangKy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_DangKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangKy.Location = new System.Drawing.Point(122, 367);
            this.button_DangKy.Name = "button_DangKy";
            this.button_DangKy.Size = new System.Drawing.Size(300, 50);
            this.button_DangKy.TabIndex = 5;
            this.button_DangKy.Text = "Đăng ký";
            this.button_DangKy.UseVisualStyleBackColor = false;
            this.button_DangKy.Click += new System.EventHandler(this.button_DangKy_Click);
            // 
            // textBox_Username
            // 
            this.textBox_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_Username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(170, 167);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(360, 34);
            this.textBox_Username.TabIndex = 2;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(10, 170);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(112, 27);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Username:";
            // 
            // label_MaNhanVien
            // 
            this.label_MaNhanVien.AutoSize = true;
            this.label_MaNhanVien.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaNhanVien.Location = new System.Drawing.Point(10, 50);
            this.label_MaNhanVien.Name = "label_MaNhanVien";
            this.label_MaNhanVien.Size = new System.Drawing.Size(38, 27);
            this.label_MaNhanVien.TabIndex = 0;
            this.label_MaNhanVien.Text = "ID:";
            // 
            // button_QuayLai
            // 
            this.button_QuayLai.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_QuayLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QuayLai.Location = new System.Drawing.Point(10, 20);
            this.button_QuayLai.Name = "button_QuayLai";
            this.button_QuayLai.Size = new System.Drawing.Size(120, 50);
            this.button_QuayLai.TabIndex = 10;
            this.button_QuayLai.Text = "Quay lại";
            this.button_QuayLai.UseVisualStyleBackColor = false;
            this.button_QuayLai.Click += new System.EventHandler(this.button_QuayLai_Click);
            // 
            // UC_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_QuayLai);
            this.Name = "UC_DangKy";
            this.Size = new System.Drawing.Size(975, 541);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Position;
        private System.Windows.Forms.Label label_TenChucVu;
        private System.Windows.Forms.ComboBox comboBox_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ConfirmPass;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_ShowPassWord;
        private System.Windows.Forms.Button button_DangKy;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_MaNhanVien;
        private System.Windows.Forms.Button button_QuayLai;
    }
}
