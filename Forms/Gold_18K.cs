﻿using Store.Forms;
using Store.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Forms
{
    public partial class Gold_18K : Form
    {

        private readonly int currentUserId;
        private decimal basePrice = 450;
        private int selectedKarat = 18;
        private int quantity = 1;
        public Gold_18K(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void BuyEarring3_Load(object sender, EventArgs e)
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
            decimal unitPrice = (selectedKarat == 22) ? 750m : basePrice;
            decimal total = unitPrice * quantity;
            label2.Text = total.ToString("N0") + " $";
        }

        private void radio22K_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void RadioKarat_CheckedChanged(object sender, EventArgs e)
        {

            selectedKarat = radio22K.Checked ? 22 : 18;
            UpdatePriceDisplay();

        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            var unitPrice = (selectedKarat == 22) ? 750m : basePrice;
            var item = new CartItem
            {
                ProductName = "Russian Earring",
                Karat = selectedKarat,
                Price = unitPrice,
                Quantity = quantity
            };
            var cartForm = new CartForm(currentUserId, item);
            Hide();
            cartForm.Show();
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
            MyEarring ear2 = new MyEarring(currentUserId);
            ear2.Show();
        }
    }
}
