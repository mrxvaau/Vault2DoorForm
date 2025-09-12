﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Forms
{
    public partial class Necklaces : Form
    {

        private readonly int currentUserId;
        public Necklaces(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;
        }

        private void Necklaces_Load(object sender, EventArgs e)
        {

        }

        private void backpic_Click(object sender, EventArgs e)
        {
            this.Hide();
            JewellerySection jewellery = new JewellerySection(currentUserId);
            jewellery.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Silver_Fine buy2 = new Silver_Fine(currentUserId);
            buy2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Silver_Alloy buy1 = new Silver_Alloy(currentUserId);
            buy1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Silver_Sterling buy2 = new Silver_Sterling(currentUserId);
            buy2.Show();
        }
    }
}
