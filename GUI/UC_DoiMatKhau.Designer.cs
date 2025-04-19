namespace GUI
{
    partial class UC_DoiMatKhau
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_01 = new System.Windows.Forms.Panel();
            this.button_DangKy = new System.Windows.Forms.Button();
            this.checkBox_ShowPassWord = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CurrentPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ConfirmPass = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_NewPassword = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel_01.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1478, 100);
            this.label2.TabIndex = 6;
            this.label2.Text = "ĐỔI MẬT KHẨU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 10);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_01);
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1478, 580);
            this.panel2.TabIndex = 7;
            // 
            // panel_01
            // 
            this.panel_01.Controls.Add(this.button_DangKy);
            this.panel_01.Controls.Add(this.checkBox_ShowPassWord);
            this.panel_01.Controls.Add(this.label9);
            this.panel_01.Controls.Add(this.panel4);
            this.panel_01.Controls.Add(this.label8);
            this.panel_01.Controls.Add(this.panel6);
            this.panel_01.Controls.Add(this.panel5);
            this.panel_01.Location = new System.Drawing.Point(426, 50);
            this.panel_01.Name = "panel_01";
            this.panel_01.Size = new System.Drawing.Size(625, 460);
            this.panel_01.TabIndex = 12;
            // 
            // button_DangKy
            // 
            this.button_DangKy.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_DangKy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_DangKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangKy.Location = new System.Drawing.Point(162, 410);
            this.button_DangKy.Name = "button_DangKy";
            this.button_DangKy.Size = new System.Drawing.Size(300, 50);
            this.button_DangKy.TabIndex = 14;
            this.button_DangKy.Text = "Lưu mật khẩu";
            this.button_DangKy.UseVisualStyleBackColor = false;
            this.button_DangKy.Click += new System.EventHandler(this.button_DangKy_Click);
            // 
            // checkBox_ShowPassWord
            // 
            this.checkBox_ShowPassWord.AutoSize = true;
            this.checkBox_ShowPassWord.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ShowPassWord.Location = new System.Drawing.Point(24, 300);
            this.checkBox_ShowPassWord.Name = "checkBox_ShowPassWord";
            this.checkBox_ShowPassWord.Size = new System.Drawing.Size(125, 23);
            this.checkBox_ShowPassWord.TabIndex = 13;
            this.checkBox_ShowPassWord.Text = "Hiện mật khẩu";
            this.checkBox_ShowPassWord.UseVisualStyleBackColor = true;
            this.checkBox_ShowPassWord.CheckedChanged += new System.EventHandler(this.checkBox_ShowPassWord_CheckedChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Olive;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(615, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 460);
            this.label9.TabIndex = 11;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Linen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBox_CurrentPassword);
            this.panel4.Location = new System.Drawing.Point(12, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 50);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Current Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_CurrentPassword
            // 
            this.textBox_CurrentPassword.BackColor = System.Drawing.Color.Linen;
            this.textBox_CurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CurrentPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrentPassword.Location = new System.Drawing.Point(247, 3);
            this.textBox_CurrentPassword.Name = "textBox_CurrentPassword";
            this.textBox_CurrentPassword.Size = new System.Drawing.Size(350, 32);
            this.textBox_CurrentPassword.TabIndex = 1;
            this.textBox_CurrentPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Olive;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 460);
            this.label8.TabIndex = 8;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Linen;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.textBox_ConfirmPass);
            this.panel6.Location = new System.Drawing.Point(12, 200);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(600, 50);
            this.panel6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(4, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Confirm Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ConfirmPass
            // 
            this.textBox_ConfirmPass.BackColor = System.Drawing.Color.Linen;
            this.textBox_ConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ConfirmPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ConfirmPass.Location = new System.Drawing.Point(247, 3);
            this.textBox_ConfirmPass.Name = "textBox_ConfirmPass";
            this.textBox_ConfirmPass.Size = new System.Drawing.Size(350, 32);
            this.textBox_ConfirmPass.TabIndex = 1;
            this.textBox_ConfirmPass.UseSystemPasswordChar = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Linen;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.textBox_NewPassword);
            this.panel5.Location = new System.Drawing.Point(12, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 50);
            this.panel5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "New Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_NewPassword
            // 
            this.textBox_NewPassword.BackColor = System.Drawing.Color.Linen;
            this.textBox_NewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_NewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NewPassword.Location = new System.Drawing.Point(247, 3);
            this.textBox_NewPassword.Name = "textBox_NewPassword";
            this.textBox_NewPassword.Size = new System.Drawing.Size(350, 32);
            this.textBox_NewPassword.TabIndex = 1;
            this.textBox_NewPassword.UseSystemPasswordChar = true;
            // 
            // UC_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UC_DoiMatKhau";
            this.Size = new System.Drawing.Size(1478, 690);
            this.panel2.ResumeLayout(false);
            this.panel_01.ResumeLayout(false);
            this.panel_01.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_01;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_CurrentPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ConfirmPass;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_NewPassword;
        private System.Windows.Forms.CheckBox checkBox_ShowPassWord;
        private System.Windows.Forms.Button button_DangKy;
    }
}
