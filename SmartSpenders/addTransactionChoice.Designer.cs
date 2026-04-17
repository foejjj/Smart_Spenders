
namespace SmartSpenders
{
    partial class addTransactionChoice
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
            this.debitTransactionButton = new System.Windows.Forms.Button();
            this.creditTransactionButton = new System.Windows.Forms.Button();
            this.normalTransactionButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // debitTransactionButton
            // 
            this.debitTransactionButton.BackColor = System.Drawing.Color.Transparent;
            this.debitTransactionButton.FlatAppearance.BorderSize = 0;
            this.debitTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debitTransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.debitTransactionButton.ForeColor = System.Drawing.Color.Transparent;
            this.debitTransactionButton.Location = new System.Drawing.Point(148, 207);
            this.debitTransactionButton.Name = "debitTransactionButton";
            this.debitTransactionButton.Size = new System.Drawing.Size(254, 32);
            this.debitTransactionButton.TabIndex = 33;
            this.debitTransactionButton.UseVisualStyleBackColor = false;
            this.debitTransactionButton.Click += new System.EventHandler(this.debitTransactionButton_Click);
            // 
            // creditTransactionButton
            // 
            this.creditTransactionButton.BackColor = System.Drawing.Color.Transparent;
            this.creditTransactionButton.FlatAppearance.BorderSize = 0;
            this.creditTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditTransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.creditTransactionButton.ForeColor = System.Drawing.Color.Transparent;
            this.creditTransactionButton.Location = new System.Drawing.Point(148, 284);
            this.creditTransactionButton.Name = "creditTransactionButton";
            this.creditTransactionButton.Size = new System.Drawing.Size(254, 32);
            this.creditTransactionButton.TabIndex = 34;
            this.creditTransactionButton.UseVisualStyleBackColor = false;
            this.creditTransactionButton.Click += new System.EventHandler(this.creditTransactionButton_Click);
            // 
            // normalTransactionButton
            // 
            this.normalTransactionButton.BackColor = System.Drawing.Color.Transparent;
            this.normalTransactionButton.FlatAppearance.BorderSize = 0;
            this.normalTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.normalTransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.normalTransactionButton.ForeColor = System.Drawing.Color.Transparent;
            this.normalTransactionButton.Location = new System.Drawing.Point(148, 367);
            this.normalTransactionButton.Name = "normalTransactionButton";
            this.normalTransactionButton.Size = new System.Drawing.Size(254, 32);
            this.normalTransactionButton.TabIndex = 35;
            this.normalTransactionButton.UseVisualStyleBackColor = false;
            this.normalTransactionButton.Click += new System.EventHandler(this.normalTransactionButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(150, 451);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(254, 32);
            this.closeButton.TabIndex = 36;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addTransactionChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BackgroundImage = global::SmartSpenders.Properties.Resources.Gradient_Purple_with_Dark_Theme_Modern_Digital_Banking_Dashboard_Desktop_Prototype__9_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 531);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.normalTransactionButton);
            this.Controls.Add(this.creditTransactionButton);
            this.Controls.Add(this.debitTransactionButton);
            this.Name = "addTransactionChoice";
            this.Text = "addTransactionChoice";
            this.Load += new System.EventHandler(this.addTransactionChoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button debitTransactionButton;
        private System.Windows.Forms.Button creditTransactionButton;
        private System.Windows.Forms.Button normalTransactionButton;
        private System.Windows.Forms.Button closeButton;
    }
}