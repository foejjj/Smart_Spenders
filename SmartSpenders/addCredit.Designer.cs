
namespace SmartSpenders
{
    partial class addCredit
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.accountLabel = new System.Windows.Forms.Label();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nameTextBox.Location = new System.Drawing.Point(89, 144);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(275, 26);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.Text = "Name";
            this.nameTextBox.Enter += new System.EventHandler(this.nameTextBox_Enter);
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.amountTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.amountTextBox.Location = new System.Drawing.Point(89, 206);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(115, 26);
            this.amountTextBox.TabIndex = 10;
            this.amountTextBox.Text = "Amount";
            this.amountTextBox.Enter += new System.EventHandler(this.amountTextBox_Enter);
            this.amountTextBox.Leave += new System.EventHandler(this.amountTextBox_Leave);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Transparent;
            this.enterButton.FlatAppearance.BorderSize = 0;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.Location = new System.Drawing.Point(237, 309);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(165, 33);
            this.enterButton.TabIndex = 12;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(47, 309);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(164, 33);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accountLabel.ForeColor = System.Drawing.Color.White;
            this.accountLabel.Location = new System.Drawing.Point(216, 181);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(68, 20);
            this.accountLabel.TabIndex = 14;
            this.accountLabel.Text = "Account";
            // 
            // accountComboBox
            // 
            this.accountComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Items.AddRange(new object[] {
            "Cash in Hand",
            "Bank"});
            this.accountComboBox.Location = new System.Drawing.Point(220, 204);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(144, 28);
            this.accountComboBox.TabIndex = 13;
            // 
            // addCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartSpenders.Properties.Resources.Gradient_Purple_with_Dark_Theme_Modern_Digital_Banking_Dashboard_Desktop_Prototype__15_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(456, 382);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "addCredit";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.addCredit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.ComboBox accountComboBox;
    }
}