namespace Cash_Register_Summitive
{
    partial class potionShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(potionShopForm));
            this.Calculate = new System.Windows.Forms.Button();
            this.healingPotionLabel = new System.Windows.Forms.Label();
            this.manaPotionLabel = new System.Windows.Forms.Label();
            this.sleepPotionLabel = new System.Windows.Forms.Label();
            this.healingInput = new System.Windows.Forms.TextBox();
            this.manaInput = new System.Windows.Forms.TextBox();
            this.sleepInput = new System.Windows.Forms.TextBox();
            this.subLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.barLabel = new System.Windows.Forms.Label();
            this.tenderInput = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.printingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.Transparent;
            this.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Calculate.ForeColor = System.Drawing.SystemColors.Control;
            this.Calculate.Image = global::Cash_Register_Summitive.Properties.Resources.lava;
            this.Calculate.Location = new System.Drawing.Point(45, 138);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(191, 32);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate Total";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // healingPotionLabel
            // 
            this.healingPotionLabel.AutoSize = true;
            this.healingPotionLabel.BackColor = System.Drawing.Color.Transparent;
            this.healingPotionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.healingPotionLabel.Location = new System.Drawing.Point(45, 38);
            this.healingPotionLabel.Name = "healingPotionLabel";
            this.healingPotionLabel.Size = new System.Drawing.Size(109, 16);
            this.healingPotionLabel.TabIndex = 1;
            this.healingPotionLabel.Text = "Potion of Healing";
            // 
            // manaPotionLabel
            // 
            this.manaPotionLabel.AutoSize = true;
            this.manaPotionLabel.BackColor = System.Drawing.Color.Transparent;
            this.manaPotionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.manaPotionLabel.Location = new System.Drawing.Point(45, 74);
            this.manaPotionLabel.Name = "manaPotionLabel";
            this.manaPotionLabel.Size = new System.Drawing.Size(96, 16);
            this.manaPotionLabel.TabIndex = 2;
            this.manaPotionLabel.Text = "Potion of Mana";
            // 
            // sleepPotionLabel
            // 
            this.sleepPotionLabel.AutoSize = true;
            this.sleepPotionLabel.BackColor = System.Drawing.Color.Transparent;
            this.sleepPotionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.sleepPotionLabel.Location = new System.Drawing.Point(45, 108);
            this.sleepPotionLabel.Name = "sleepPotionLabel";
            this.sleepPotionLabel.Size = new System.Drawing.Size(98, 16);
            this.sleepPotionLabel.TabIndex = 3;
            this.sleepPotionLabel.Text = "Potion of Sleep";
            // 
            // healingInput
            // 
            this.healingInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.healingInput.Location = new System.Drawing.Point(169, 38);
            this.healingInput.Name = "healingInput";
            this.healingInput.Size = new System.Drawing.Size(42, 15);
            this.healingInput.TabIndex = 4;
            this.healingInput.Text = "0";
            // 
            // manaInput
            // 
            this.manaInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.manaInput.Location = new System.Drawing.Point(169, 75);
            this.manaInput.Name = "manaInput";
            this.manaInput.Size = new System.Drawing.Size(42, 15);
            this.manaInput.TabIndex = 5;
            this.manaInput.Text = "0";
            // 
            // sleepInput
            // 
            this.sleepInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sleepInput.Location = new System.Drawing.Point(169, 108);
            this.sleepInput.Name = "sleepInput";
            this.sleepInput.Size = new System.Drawing.Size(42, 15);
            this.sleepInput.TabIndex = 6;
            this.sleepInput.Text = "0";
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.BackColor = System.Drawing.Color.Transparent;
            this.subLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.subLabel.Location = new System.Drawing.Point(45, 183);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(59, 16);
            this.subLabel.TabIndex = 7;
            this.subLabel.Text = "Subtotal;";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.BackColor = System.Drawing.Color.Transparent;
            this.subtotalOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.subtotalOutput.Location = new System.Drawing.Point(166, 183);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(0, 16);
            this.subtotalOutput.TabIndex = 8;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.BackColor = System.Drawing.Color.Transparent;
            this.taxLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.taxLabel.Location = new System.Drawing.Point(71, 199);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(33, 16);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax:";
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.BackColor = System.Drawing.Color.Transparent;
            this.taxOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.taxOutput.Location = new System.Drawing.Point(166, 199);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(0, 16);
            this.taxOutput.TabIndex = 10;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.totalLabel.Location = new System.Drawing.Point(63, 215);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(41, 16);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total:";
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.BackColor = System.Drawing.Color.Transparent;
            this.totalOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.totalOutput.Location = new System.Drawing.Point(166, 215);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(0, 16);
            this.totalOutput.TabIndex = 12;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.BackColor = System.Drawing.Color.Transparent;
            this.tenderedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.tenderedLabel.Location = new System.Drawing.Point(34, 263);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(70, 16);
            this.tenderedLabel.TabIndex = 13;
            this.tenderedLabel.Text = "Tendered:";
            // 
            // barLabel
            // 
            this.barLabel.BackColor = System.Drawing.Color.Black;
            this.barLabel.Location = new System.Drawing.Point(26, 235);
            this.barLabel.Name = "barLabel";
            this.barLabel.Size = new System.Drawing.Size(262, 18);
            this.barLabel.TabIndex = 14;
            // 
            // tenderInput
            // 
            this.tenderInput.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tenderInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tenderInput.Location = new System.Drawing.Point(117, 263);
            this.tenderInput.Name = "tenderInput";
            this.tenderInput.Size = new System.Drawing.Size(39, 15);
            this.tenderInput.TabIndex = 15;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.changeLabel.Location = new System.Drawing.Point(47, 322);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(57, 16);
            this.changeLabel.TabIndex = 16;
            this.changeLabel.Text = "Change:";
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.BackColor = System.Drawing.Color.Transparent;
            this.changeOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.changeOutput.Location = new System.Drawing.Point(141, 322);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(0, 16);
            this.changeOutput.TabIndex = 17;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Transparent;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.changeButton.Image = global::Cash_Register_Summitive.Properties.Resources.lava;
            this.changeButton.Location = new System.Drawing.Point(29, 291);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(137, 28);
            this.changeButton.TabIndex = 18;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // receiptOutput
            // 
            this.receiptOutput.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutput.Location = new System.Drawing.Point(378, 38);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(401, 397);
            this.receiptOutput.TabIndex = 19;
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.Transparent;
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.receiptButton.ForeColor = System.Drawing.SystemColors.Control;
            this.receiptButton.Image = global::Cash_Register_Summitive.Properties.Resources.lava;
            this.receiptButton.Location = new System.Drawing.Point(29, 351);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(131, 29);
            this.receiptButton.TabIndex = 20;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // printingLabel
            // 
            this.printingLabel.BackColor = System.Drawing.Color.Transparent;
            this.printingLabel.Location = new System.Drawing.Point(378, 38);
            this.printingLabel.Name = "printingLabel";
            this.printingLabel.Size = new System.Drawing.Size(401, 397);
            this.printingLabel.TabIndex = 21;
            // 
            // potionShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cash_Register_Summitive.Properties.Resources.istock_629614894_red_sunset_panorama_fmt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderInput);
            this.Controls.Add(this.barLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.sleepInput);
            this.Controls.Add(this.manaInput);
            this.Controls.Add(this.healingInput);
            this.Controls.Add(this.sleepPotionLabel);
            this.Controls.Add(this.manaPotionLabel);
            this.Controls.Add(this.healingPotionLabel);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.printingLabel);
            this.Controls.Add(this.receiptOutput);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "potionShopForm";
            this.Text = "Potion Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label healingPotionLabel;
        private System.Windows.Forms.Label manaPotionLabel;
        private System.Windows.Forms.Label sleepPotionLabel;
        private System.Windows.Forms.TextBox healingInput;
        private System.Windows.Forms.TextBox manaInput;
        private System.Windows.Forms.TextBox sleepInput;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label barLabel;
        private System.Windows.Forms.TextBox tenderInput;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label receiptOutput;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label printingLabel;
    }
}

