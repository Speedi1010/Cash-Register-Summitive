using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Cash_Register_Summitive
{
    public partial class potionShopForm : Form
    {
        int healingPotionPrice = 4;
        int healingPotionAmount;
        int manaPotionPrice = 8;
        int manaPotionAmount;
        int sleepPotionPrice = 10;
        int sleeepPotionAmount;
        int subtotal;
        double tax;
        double total;
        double change;
        int number = 0;

        public potionShopForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                healingPotionAmount = Convert.ToInt16(healingInput.Text);
                manaPotionAmount = Convert.ToInt16(manaInput.Text);
                sleeepPotionAmount = Convert.ToInt16(sleepInput.Text);

                subtotal = healingPotionAmount * healingPotionPrice + manaPotionAmount * manaPotionPrice + sleeepPotionAmount * sleepPotionPrice;
                tax = subtotal * .25;
                total = subtotal + tax;

                subtotalOutput.Text = $"{subtotal} Gold";
                taxOutput.Text = $"{tax} Gold";
                totalOutput.Text = $"{total} Gold";
            }
            catch
            {
                subtotalOutput.Text = "пошел на хуй";
                taxOutput.Text = "пошел на хуй";
                totalOutput.Text = "пошел на хуй";
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {

            try
            {
                int tendered = Convert.ToInt16(tenderInput.Text);
                change = tendered - total;
                changeOutput.Text = $"{change} Gold";
                if (tendered < 0)
                {
                    changeOutput.Text = "пошел на хуй";
                }
            }
            catch
            {
                changeOutput.Text = "пошел на хуй";
            }
        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            int location = 38;
            int size = 380;
            printingLabel.Size = new Size(401, size);
            printingLabel.Location = new Point(280, location);
            SoundPlayer receiptPrint = new SoundPlayer(Properties.Resources.receipt2);


            if (total <= 0)
            {
                printingLabel.Size = new Size(0, 0);
                receiptOutput.Text = "Buy something you brokie";
                return;
            }

            if (change < 0)
            {
                printingLabel.Size = new Size(0, 0);
                receiptOutput.Text = "You owe me money";
                return;
            }

            if (subtotalOutput.Text == "пошел на хуй")
            {
                receiptOutput.Text = "\nпошел на хуй";
                receiptOutput.Text += "\nпошел на хуй";
                receiptOutput.Text += "\nпошел на хуй";
                receiptOutput.Text += "\nпошел на хуй";
                receiptOutput.Text += "\nпошел на хуй";
                receiptOutput.Text += "\nпошел на хуй";
                printingLabel.Size = new Size(0, 0);
                printingLabel.Refresh();
                receiptOutput.Refresh();
                return;
            }

            number++;

            receiptOutput.BackColor = Color.White;
            receiptOutput.Text = $"          The Devil's Potion Shop\n\n                 Receipt {number}";
            receiptOutput.Text += $"\n\nHealing Potions:   {healingPotionAmount} for {healingPotionPrice} Gold each";
            receiptOutput.Text += $"\n\nMana Potions:      {manaPotionAmount} for {manaPotionPrice} Gold each";
            receiptOutput.Text += $"\n\nSleep Potions:     {sleeepPotionAmount} for {sleepPotionPrice} Gold each";
            receiptOutput.Text += $"\n\nSubtotal:          {subtotal} Gold"; receiptOutput.Text += $"\n\nTax:               {tax} Gold";
            receiptOutput.Text += $"\n\nTotal:             {total} Gold";
            receiptOutput.Text += $"\n\nTendered:          {tenderInput.Text} Gold";
            receiptOutput.Text += $"\n\nChange:            {change} Gold";
            receiptOutput.Text += $"\n\n\n\n   Have a nice day come by again";
            receiptOutput.Refresh();

            for (int x = 0; x < 19; x++)
            {
                size = size - 17;
                location = location + 17;

                printingLabel.Size = new Size(401, size);
                printingLabel.Location = new Point(280, location);

                receiptPrint.Play();

                receiptOutput.Refresh();
                printingLabel.Refresh();
                Thread.Sleep(800);

            }
        }

    }
}

