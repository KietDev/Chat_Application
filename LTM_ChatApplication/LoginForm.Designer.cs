
namespace LTM_ChatApplication
{
    partial class LoginForm
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
            this.UsernameTbox = new System.Windows.Forms.TextBox();
            this.PasswordTbox = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.regButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameTbox
            // 
            this.UsernameTbox.Location = new System.Drawing.Point(129, 129);
            this.UsernameTbox.Name = "UsernameTbox";
            this.UsernameTbox.Size = new System.Drawing.Size(403, 31);
            this.UsernameTbox.TabIndex = 0;
            // 
            // PasswordTbox
            // 
            this.PasswordTbox.Location = new System.Drawing.Point(129, 252);
            this.PasswordTbox.Name = "PasswordTbox";
            this.PasswordTbox.Size = new System.Drawing.Size(403, 31);
            this.PasswordTbox.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(129, 87);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(91, 25);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(129, 211);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(87, 25);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(129, 345);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(154, 43);
            this.regButton.TabIndex = 4;
            this.regButton.Text = "Regisration";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(378, 345);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(154, 43);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 509);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.PasswordTbox);
            this.Controls.Add(this.UsernameTbox);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTbox;
        private System.Windows.Forms.TextBox PasswordTbox;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Button loginButton;
    }
}