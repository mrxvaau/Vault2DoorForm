using Store.DataQ;
using Store.Models;
using System;
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
    public partial class MyEarring : Form
    {

        private readonly int currentUserId;
        
        public MyEarring(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;
        }

        private void MyEarring_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            JewellerySection jewellery = new JewellerySection(currentUserId);
            jewellery.Show();
        }

        private void earRing1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gold_24K buy1 = new Gold_24K(currentUserId);
            buy1.Show();
        }

        private void earRing2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gold_22K buy2 = new Gold_22K(currentUserId);
            buy2.Show();
        }

        private void earRing3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gold_18K buy3 = new Gold_18K(currentUserId);
            buy3.Show();
        }
    }
}
