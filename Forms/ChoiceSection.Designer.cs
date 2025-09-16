namespace Store.Forms
{
    partial class ChoiceSection
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
            this.label4 = new System.Windows.Forms.Label();
            this.necklace30 = new System.Windows.Forms.PictureBox();
            this.earring10 = new System.Windows.Forms.PictureBox();
            this.ringpic20 = new System.Windows.Forms.PictureBox();
            this.signoutbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.necklace30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.earring10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringpic20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(597, 604);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Let\'s Invest  ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // necklace30
            // 
            this.necklace30.BackColor = System.Drawing.Color.Transparent;
            this.necklace30.Image = global::Store.Properties.Resources.silverfine;
            this.necklace30.Location = new System.Drawing.Point(872, 267);
            this.necklace30.Name = "necklace30";
            this.necklace30.Size = new System.Drawing.Size(290, 279);
            this.necklace30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.necklace30.TabIndex = 4;
            this.necklace30.TabStop = false;
            this.necklace30.Click += new System.EventHandler(this.necklace30_Click);
            // 
            // earring10
            // 
            this.earring10.BackColor = System.Drawing.Color.Transparent;
            this.earring10.Image = global::Store.Properties.Resources.gold24;
            this.earring10.Location = new System.Drawing.Point(469, 267);
            this.earring10.Name = "earring10";
            this.earring10.Size = new System.Drawing.Size(304, 279);
            this.earring10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.earring10.TabIndex = 3;
            this.earring10.TabStop = false;
            this.earring10.Click += new System.EventHandler(this.earring10_Click);
            // 
            // ringpic20
            // 
            this.ringpic20.BackColor = System.Drawing.Color.Transparent;
            this.ringpic20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ringpic20.Image = global::Store.Properties.Resources.diamondnatural;
            this.ringpic20.Location = new System.Drawing.Point(141, 262);
            this.ringpic20.Name = "ringpic20";
            this.ringpic20.Size = new System.Drawing.Size(264, 260);
            this.ringpic20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ringpic20.TabIndex = 2;
            this.ringpic20.TabStop = false;
            this.ringpic20.Click += new System.EventHandler(this.ringpic20_Click);
            // 
            // signoutbutton
            // 
            this.signoutbutton.BackColor = System.Drawing.Color.Navy;
            this.signoutbutton.BackgroundImage = global::Store.Properties.Resources.Back;
            this.signoutbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signoutbutton.Location = new System.Drawing.Point(1073, 116);
            this.signoutbutton.Name = "signoutbutton";
            this.signoutbutton.Size = new System.Drawing.Size(72, 61);
            this.signoutbutton.TabIndex = 1;
            this.signoutbutton.UseVisualStyleBackColor = false;
            this.signoutbutton.Click += new System.EventHandler(this.signoutbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Store.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(69, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ChoiceSection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = global::Store.Properties.Resources.Choice;
            this.ClientSize = new System.Drawing.Size(1174, 702);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.necklace30);
            this.Controls.Add(this.earring10);
            this.Controls.Add(this.ringpic20);
            this.Controls.Add(this.signoutbutton);
            this.Name = "ChoiceSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoiceSection";
            this.Load += new System.EventHandler(this.JewellerySection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.necklace30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.earring10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringpic20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button signoutbutton;
        private System.Windows.Forms.PictureBox ringpic20;
        private System.Windows.Forms.PictureBox earring10;
        private System.Windows.Forms.PictureBox necklace30;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}