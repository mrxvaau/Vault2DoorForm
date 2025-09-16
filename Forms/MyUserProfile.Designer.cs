namespace Store.Forms
{
    partial class MyUserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyUserProfile));
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.updatepic = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.mobiletextBox = new System.Windows.Forms.TextBox();
            this.addresstextBox = new System.Windows.Forms.TextBox();
            this.backpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backpic)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.BackColor = System.Drawing.Color.Transparent;
            this.pbProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProfilePicture.Location = new System.Drawing.Point(935, 222);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(165, 126);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbProfilePicture.TabIndex = 1;
            this.pbProfilePicture.TabStop = false;
            this.pbProfilePicture.Click += new System.EventHandler(this.pbProfilePicture_Click);
            // 
            // updatepic
            // 
            this.updatepic.BackColor = System.Drawing.Color.DarkBlue;
            this.updatepic.ForeColor = System.Drawing.Color.Black;
            this.updatepic.Location = new System.Drawing.Point(935, 364);
            this.updatepic.Name = "updatepic";
            this.updatepic.Size = new System.Drawing.Size(165, 34);
            this.updatepic.TabIndex = 2;
            this.updatepic.Text = "Update Picture";
            this.updatepic.UseVisualStyleBackColor = false;
            this.updatepic.Click += new System.EventHandler(this.updatepic_Click);
            // 
            // editbutton
            // 
            this.editbutton.BackColor = System.Drawing.Color.Gray;
            this.editbutton.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.editbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editbutton.Location = new System.Drawing.Point(539, 554);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(212, 63);
            this.editbutton.TabIndex = 3;
            this.editbutton.Text = "Edit Profile";
            this.editbutton.UseVisualStyleBackColor = false;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.Color.Red;
            this.cancelbutton.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelbutton.Location = new System.Drawing.Point(870, 554);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(165, 63);
            this.cancelbutton.TabIndex = 4;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.ForestGreen;
            this.savebutton.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.savebutton.ForeColor = System.Drawing.Color.White;
            this.savebutton.Location = new System.Drawing.Point(250, 551);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(177, 66);
            this.savebutton.TabIndex = 5;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // usernametextBox
            // 
            this.usernametextBox.Location = new System.Drawing.Point(358, 239);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(497, 22);
            this.usernametextBox.TabIndex = 10;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(358, 309);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(497, 22);
            this.emailtextBox.TabIndex = 11;
            // 
            // mobiletextBox
            // 
            this.mobiletextBox.Location = new System.Drawing.Point(358, 384);
            this.mobiletextBox.Name = "mobiletextBox";
            this.mobiletextBox.Size = new System.Drawing.Size(497, 22);
            this.mobiletextBox.TabIndex = 12;
            // 
            // addresstextBox
            // 
            this.addresstextBox.Location = new System.Drawing.Point(360, 455);
            this.addresstextBox.Name = "addresstextBox";
            this.addresstextBox.Size = new System.Drawing.Size(495, 22);
            this.addresstextBox.TabIndex = 13;
            // 
            // backpic
            // 
            this.backpic.BackColor = System.Drawing.Color.Transparent;
            this.backpic.Image = global::Store.Properties.Resources.Back;
            this.backpic.Location = new System.Drawing.Point(1104, 44);
            this.backpic.Name = "backpic";
            this.backpic.Size = new System.Drawing.Size(47, 42);
            this.backpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backpic.TabIndex = 14;
            this.backpic.TabStop = false;
            this.backpic.Click += new System.EventHandler(this.backpic_Click);
            // 
            // MyUserProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1271, 716);
            this.Controls.Add(this.backpic);
            this.Controls.Add(this.addresstextBox);
            this.Controls.Add(this.mobiletextBox);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.usernametextBox);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.updatepic);
            this.Controls.Add(this.pbProfilePicture);
            this.Name = "MyUserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyUserProfile";
            this.Load += new System.EventHandler(this.MyUserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbProfilePicture;
        private System.Windows.Forms.Button updatepic;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox mobiletextBox;
        private System.Windows.Forms.TextBox addresstextBox;
        private System.Windows.Forms.PictureBox backpic;
    }
}