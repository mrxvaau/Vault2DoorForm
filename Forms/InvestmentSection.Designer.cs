namespace Store.Forms
{
    partial class InvestmentSection
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
            this.radio1g = new System.Windows.Forms.RadioButton();
            this.radio5g = new System.Windows.Forms.RadioButton();
            this.radio10g = new System.Windows.Forms.RadioButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Button();
            this.lblMinus = new System.Windows.Forms.Button();
            this.btnBuyNow = new System.Windows.Forms.Button();
            this.btnSellGold = new System.Windows.Forms.Button();
            this.lblCurrentPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radio1g
            // 
            this.radio1g.AutoSize = true;
            this.radio1g.BackColor = System.Drawing.Color.Transparent;
            this.radio1g.Location = new System.Drawing.Point(122, 321);
            this.radio1g.Name = "radio1g";
            this.radio1g.Size = new System.Drawing.Size(31, 20);
            this.radio1g.TabIndex = 0;
            this.radio1g.TabStop = true;
            this.radio1g.Text = " ";
            this.radio1g.UseVisualStyleBackColor = false;
            // 
            // radio5g
            // 
            this.radio5g.AutoSize = true;
            this.radio5g.BackColor = System.Drawing.Color.Transparent;
            this.radio5g.Location = new System.Drawing.Point(121, 387);
            this.radio5g.Name = "radio5g";
            this.radio5g.Size = new System.Drawing.Size(31, 20);
            this.radio5g.TabIndex = 1;
            this.radio5g.TabStop = true;
            this.radio5g.Text = " ";
            this.radio5g.UseVisualStyleBackColor = false;
            // 
            // radio10g
            // 
            this.radio10g.AutoSize = true;
            this.radio10g.BackColor = System.Drawing.Color.Transparent;
            this.radio10g.Location = new System.Drawing.Point(123, 461);
            this.radio10g.Name = "radio10g";
            this.radio10g.Size = new System.Drawing.Size(31, 20);
            this.radio10g.TabIndex = 2;
            this.radio10g.TabStop = true;
            this.radio10g.Text = " ";
            this.radio10g.UseVisualStyleBackColor = false;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Location = new System.Drawing.Point(839, 321);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(58, 22);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "label1";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlus
            // 
            this.lblPlus.BackColor = System.Drawing.Color.Transparent;
            this.lblPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus.Location = new System.Drawing.Point(912, 309);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(77, 48);
            this.lblPlus.TabIndex = 4;
            this.lblPlus.Text = "+";
            this.lblPlus.UseVisualStyleBackColor = false;
            this.lblPlus.Click += new System.EventHandler(this.lblPlus_Click);
            // 
            // lblMinus
            // 
            this.lblMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinus.Location = new System.Drawing.Point(749, 309);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(77, 48);
            this.lblMinus.TabIndex = 5;
            this.lblMinus.Text = "-";
            this.lblMinus.UseVisualStyleBackColor = true;
            this.lblMinus.Click += new System.EventHandler(this.lblMinus_Click);
            // 
            // btnBuyNow
            // 
            this.btnBuyNow.BackColor = System.Drawing.Color.Lime;
            this.btnBuyNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnBuyNow.Location = new System.Drawing.Point(850, 428);
            this.btnBuyNow.Name = "btnBuyNow";
            this.btnBuyNow.Size = new System.Drawing.Size(191, 66);
            this.btnBuyNow.TabIndex = 6;
            this.btnBuyNow.Text = "Buy Now";
            this.btnBuyNow.UseVisualStyleBackColor = false;
            this.btnBuyNow.Click += new System.EventHandler(this.btnBuyNow_Click);
            // 
            // btnSellGold
            // 
            this.btnSellGold.BackColor = System.Drawing.Color.Red;
            this.btnSellGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellGold.Location = new System.Drawing.Point(1083, 215);
            this.btnSellGold.Name = "btnSellGold";
            this.btnSellGold.Size = new System.Drawing.Size(115, 62);
            this.btnSellGold.TabIndex = 7;
            this.btnSellGold.Text = "Sell Gold";
            this.btnSellGold.UseVisualStyleBackColor = false;
            this.btnSellGold.Click += new System.EventHandler(this.btnSellGold_Click);
            // 
            // lblCurrentPrice
            // 
            this.lblCurrentPrice.AutoSize = true;
            this.lblCurrentPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPrice.ForeColor = System.Drawing.Color.Khaki;
            this.lblCurrentPrice.Location = new System.Drawing.Point(460, 231);
            this.lblCurrentPrice.Name = "lblCurrentPrice";
            this.lblCurrentPrice.Size = new System.Drawing.Size(132, 46);
            this.lblCurrentPrice.TabIndex = 8;
            this.lblCurrentPrice.Text = "label1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Khaki;
            this.lblTotal.Location = new System.Drawing.Point(882, 231);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(126, 46);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "label1";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Store.Properties.Resources.Back;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InvestmentSection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Store.Properties.Resources.invest;
            this.ClientSize = new System.Drawing.Size(1298, 715);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCurrentPrice);
            this.Controls.Add(this.btnSellGold);
            this.Controls.Add(this.btnBuyNow);
            this.Controls.Add(this.lblMinus);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.radio10g);
            this.Controls.Add(this.radio5g);
            this.Controls.Add(this.radio1g);
            this.Name = "InvestmentSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvestmentSection";
            this.Load += new System.EventHandler(this.InvestmentSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio1g;
        private System.Windows.Forms.RadioButton radio5g;
        private System.Windows.Forms.RadioButton radio10g;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button lblPlus;
        private System.Windows.Forms.Button lblMinus;
        private System.Windows.Forms.Button btnBuyNow;
        private System.Windows.Forms.Button btnSellGold;
        private System.Windows.Forms.Label lblCurrentPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}