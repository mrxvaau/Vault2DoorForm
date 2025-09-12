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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(409, 118);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 16);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "amount";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(312, 315);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(111, 59);
            this.btnPlaceOrder.TabIndex = 1;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // radioBkash
            // 
            this.radioBkash.AutoSize = true;
            this.radioBkash.Location = new System.Drawing.Point(209, 236);
            this.radioBkash.Name = "radioBkash";
            this.radioBkash.Size = new System.Drawing.Size(66, 20);
            this.radioBkash.TabIndex = 2;
            this.radioBkash.TabStop = true;
            this.radioBkash.Text = "Bkash";
            this.radioBkash.UseVisualStyleBackColor = true;
            // 
            // radioNagad
            // 
            this.radioNagad.AutoSize = true;
            this.radioNagad.Location = new System.Drawing.Point(338, 236);
            this.radioNagad.Name = "radioNagad";
            this.radioNagad.Size = new System.Drawing.Size(62, 20);
            this.radioNagad.TabIndex = 3;
            this.radioNagad.TabStop = true;
            this.radioNagad.Text = "Ngad";
            this.radioNagad.UseVisualStyleBackColor = true;
            // 
            // radiocash
            // 
            this.radiocash.AutoSize = true;
            this.radiocash.Location = new System.Drawing.Point(448, 236);
            this.radiocash.Name = "radiocash";
            this.radiocash.Size = new System.Drawing.Size(130, 20);
            this.radiocash.TabIndex = 4;
            this.radiocash.TabStop = true;
            this.radiocash.Text = "Cash on Delivery";
            this.radiocash.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "You have to pay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose how you want to pay ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Make Payment";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radiocash);
            this.Controls.Add(this.radioNagad);
            this.Controls.Add(this.radioBkash);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.lblAmount);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.RadioButton radioBkash;
        private System.Windows.Forms.RadioButton radioNagad;
        private System.Windows.Forms.RadioButton radiocash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}