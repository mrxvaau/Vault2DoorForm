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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.confirmtext = new System.Windows.Forms.TextBox();
            this.Addresstext = new System.Windows.Forms.TextBox();
            this.mobiletext = new System.Windows.Forms.TextBox();
            this.registerbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.rolecomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Moblie Number";
            // 
            // usernametext
            // 
            this.usernametext.Location = new System.Drawing.Point(281, 71);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(136, 22);
            this.usernametext.TabIndex = 6;
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(281, 117);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(134, 22);
            this.emailtext.TabIndex = 7;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(279, 174);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(136, 22);
            this.passwordBox.TabIndex = 8;
            // 
            // confirmtext
            // 
            this.confirmtext.Location = new System.Drawing.Point(279, 228);
            this.confirmtext.Name = "confirmtext";
            this.confirmtext.Size = new System.Drawing.Size(134, 22);
            this.confirmtext.TabIndex = 9;
            // 
            // Addresstext
            // 
            this.Addresstext.Location = new System.Drawing.Point(281, 274);
            this.Addresstext.Name = "Addresstext";
            this.Addresstext.Size = new System.Drawing.Size(137, 22);
            this.Addresstext.TabIndex = 10;
            // 
            // mobiletext
            // 
            this.mobiletext.Location = new System.Drawing.Point(279, 314);
            this.mobiletext.Name = "mobiletext";
            this.mobiletext.Size = new System.Drawing.Size(134, 22);
            this.mobiletext.TabIndex = 11;
            // 
            // registerbutton
            // 
            this.registerbutton.BackColor = System.Drawing.Color.Lime;
            this.registerbutton.Location = new System.Drawing.Point(272, 411);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(129, 38);
            this.registerbutton.TabIndex = 12;
            this.registerbutton.Text = "Register";
            this.registerbutton.UseVisualStyleBackColor = false;
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.Color.Red;
            this.cancelbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelbutton.Location = new System.Drawing.Point(664, 33);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(108, 37);
            this.cancelbutton.TabIndex = 13;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // rolecomboBox
            // 
            this.rolecomboBox.FormattingEnabled = true;
            this.rolecomboBox.Location = new System.Drawing.Point(281, 357);
            this.rolecomboBox.Name = "rolecomboBox";
            this.rolecomboBox.Size = new System.Drawing.Size(70, 24);
            this.rolecomboBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Role";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(266, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "Register Account";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rolecomboBox);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.registerbutton);
            this.Controls.Add(this.mobiletext);
            this.Controls.Add(this.Addresstext);
            this.Controls.Add(this.confirmtext);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox confirmtext;
        private System.Windows.Forms.TextBox Addresstext;
        private System.Windows.Forms.TextBox mobiletext;
        private System.Windows.Forms.Button registerbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.ComboBox rolecomboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}