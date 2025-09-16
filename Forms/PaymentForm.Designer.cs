namespace Store.Forms
{
    partial class PaymentForm
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.radioBkash = new System.Windows.Forms.RadioButton();
            this.radioNagad = new System.Windows.Forms.RadioButton();
            this.radiocash = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Yellow;
            this.lblAmount.Location = new System.Drawing.Point(688, 278);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(128, 37);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "amount";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.Lime;
            this.btnPlaceOrder.Location = new System.Drawing.Point(569, 546);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(185, 59);
            this.btnPlaceOrder.TabIndex = 1;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // radioBkash
            // 
            this.radioBkash.AutoSize = true;
            this.radioBkash.BackColor = System.Drawing.Color.Transparent;
            this.radioBkash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioBkash.Location = new System.Drawing.Point(423, 483);
            this.radioBkash.Name = "radioBkash";
            this.radioBkash.Size = new System.Drawing.Size(66, 20);
            this.radioBkash.TabIndex = 2;
            this.radioBkash.TabStop = true;
            this.radioBkash.Text = "Bkash";
            this.radioBkash.UseVisualStyleBackColor = false;
            this.radioBkash.CheckedChanged += new System.EventHandler(this.radioBkash_CheckedChanged);
            // 
            // radioNagad
            // 
            this.radioNagad.AutoSize = true;
            this.radioNagad.BackColor = System.Drawing.Color.Transparent;
            this.radioNagad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioNagad.Location = new System.Drawing.Point(597, 483);
            this.radioNagad.Name = "radioNagad";
            this.radioNagad.Size = new System.Drawing.Size(70, 20);
            this.radioNagad.TabIndex = 3;
            this.radioNagad.TabStop = true;
            this.radioNagad.Text = "Nagad";
            this.radioNagad.UseVisualStyleBackColor = false;
            // 
            // radiocash
            // 
            this.radiocash.AutoSize = true;
            this.radiocash.BackColor = System.Drawing.Color.Transparent;
            this.radiocash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radiocash.Location = new System.Drawing.Point(760, 483);
            this.radiocash.Name = "radiocash";
            this.radiocash.Size = new System.Drawing.Size(130, 20);
            this.radiocash.TabIndex = 4;
            this.radiocash.TabStop = true;
            this.radiocash.Text = "Cash on Delivery";
            this.radiocash.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Store.Properties.Resources.cash_on_delivery;
            this.pictureBox3.Location = new System.Drawing.Point(777, 427);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Store.Properties.Resources.BKash_Icon_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(407, 427);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Store.Properties.Resources.Nagad_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(586, 427);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // PaymentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Store.Properties.Resources.payment;
            this.ClientSize = new System.Drawing.Size(1226, 715);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radiocash);
            this.Controls.Add(this.radioNagad);
            this.Controls.Add(this.radioBkash);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.lblAmount);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.RadioButton radioBkash;
        private System.Windows.Forms.RadioButton radioNagad;
        private System.Windows.Forms.RadioButton radiocash;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}