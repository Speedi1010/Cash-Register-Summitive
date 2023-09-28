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
    public partial class Form1 : Form
    {
        int healingPotionPrice = 4;
        int healingPotionamount;
        int manaPotionPrice = 8;
        int manaPotionamount;
        int sleepPotionPrice = 10;
        int sleeepPotionamount;
        int subtotal;
        double tax;
        double total;
        double change;
        int number = 0;

        public Form1()
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
                healingPotionamount = Convert.ToInt16(healingInput.Text);
                manaPotionamount = Convert.ToInt16(manaInput.Text);
                sleeepPotionamount = Convert.ToInt16(sleepInput.Text);

                subtotal = healingPotionamount * healingPotionPrice + manaPotionamount * manaPotionPrice + sleeepPotionamount * sleepPotionPrice;
                tax = subtotal * .25;
                total = subtotal + tax;

                untaxedLabel.Text = $"{subtotal} Gold";
                TaxLabel.Text = $"{tax} Gold";
                totalLabel.Text = $"{total} Gold";
            }
            catch
            {
                untaxedLabel.Text = "пошел на хуй";
                TaxLabel.Text = "пошел на хуй";
                totalLabel.Text = "пошел на хуй";
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
            if (change <= 0)
            {
                printingLabel.Size = new Size(0, 0);
                Receiptlabel.Text = "You owe me money";
                return;
            }

            if (total <= 0)
            {
                printingLabel.Size = new Size(0, 0);
                Receiptlabel.Text = "Buy something you brokie";
                return;
            }

            if (untaxedLabel.Text == "пошел на хуй")
            {
                Receiptlabel.Text = "\nпошел на хуй";
                Receiptlabel.Text += "\nпошел на хуй";
                Receiptlabel.Text += "\nпошел на хуй";
                Receiptlabel.Text += "\nпошел на хуй";
                Receiptlabel.Text += "\nпошел на хуй";
                Receiptlabel.Text += "\nпошел на хуй";
                printingLabel.Size = new Size(0, 0);
                printingLabel.Refresh();
                Receiptlabel.Refresh();
                return;
            }

            number++;

            Receiptlabel.BackColor = Color.White;
            Receiptlabel.Text = $"          The Devil's Potion Shop\n\n                 Receipt {number}";
            Receiptlabel.Text += $"\n\nHealing Potions:   {healingPotionamount} for {healingPotionPrice} Gold each";
            Receiptlabel.Text += $"\n\nMana Potions:      {manaPotionamount} for {manaPotionPrice} Gold each";
            Receiptlabel.Text += $"\n\nSleep Potions:     {sleeepPotionamount} for {sleepPotionPrice} Gold each";
            Receiptlabel.Text += $"\n\nSubtotal:          {subtotal} Gold";              Receiptlabel.Text += $"\n\nTax:               {tax} Gold";
            Receiptlabel.Text += $"\n\nTotal:             {total} Gold";
            Receiptlabel.Text += $"\n\nTendered:          {tenderInput.Text} Gold";
            Receiptlabel.Text += $"\n\nChange:            {change} Gold";
            Receiptlabel.Text += $"\n\n\n\n   Have a nice day come by again";
            Receiptlabel.Refresh();

            for (int x = 0; x < 19; x++)
            {
                size = size - 17;
                location = location + 17;

                receiptPrint.Play();
                printingLabel.Refresh();
                Thread.Sleep(1000);

                printingLabel.Size = new Size(401, size);
                printingLabel.Location = new Point(280, location);
            }
        }

        private void printingLabel_Click(object sender, EventArgs e)
        {

        }
    }

}

