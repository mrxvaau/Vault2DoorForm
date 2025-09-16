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
    public partial class DiamondVariants : Form
    {
        private readonly int currentUserId;

        public DiamondVariants(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;
        }

        private void Rings_Load(object sender, EventArgs e)
        {

        }

        private void backpic_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChoiceSection jewellery = new ChoiceSection(currentUserId);
            jewellery.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diamond_Natural buy2 = new Diamond_Natural(currentUserId);
            buy2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diamond_Fancy buy1 = new Diamond_Fancy(currentUserId);
            buy1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diamond_Lab buy3 = new Diamond_Lab(currentUserId);
            buy3.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
