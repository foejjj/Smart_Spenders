
namespace SmartSpenders
{
    partial class addCreditTransaction
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
            this.categoryButton = new System.Windows.Forms.Label();
            this.accountLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.creditComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // categoryButton
            // 
            this.categoryButton.AutoSize = true;
            this.categoryButton.BackColor = System.Drawing.Color.Transparent;
            this.categoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.categoryButton.ForeColor = System.Drawing.Color.White;
            this.categoryButton.Location = new System.Drawing.Point(119, 130);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(97, 20);
            this.categoryButton.TabIndex = 24;
            this.categoryButton.Text = "Select credit";
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accountLabel.ForeColor = System.Drawing.Color.White;
            this.accountLabel.Location = new System.Drawing.Point(122, 213);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(68, 20);
            this.accountLabel.TabIndex = 23;
            this.accountLabel.Text = "Account";
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Transparent;
            this.enterButton.FlatAppearance.BorderSize = 0;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.Location = new System.Drawing.Point(267, 338);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(185, 42);
            this.enterButton.TabIndex = 22;
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
            this.closeButton.Location = new System.Drawing.Point(50, 338);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(191, 42);
            this.closeButton.TabIndex = 21;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // accountComboBox
            // 
            this.accountComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Items.AddRange(new object[] {
            "Cash in Hand",
            "Bank"});
            this.accountComboBox.Location = new System.Drawing.Point(123, 237);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(260, 28);
            this.accountComboBox.TabIndex = 20;
            // 
            // creditComboBox
            // 
            this.creditComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.creditComboBox.FormattingEnabled = true;
            this.creditComboBox.Location = new System.Drawing.Point(123, 153);
            this.creditComboBox.Name = "creditComboBox";
            this.creditComboBox.Size = new System.Drawing.Size(260, 28);
            this.creditComboBox.TabIndex = 19;
            // 
            // addCreditTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartSpenders.Properties.Resources.Gradient_Purple_with_Dark_Theme_Modern_Digital_Banking_Dashboard_Desktop_Prototype__13_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 420);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.creditComboBox);
            this.Name = "addCreditTransaction";
            this.Text = "addCreditTransaction";
            this.Load += new System.EventHandler(this.addCreditTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryButton;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox accountComboBox;
        private System.Windows.Forms.ComboBox creditComboBox;
    }
}