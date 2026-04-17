
namespace SmartSpenders
{
    partial class registrationPage2
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
            this.cardTypeComboBox = new System.Windows.Forms.ComboBox();
            this.expireDateTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bankBalanceTextBox = new System.Windows.Forms.TextBox();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.monthlyBudgetTextBox = new System.Windows.Forms.TextBox();
            this.bankNameTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.cashInHandTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cardTypeComboBox
            // 
            this.cardTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cardTypeComboBox.FormattingEnabled = true;
            this.cardTypeComboBox.Items.AddRange(new object[] {
            "Debit Card",
            "Credit Card"});
            this.cardTypeComboBox.Location = new System.Drawing.Point(274, 276);
            this.cardTypeComboBox.Name = "cardTypeComboBox";
            this.cardTypeComboBox.Size = new System.Drawing.Size(190, 28);
            this.cardTypeComboBox.TabIndex = 22;
            // 
            // expireDateTextBox
            // 
            this.expireDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.expireDateTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.expireDateTextBox.Location = new System.Drawing.Point(65, 394);
            this.expireDateTextBox.Name = "expireDateTextBox";
            this.expireDateTextBox.Size = new System.Drawing.Size(190, 26);
            this.expireDateTextBox.TabIndex = 21;
            this.expireDateTextBox.Text = "MM-YY";
            this.expireDateTextBox.Enter += new System.EventHandler(this.expireDateTextBox_Enter);
            this.expireDateTextBox.Leave += new System.EventHandler(this.expireDateTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 5F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::SmartSpenders.Properties.Resources.Purple_Minimalist_Login_Website_App_Desktop_Prototype;
            this.label2.Location = new System.Drawing.Point(62, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Expire date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 5F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::SmartSpenders.Properties.Resources.Purple_Minimalist_Login_Website_App_Desktop_Prototype;
            this.label1.Location = new System.Drawing.Point(271, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Card type";
            // 
            // bankBalanceTextBox
            // 
            this.bankBalanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bankBalanceTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bankBalanceTextBox.Location = new System.Drawing.Point(274, 330);
            this.bankBalanceTextBox.Name = "bankBalanceTextBox";
            this.bankBalanceTextBox.Size = new System.Drawing.Size(190, 26);
            this.bankBalanceTextBox.TabIndex = 18;
            this.bankBalanceTextBox.Text = "Bank balance";
            this.bankBalanceTextBox.Enter += new System.EventHandler(this.bankBalanceTextBox_Enter);
            this.bankBalanceTextBox.Leave += new System.EventHandler(this.bankBalanceTextBox_Leave);
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cardNumberTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cardNumberTextBox.Location = new System.Drawing.Point(65, 330);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(190, 26);
            this.cardNumberTextBox.TabIndex = 16;
            this.cardNumberTextBox.Text = "Card number";
            this.cardNumberTextBox.Enter += new System.EventHandler(this.cardNumberTextBox_Enter);
            this.cardNumberTextBox.Leave += new System.EventHandler(this.cardNumberTextBox_Enter);
            // 
            // monthlyBudgetTextBox
            // 
            this.monthlyBudgetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.monthlyBudgetTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.monthlyBudgetTextBox.Location = new System.Drawing.Point(65, 451);
            this.monthlyBudgetTextBox.Name = "monthlyBudgetTextBox";
            this.monthlyBudgetTextBox.Size = new System.Drawing.Size(190, 26);
            this.monthlyBudgetTextBox.TabIndex = 15;
            this.monthlyBudgetTextBox.Text = "Monthly budget";
            this.monthlyBudgetTextBox.Enter += new System.EventHandler(this.monthlyBudgetTextBox_Enter);
            this.monthlyBudgetTextBox.Leave += new System.EventHandler(this.monthlyBudgetTextBox_Leave);
            // 
            // bankNameTextBox
            // 
            this.bankNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bankNameTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bankNameTextBox.Location = new System.Drawing.Point(65, 276);
            this.bankNameTextBox.Name = "bankNameTextBox";
            this.bankNameTextBox.Size = new System.Drawing.Size(190, 26);
            this.bankNameTextBox.TabIndex = 14;
            this.bankNameTextBox.Text = "Bank name";
            this.bankNameTextBox.Enter += new System.EventHandler(this.bankNameTextBox_Enter);
            this.bankNameTextBox.Leave += new System.EventHandler(this.bankNameTextBox_Leave);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Gold;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.registerButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.registerButton.Location = new System.Drawing.Point(350, 480);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(114, 37);
            this.registerButton.TabIndex = 13;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // cashInHandTextBox
            // 
            this.cashInHandTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cashInHandTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cashInHandTextBox.Location = new System.Drawing.Point(274, 394);
            this.cashInHandTextBox.Name = "cashInHandTextBox";
            this.cashInHandTextBox.Size = new System.Drawing.Size(190, 26);
            this.cashInHandTextBox.TabIndex = 23;
            this.cashInHandTextBox.Text = "Cash in hand";
            this.cashInHandTextBox.Enter += new System.EventHandler(this.cashInHandTextBox_Enter);
            this.cashInHandTextBox.Leave += new System.EventHandler(this.cashInHandTextBox_Leave);
            // 
            // registrationPage2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartSpenders.Properties.Resources.Purple_Minimalist_Login_Website_App_Desktop_Prototype;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 739);
            this.Controls.Add(this.cashInHandTextBox);
            this.Controls.Add(this.cardTypeComboBox);
            this.Controls.Add(this.expireDateTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bankBalanceTextBox);
            this.Controls.Add(this.cardNumberTextBox);
            this.Controls.Add(this.monthlyBudgetTextBox);
            this.Controls.Add(this.bankNameTextBox);
            this.Controls.Add(this.registerButton);
            this.Name = "registrationPage2";
            this.Text = "registrationPage2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cardTypeComboBox;
        private System.Windows.Forms.TextBox expireDateTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bankBalanceTextBox;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.TextBox monthlyBudgetTextBox;
        private System.Windows.Forms.TextBox bankNameTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox cashInHandTextBox;
    }
}