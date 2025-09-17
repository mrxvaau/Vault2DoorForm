namespace Store.Forms
{
    partial class GoldVariants
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.earRing1 = new System.Windows.Forms.PictureBox();
            this.earRing3 = new System.Windows.Forms.PictureBox();
            this.earRing2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.earRing1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.earRing3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.earRing2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Store.Properties.Resources.Back;
            this.pictureBox4.Location = new System.Drawing.Point(1111, 116);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // earRing1
            // 
            this.earRing1.BackColor = System.Drawing.Color.Transparent;
            this.earRing1.Image = global::Store.Properties.Resources.gold24;
            this.earRing1.Location = new System.Drawing.Point(115, 265);
            this.earRing1.Name = "earRing1";
            this.earRing1.Size = new System.Drawing.Size(256, 289);
            this.earRing1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.earRing1.TabIndex = 2;
            this.earRing1.TabStop = false;
            this.earRing1.Click += new System.EventHandler(this.earRing1_Click);
            // 
            // earRing3
            // 
            this.earRing3.BackColor = System.Drawing.Color.Transparent;
            this.earRing3.Image = global::Store.Properties.Resources.gold18;
            this.earRing3.Location = new System.Drawing.Point(929, 262);
            this.earRing3.Name = "earRing3";
            this.earRing3.Size = new System.Drawing.Size(146, 296);
            this.earRing3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.earRing3.TabIndex = 1;
            this.earRing3.TabStop = false;
            this.earRing3.Click += new System.EventHandler(this.earRing3_Click);
            // 
            // earRing2
            // 
            this.earRing2.BackColor = System.Drawing.Color.Transparent;
            this.earRing2.Image = global::Store.Properties.Resources.gold22;
            this.earRing2.Location = new System.Drawing.Point(546, 267);
            this.earRing2.Name = "earRing2";
            this.earRing2.Size = new System.Drawing.Size(162, 289);
            this.earRing2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.earRing2.TabIndex = 0;
            this.earRing2.TabStop = false;
            this.earRing2.Click += new System.EventHandler(this.earRing2_Click);
            // 
            // GoldVariants
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Store.Properties.Resources.goldV;
            this.ClientSize = new System.Drawing.Size(1245, 751);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.earRing1);
            this.Controls.Add(this.earRing3);
            this.Controls.Add(this.earRing2);
            this.Name = "GoldVariants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoldVariants";
            this.Load += new System.EventHandler(this.MyEarring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.earRing1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.earRing3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.earRing2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox earRing2;
        private System.Windows.Forms.PictureBox earRing3;
        private System.Windows.Forms.PictureBox earRing1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}