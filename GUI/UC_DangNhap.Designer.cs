namespace GUI
{
    partial class UC_DangNhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel_ForgotPass = new System.Windows.Forms.LinkLabel();
            this.linkLabel_DangKy = new System.Windows.Forms.LinkLabel();
            this.checkBox_SavedUser = new System.Windows.Forms.CheckBox();
            this.button_DangNhap = new System.Windows.Forms.Button();
            this.checkBox_ShowPassWord = new System.Windows.Forms.CheckBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(261, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 55);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quản Lý Nhà Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel_ForgotPass);
            this.groupBox1.Controls.Add(this.linkLabel_DangKy);
            this.groupBox1.Controls.Add(this.checkBox_SavedUser);
            this.groupBox1.Controls.Add(this.button_DangNhap);
            this.groupBox1.Controls.Add(this.checkBox_ShowPassWord);
            this.groupBox1.Controls.Add(this.textBox_Password);
            this.groupBox1.Controls.Add(this.label_Password);
            this.groupBox1.Controls.Add(this.textBox_Username);
            this.groupBox1.Controls.Add(this.label_Username);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(404, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 380);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // linkLabel_ForgotPass
            // 
            this.linkLabel_ForgotPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_ForgotPass.Location = new System.Drawing.Point(130, 300);
            this.linkLabel_ForgotPass.Name = "linkLabel_ForgotPass";
            this.linkLabel_ForgotPass.Size = new System.Drawing.Size(300, 30);
            this.linkLabel_ForgotPass.TabIndex = 11;
            this.linkLabel_ForgotPass.TabStop = true;
            this.linkLabel_ForgotPass.Text = "Quên mật khẩu";
            this.linkLabel_ForgotPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_ForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ForgotPass_LinkClicked);
            // 
            // linkLabel_DangKy
            // 
            this.linkLabel_DangKy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_DangKy.Location = new System.Drawing.Point(130, 340);
            this.linkLabel_DangKy.Name = "linkLabel_DangKy";
            this.linkLabel_DangKy.Size = new System.Drawing.Size(300, 30);
            this.linkLabel_DangKy.TabIndex = 10;
            this.linkLabel_DangKy.TabStop = true;
            this.linkLabel_DangKy.Text = "Chưa có tài khoản? Đăng ký tại đây";
            this.linkLabel_DangKy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_DangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DangKy_LinkClicked);
            // 
            // checkBox_SavedUser
            // 
            this.checkBox_SavedUser.AutoSize = true;
            this.checkBox_SavedUser.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_SavedUser.Location = new System.Drawing.Point(383, 200);
            this.checkBox_SavedUser.Name = "checkBox_SavedUser";
            this.checkBox_SavedUser.Size = new System.Drawing.Size(122, 23);
            this.checkBox_SavedUser.TabIndex = 9;
            this.checkBox_SavedUser.Text = "Nhớ tài khoản";
            this.checkBox_SavedUser.UseVisualStyleBackColor = true;
            // 
            // button_DangNhap
            // 
            this.button_DangNhap.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_DangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangNhap.Location = new System.Drawing.Point(130, 240);
            this.button_DangNhap.Name = "button_DangNhap";
            this.button_DangNhap.Size = new System.Drawing.Size(300, 50);
            this.button_DangNhap.TabIndex = 4;
            this.button_DangNhap.Text = "Đăng nhập";
            this.button_DangNhap.UseVisualStyleBackColor = false;
            this.button_DangNhap.Click += new System.EventHandler(this.button_DangNhap_Click);
            // 
            // checkBox_ShowPassWord
            // 
            this.checkBox_ShowPassWord.AutoSize = true;
            this.checkBox_ShowPassWord.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ShowPassWord.Location = new System.Drawing.Point(55, 200);
            this.checkBox_ShowPassWord.Name = "checkBox_ShowPassWord";
            this.checkBox_ShowPassWord.Size = new System.Drawing.Size(125, 23);
            this.checkBox_ShowPassWord.TabIndex = 8;
            this.checkBox_ShowPassWord.Text = "Hiện mật khẩu";
            this.checkBox_ShowPassWord.UseVisualStyleBackColor = true;
            this.checkBox_ShowPassWord.CheckedChanged += new System.EventHandler(this.checkBox_ShowPassWord_CheckedChanged);
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_Password.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(55, 160);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(450, 34);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(50, 130);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(107, 27);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password:";
            // 
            // textBox_Username
            // 
            this.textBox_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_Username.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(55, 80);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(450, 34);
            this.textBox_Username.TabIndex = 1;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(50, 50);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(112, 27);
            this.label_Username.TabIndex = 0;
            this.label_Username.Text = "Username:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::GUI.Properties.Resources.DangNhap;
            this.pictureBox1.Location = new System.Drawing.Point(6, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // UC_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_DangNhap";
            this.Size = new System.Drawing.Size(975, 497);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel_ForgotPass;
        private System.Windows.Forms.LinkLabel linkLabel_DangKy;
        private System.Windows.Forms.CheckBox checkBox_SavedUser;
        private System.Windows.Forms.Button button_DangNhap;
        private System.Windows.Forms.CheckBox checkBox_ShowPassWord;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_Username;
    }
}
