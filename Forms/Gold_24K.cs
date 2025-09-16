using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store.Models;

namespace Store.Forms
{
    public partial class Gold_24K : Form
    {

        private readonly int currentUserId;
        private decimal basePrice = 400;
        private int selectedKarat = 24;
        private int quantity = 1;

        public Gold_24K(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void BuyEarring1_Load(object sender, EventArgs e)
        {
            radio18K.Checked = true;
            label2.Text = basePrice.ToString("N0") + " $";

            radio18K.CheckedChanged += RadioKarat_CheckedChanged;
            radio22K.CheckedChanged += RadioKarat_CheckedChanged;


            
            lblQuantity.Text = quantity.ToString();

            UpdatePriceDisplay();

        }


        private void UpdatePriceDisplay()
        {
            decimal unitPrice = (selectedKarat == 24) ? 500m : basePrice;
            decimal total = unitPrice * quantity;
            label2.Text = total.ToString("N0") + " $";
        }

        private void Radio22K_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void RadioKarat_CheckedChanged(object sender, EventArgs e)
        {

            selectedKarat = radio22K.Checked ? 24 : 18;
            UpdatePriceDisplay();

        }

        private void radio18K_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            var unitPrice = (selectedKarat == 24) ? 500m : basePrice;
            var item = new CartItem
            {
                ProductName = "Gold 24k",
                Karat = selectedKarat,
                Price = unitPrice,
                Quantity = quantity
            };
            var cartForm = new CartForm(currentUserId, item);
            Hide();
            cartForm.Show();
        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void LblMinus_Click(object sender, EventArgs e)
        {
            if (quantity > 1)
            {
                quantity--;
                lblQuantity.Text = quantity.ToString();
                UpdatePriceDisplay();
            }
        }

        private void LblPlus_Click(object sender, EventArgs e)
        {
            quantity++;
            lblQuantity.Text = quantity.ToString();
            UpdatePriceDisplay();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GoldVariants ear1 = new GoldVariants(currentUserId);
            ear1.Show();
        }

        private void radio22K_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
