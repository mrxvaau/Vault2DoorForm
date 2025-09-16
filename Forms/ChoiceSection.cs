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
    public partial class ChoiceSection : Form
    {
        private int currentUserId;

        public ChoiceSection(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;

            
        }

        private void JewellerySection_Load(object sender, EventArgs e)
        {

        }

        private void ringpic20_Click(object sender, EventArgs e)
        {
            this.Hide();
            DiamondVariants R1 = new DiamondVariants(currentUserId);
            R1.Show();
        }

        private void earring10_Click(object sender, EventArgs e)
        {
            this.Hide();
            GoldVariants E1 = new GoldVariants(currentUserId);
            E1.Show();
        }

        private void necklace30_Click(object sender, EventArgs e)
        {
            this.Hide();
            SilverVariants N1 = new SilverVariants(currentUserId);
            N1.Show();
        }

        private void signoutbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void Profilebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyUserProfile myuserprofile = new MyUserProfile(currentUserId);
            myuserprofile.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            InvestmentSection investmentsection = new InvestmentSection(currentUserId);
            investmentsection.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
