
namespace Restaurant_Management
{
    partial class Login_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameTbox = new System.Windows.Forms.TextBox();
            this.passwordTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.managerOpt = new System.Windows.Forms.RadioButton();
            this.staffOpt = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTbox
            // 
            this.usernameTbox.Location = new System.Drawing.Point(344, 153);
            this.usernameTbox.Name = "usernameTbox";
            this.usernameTbox.Size = new System.Drawing.Size(363, 31);
            this.usernameTbox.TabIndex = 0;
            // 
            // passwordTbox
            // 
            this.passwordTbox.Location = new System.Drawing.Point(344, 257);
            this.passwordTbox.Name = "passwordTbox";
            this.passwordTbox.Size = new System.Drawing.Size(363, 31);
            this.passwordTbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu:";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(296, 390);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(112, 34);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Đăng nhập";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // managerOpt
            // 
            this.managerOpt.AutoSize = true;
            this.managerOpt.Checked = true;
            this.managerOpt.Location = new System.Drawing.Point(3, 3);
            this.managerOpt.Name = "managerOpt";
            this.managerOpt.Size = new System.Drawing.Size(93, 29);
            this.managerOpt.TabIndex = 6;
            this.managerOpt.TabStop = true;
            this.managerOpt.Text = "Quản lí";
            this.managerOpt.UseVisualStyleBackColor = true;
            // 
            // staffOpt
            // 
            this.staffOpt.AutoSize = true;
            this.staffOpt.Location = new System.Drawing.Point(161, 3);
            this.staffOpt.Name = "staffOpt";
            this.staffOpt.Size = new System.Drawing.Size(116, 29);
            this.staffOpt.TabIndex = 7;
            this.staffOpt.Text = "Nhân viên";
            this.staffOpt.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.managerOpt);
            this.panel1.Controls.Add(this.staffOpt);
            this.panel1.Location = new System.Drawing.Point(380, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 35);
            this.panel1.TabIndex = 8;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTbox);
            this.Controls.Add(this.usernameTbox);
            this.Name = "Login_Form";
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTbox;
        private System.Windows.Forms.TextBox passwordTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.RadioButton managerOpt;
        private System.Windows.Forms.RadioButton staffOpt;
        private System.Windows.Forms.Panel panel1;
    }
}