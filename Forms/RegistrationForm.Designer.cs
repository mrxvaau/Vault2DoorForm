namespace Store.Forms
{
    partial class RegistrationForm
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
            this.emailtext = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.confirmtext = new System.Windows.Forms.TextBox();
            this.Addresstext = new System.Windows.Forms.TextBox();
            this.mobiletext = new System.Windows.Forms.TextBox();
            this.registerbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.rolecomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // usernametext
            // 
            this.usernametext.BackColor = System.Drawing.Color.White;
            this.usernametext.Location = new System.Drawing.Point(455, 239);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(573, 22);
            this.usernametext.TabIndex = 6;
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(455, 291);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(573, 22);
            this.emailtext.TabIndex = 7;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(455, 345);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(573, 22);
            this.passwordBox.TabIndex = 8;
            // 
            // confirmtext
            // 
            this.confirmtext.Location = new System.Drawing.Point(455, 403);
            this.confirmtext.Name = "confirmtext";
            this.confirmtext.Size = new System.Drawing.Size(573, 22);
            this.confirmtext.TabIndex = 9;
            // 
            // Addresstext
            // 
            this.Addresstext.Location = new System.Drawing.Point(455, 455);
            this.Addresstext.Name = "Addresstext";
            this.Addresstext.Size = new System.Drawing.Size(573, 22);
            this.Addresstext.TabIndex = 10;
            // 
            // mobiletext
            // 
            this.mobiletext.Location = new System.Drawing.Point(455, 507);
            this.mobiletext.Name = "mobiletext";
            this.mobiletext.Size = new System.Drawing.Size(573, 22);
            this.mobiletext.TabIndex = 11;
            // 
            // registerbutton
            // 
            this.registerbutton.BackColor = System.Drawing.Color.Lime;
            this.registerbutton.Location = new System.Drawing.Point(591, 607);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(183, 42);
            this.registerbutton.TabIndex = 12;
            this.registerbutton.Text = "Register";
            this.registerbutton.UseVisualStyleBackColor = false;
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.Color.Red;
            this.cancelbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelbutton.Location = new System.Drawing.Point(1031, 121);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(151, 45);
            this.cancelbutton.TabIndex = 13;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // rolecomboBox
            // 
            this.rolecomboBox.FormattingEnabled = true;
            this.rolecomboBox.Location = new System.Drawing.Point(455, 562);
            this.rolecomboBox.Name = "rolecomboBox";
            this.rolecomboBox.Size = new System.Drawing.Size(573, 24);
            this.rolecomboBox.TabIndex = 14;
            // 
            // RegistrationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Store.Properties.Resources.register;
            this.ClientSize = new System.Drawing.Size(1317, 728);
            this.Controls.Add(this.rolecomboBox);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.registerbutton);
            this.Controls.Add(this.mobiletext);
            this.Controls.Add(this.Addresstext);
            this.Controls.Add(this.confirmtext);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.usernametext);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox confirmtext;
        private System.Windows.Forms.TextBox Addresstext;
        private System.Windows.Forms.TextBox mobiletext;
        private System.Windows.Forms.Button registerbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.ComboBox rolecomboBox;
    }
}