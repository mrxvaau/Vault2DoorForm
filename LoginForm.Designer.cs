namespace Store
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
            this.usernametext = new System.Windows.Forms.TextBox();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.Registerationbutton = new System.Windows.Forms.Button();
            this.forgotbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernametext
            // 
            this.usernametext.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.usernametext.Location = new System.Drawing.Point(510, 299);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(480, 22);
            this.usernametext.TabIndex = 2;
            // 
            // passwordtext
            // 
            this.passwordtext.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.passwordtext.Location = new System.Drawing.Point(510, 376);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(480, 22);
            this.passwordtext.TabIndex = 3;
            this.passwordtext.TextChanged += new System.EventHandler(this.passwordtext_TextChanged);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginbutton.Location = new System.Drawing.Point(750, 472);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(203, 62);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // Registerationbutton
            // 
            this.Registerationbutton.BackColor = System.Drawing.Color.Lime;
            this.Registerationbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Registerationbutton.Location = new System.Drawing.Point(510, 481);
            this.Registerationbutton.Name = "Registerationbutton";
            this.Registerationbutton.Size = new System.Drawing.Size(203, 53);
            this.Registerationbutton.TabIndex = 5;
            this.Registerationbutton.Text = "Register";
            this.Registerationbutton.UseVisualStyleBackColor = false;
            this.Registerationbutton.Click += new System.EventHandler(this.Registerationbutton_Click);
            // 
            // forgotbutton
            // 
            this.forgotbutton.BackColor = System.Drawing.Color.Red;
            this.forgotbutton.ForeColor = System.Drawing.Color.Black;
            this.forgotbutton.Location = new System.Drawing.Point(642, 563);
            this.forgotbutton.Name = "forgotbutton";
            this.forgotbutton.Size = new System.Drawing.Size(182, 29);
            this.forgotbutton.TabIndex = 6;
            this.forgotbutton.Text = "Forgotten Password?";
            this.forgotbutton.UseVisualStyleBackColor = false;
            this.forgotbutton.Click += new System.EventHandler(this.forgotbutton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Store.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(1281, 691);
            this.Controls.Add(this.forgotbutton);
            this.Controls.Add(this.Registerationbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.usernametext);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button Registerationbutton;
        private System.Windows.Forms.Button forgotbutton;
    }
}

