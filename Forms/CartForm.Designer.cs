namespace Store.Forms
{
    partial class CartForm
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
            this.lblProuct = new System.Windows.Forms.Label();
            this.lblKarat = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProuct
            // 
            this.lblProuct.AutoSize = true;
            this.lblProuct.BackColor = System.Drawing.Color.Transparent;
            this.lblProuct.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProuct.ForeColor = System.Drawing.Color.Khaki;
            this.lblProuct.Location = new System.Drawing.Point(660, 289);
            this.lblProuct.Name = "lblProuct";
            this.lblProuct.Size = new System.Drawing.Size(86, 32);
            this.lblProuct.TabIndex = 0;
            this.lblProuct.Text = "label1";
            // 
            // lblKarat
            // 
            this.lblKarat.AutoSize = true;
            this.lblKarat.BackColor = System.Drawing.Color.Transparent;
            this.lblKarat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblKarat.ForeColor = System.Drawing.Color.Khaki;
            this.lblKarat.Location = new System.Drawing.Point(660, 365);
            this.lblKarat.Name = "lblKarat";
            this.lblKarat.Size = new System.Drawing.Size(86, 32);
            this.lblKarat.TabIndex = 1;
            this.lblKarat.Text = "label2";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.Khaki;
            this.lblQuantity.Location = new System.Drawing.Point(660, 430);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(86, 32);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "label3";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Khaki;
            this.lblTotal.Location = new System.Drawing.Point(656, 496);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(86, 32);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "label4";
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.Lime;
            this.btnProceed.Location = new System.Drawing.Point(534, 555);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(244, 64);
            this.btnProceed.TabIndex = 4;
            this.btnProceed.Text = "Proced to Payment";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Store.Properties.Resources.Back;
            this.pictureBox1.Location = new System.Drawing.Point(1052, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CartForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Store.Properties.Resources.cart;
            this.ClientSize = new System.Drawing.Size(1187, 695);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblKarat);
            this.Controls.Add(this.lblProuct);
            this.Name = "CartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProuct;
        private System.Windows.Forms.Label lblKarat;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}