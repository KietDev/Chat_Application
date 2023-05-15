
namespace LTM_ChatApplication
{
    partial class RegisterationForm
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
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.PasswordTbox = new System.Windows.Forms.TextBox();
            this.UsernameTbox = new System.Windows.Forms.TextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmPasswordTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FullNameTbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(138, 131);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(87, 25);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(134, 35);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(91, 25);
            this.Username.TabIndex = 6;
            this.Username.Text = "Username";
            // 
            // PasswordTbox
            // 
            this.PasswordTbox.Location = new System.Drawing.Point(134, 172);
            this.PasswordTbox.Name = "PasswordTbox";
            this.PasswordTbox.Size = new System.Drawing.Size(403, 31);
            this.PasswordTbox.TabIndex = 5;
            // 
            // UsernameTbox
            // 
            this.UsernameTbox.Location = new System.Drawing.Point(134, 73);
            this.UsernameTbox.Name = "UsernameTbox";
            this.UsernameTbox.Size = new System.Drawing.Size(403, 31);
            this.UsernameTbox.TabIndex = 4;
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(249, 436);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(154, 43);
            this.regButton.TabIndex = 8;
            this.regButton.Text = "Register";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Confirm Password";
            // 
            // ConfirmPasswordTbox
            // 
            this.ConfirmPasswordTbox.Location = new System.Drawing.Point(138, 272);
            this.ConfirmPasswordTbox.Name = "ConfirmPasswordTbox";
            this.ConfirmPasswordTbox.Size = new System.Drawing.Size(403, 31);
            this.ConfirmPasswordTbox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Full name";
            // 
            // FullNameTbox
            // 
            this.FullNameTbox.Location = new System.Drawing.Point(134, 363);
            this.FullNameTbox.Name = "FullNameTbox";
            this.FullNameTbox.Size = new System.Drawing.Size(403, 31);
            this.FullNameTbox.TabIndex = 11;
            // 
            // RegisterationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 509);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FullNameTbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmPasswordTbox);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.PasswordTbox);
            this.Controls.Add(this.UsernameTbox);
            this.Name = "RegisterationForm";
            this.Text = "RegisterationForm";
            this.Load += new System.EventHandler(this.RegisterationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox PasswordTbox;
        private System.Windows.Forms.TextBox UsernameTbox;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ConfirmPasswordTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FullNameTbox;
    }
}