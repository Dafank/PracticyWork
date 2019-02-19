namespace Library
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.emailError = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your password:";
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.SystemColors.Window;
            this.Email.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(299, 79);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(178, 26);
            this.Email.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(299, 123);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(178, 26);
            this.Password.TabIndex = 3;
            // 
            // Login_button
            // 
            this.Login_button.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.Location = new System.Drawing.Point(198, 224);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(142, 35);
            this.Login_button.TabIndex = 4;
            this.Login_button.Text = "Sign In";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // emailError
            // 
            this.emailError.AutoSize = true;
            this.emailError.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailError.ForeColor = System.Drawing.Color.Red;
            this.emailError.Location = new System.Drawing.Point(195, 169);
            this.emailError.Name = "emailError";
            this.emailError.Size = new System.Drawing.Size(136, 16);
            this.emailError.TabIndex = 5;
            this.emailError.Text = "Email can\'t be empty";
            this.emailError.Visible = false;
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordError.ForeColor = System.Drawing.Color.Red;
            this.passwordError.Location = new System.Drawing.Point(195, 196);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(160, 16);
            this.passwordError.TabIndex = 6;
            this.passwordError.Text = "Password can\'t be empty";
            this.passwordError.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 275);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordError);
            this.Controls.Add(this.emailError);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(545, 212);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Label emailError;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Label label3;
    }
}