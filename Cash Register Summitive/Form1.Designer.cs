namespace Cash_Register_Summitive
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Calculate = new System.Windows.Forms.Button();
            this.healingPotion = new System.Windows.Forms.Label();
            this.manaPotion = new System.Windows.Forms.Label();
            this.sleepPotion = new System.Windows.Forms.Label();
            this.healingInput = new System.Windows.Forms.TextBox();
            this.manaInput = new System.Windows.Forms.TextBox();
            this.sleepInput = new System.Windows.Forms.TextBox();
            this.subLabel = new System.Windows.Forms.Label();
            this.untaxedLabel = new System.Windows.Forms.Label();
            this.ta = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tenderInput = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.Receiptlabel = new System.Windows.Forms.Label();
            this.ReceiptButton = new System.Windows.Forms.Button();
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
            // healingPotion
            // 
            this.healingPotion.AutoSize = true;
            this.healingPotion.BackColor = System.Drawing.Color.Transparent;
            this.healingPotion.ForeColor = System.Drawing.SystemColors.Control;
            this.healingPotion.Location = new System.Drawing.Point(45, 38);
            this.healingPotion.Name = "healingPotion";
            this.healingPotion.Size = new System.Drawing.Size(109, 16);
            this.healingPotion.TabIndex = 1;
            this.healingPotion.Text = "Potion of Healing";
            // 
            // manaPotion
            // 
            this.manaPotion.AutoSize = true;
            this.manaPotion.BackColor = System.Drawing.Color.Transparent;
            this.manaPotion.ForeColor = System.Drawing.SystemColors.Control;
            this.manaPotion.Location = new System.Drawing.Point(45, 74);
            this.manaPotion.Name = "manaPotion";
            this.manaPotion.Size = new System.Drawing.Size(96, 16);
            this.manaPotion.TabIndex = 2;
            this.manaPotion.Text = "Potion of Mana";
            // 
            // sleepPotion
            // 
            this.sleepPotion.AutoSize = true;
            this.sleepPotion.BackColor = System.Drawing.Color.Transparent;
            this.sleepPotion.ForeColor = System.Drawing.SystemColors.Control;
            this.sleepPotion.Location = new System.Drawing.Point(45, 108);
            this.sleepPotion.Name = "sleepPotion";
            this.sleepPotion.Size = new System.Drawing.Size(98, 16);
            this.sleepPotion.TabIndex = 3;
            this.sleepPotion.Text = "Potion of Sleep";
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
            // untaxedLabel
            // 
            this.untaxedLabel.AutoSize = true;
            this.untaxedLabel.BackColor = System.Drawing.Color.Transparent;
            this.untaxedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.untaxedLabel.Location = new System.Drawing.Point(166, 183);
            this.untaxedLabel.Name = "untaxedLabel";
            this.untaxedLabel.Size = new System.Drawing.Size(0, 16);
            this.untaxedLabel.TabIndex = 8;
            // 
            // ta
            // 
            this.ta.AutoSize = true;
            this.ta.BackColor = System.Drawing.Color.Transparent;
            this.ta.ForeColor = System.Drawing.SystemColors.Control;
            this.ta.Location = new System.Drawing.Point(71, 199);
            this.ta.Name = "ta";
            this.ta.Size = new System.Drawing.Size(33, 16);
            this.ta.TabIndex = 9;
            this.ta.Text = "Tax:";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.BackColor = System.Drawing.Color.Transparent;
            this.TaxLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TaxLabel.Location = new System.Drawing.Point(166, 199);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(0, 16);
            this.TaxLabel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(63, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.totalLabel.Location = new System.Drawing.Point(166, 215);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 16);
            this.totalLabel.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(34, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tendered:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 18);
            this.label3.TabIndex = 14;
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
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.Color.Transparent;
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ChangeButton.Image = global::Cash_Register_Summitive.Properties.Resources.lava;
            this.ChangeButton.Location = new System.Drawing.Point(29, 291);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(137, 28);
            this.ChangeButton.TabIndex = 18;
            this.ChangeButton.Text = "Calculate Change";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // Receiptlabel
            // 
            this.Receiptlabel.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receiptlabel.Location = new System.Drawing.Point(378, 38);
            this.Receiptlabel.Name = "Receiptlabel";
            this.Receiptlabel.Size = new System.Drawing.Size(401, 397);
            this.Receiptlabel.TabIndex = 19;
            // 
            // ReceiptButton
            // 
            this.ReceiptButton.BackColor = System.Drawing.Color.Transparent;
            this.ReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReceiptButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ReceiptButton.Image = global::Cash_Register_Summitive.Properties.Resources.lava;
            this.ReceiptButton.Location = new System.Drawing.Point(29, 351);
            this.ReceiptButton.Name = "ReceiptButton";
            this.ReceiptButton.Size = new System.Drawing.Size(131, 29);
            this.ReceiptButton.TabIndex = 20;
            this.ReceiptButton.Text = "Print Receipt";
            this.ReceiptButton.UseVisualStyleBackColor = false;
            this.ReceiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // printingLabel
            // 
            this.printingLabel.BackColor = System.Drawing.Color.Transparent;
            this.printingLabel.Location = new System.Drawing.Point(378, 38);
            this.printingLabel.Name = "printingLabel";
            this.printingLabel.Size = new System.Drawing.Size(401, 397);
            this.printingLabel.TabIndex = 21;
            this.printingLabel.Click += new System.EventHandler(this.printingLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cash_Register_Summitive.Properties.Resources.istock_629614894_red_sunset_panorama_fmt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReceiptButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.ta);
            this.Controls.Add(this.untaxedLabel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.sleepInput);
            this.Controls.Add(this.manaInput);
            this.Controls.Add(this.healingInput);
            this.Controls.Add(this.sleepPotion);
            this.Controls.Add(this.manaPotion);
            this.Controls.Add(this.healingPotion);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.printingLabel);
            this.Controls.Add(this.Receiptlabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Potion Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label healingPotion;
        private System.Windows.Forms.Label manaPotion;
        private System.Windows.Forms.Label sleepPotion;
        private System.Windows.Forms.TextBox healingInput;
        private System.Windows.Forms.TextBox manaInput;
        private System.Windows.Forms.TextBox sleepInput;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label untaxedLabel;
        private System.Windows.Forms.Label ta;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tenderInput;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label Receiptlabel;
        private System.Windows.Forms.Button ReceiptButton;
        private System.Windows.Forms.Label printingLabel;
    }
}

