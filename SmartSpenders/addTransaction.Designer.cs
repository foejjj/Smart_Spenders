
namespace SmartSpenders
{
    partial class addTransaction
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
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.noteTextbox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.accountLabel = new System.Windows.Forms.Label();
            this.categoryButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(50, 142);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(191, 28);
            this.categoryComboBox.TabIndex = 0;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // accountComboBox
            // 
            this.accountComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Items.AddRange(new object[] {
            "Cash in Hand",
            "Bank"});
            this.accountComboBox.Location = new System.Drawing.Point(279, 142);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(173, 28);
            this.accountComboBox.TabIndex = 1;
            // 
            // noteTextbox
            // 
            this.noteTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.noteTextbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.noteTextbox.Location = new System.Drawing.Point(50, 208);
            this.noteTextbox.Name = "noteTextbox";
            this.noteTextbox.Size = new System.Drawing.Size(191, 26);
            this.noteTextbox.TabIndex = 2;
            this.noteTextbox.Text = "Note";
            this.noteTextbox.Enter += new System.EventHandler(this.noteTextBox_Enter);
            this.noteTextbox.Leave += new System.EventHandler(this.noteTextBox_Leave);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.amountTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.amountTextBox.Location = new System.Drawing.Point(279, 208);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(173, 26);
            this.amountTextBox.TabIndex = 3;
            this.amountTextBox.Text = "Amount";
            this.amountTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.amountTextBox.Enter += new System.EventHandler(this.amountTextBox_Enter);
            this.amountTextBox.Leave += new System.EventHandler(this.amountTextBox_Leave);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(50, 337);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(191, 42);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Transparent;
            this.enterButton.FlatAppearance.BorderSize = 0;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.Location = new System.Drawing.Point(267, 337);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(185, 42);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accountLabel.ForeColor = System.Drawing.Color.White;
            this.accountLabel.Location = new System.Drawing.Point(275, 119);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(68, 20);
            this.accountLabel.TabIndex = 6;
            this.accountLabel.Text = "Account";
            this.accountLabel.Click += new System.EventHandler(this.accountLabel_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.AutoSize = true;
            this.categoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.categoryButton.ForeColor = System.Drawing.Color.White;
            this.categoryButton.Location = new System.Drawing.Point(49, 119);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(73, 20);
            this.categoryButton.TabIndex = 7;
            this.categoryButton.Text = "Category";
            // 
            // addTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BackgroundImage = global::SmartSpenders.Properties.Resources.Gradient_Purple_with_Dark_Theme_Modern_Digital_Banking_Dashboard_Desktop_Prototype__11_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 420);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.noteTextbox);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Name = "addTransaction";
            this.Text = "addTransaction";
            this.Load += new System.EventHandler(this.addTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox accountComboBox;
        private System.Windows.Forms.TextBox noteTextbox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Label categoryButton;
    }
}