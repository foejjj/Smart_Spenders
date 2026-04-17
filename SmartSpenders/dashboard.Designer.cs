
namespace SmartSpenders
{
    partial class dashboard
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
            this.components = new System.ComponentModel.Container();
            this.bankNameLabel = new System.Windows.Forms.Label();
            this.cardTypeLabel = new System.Windows.Forms.Label();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.bankBalanceLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.expireDateLabel = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.banknameLabel1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cashInHandLabel = new System.Windows.Forms.Label();
            this.bankBalanceLabel1 = new System.Windows.Forms.Label();
            this.creditLabel = new System.Windows.Forms.Label();
            this.debitLabel = new System.Windows.Forms.Label();
            this.database1DataSet1 = new SmartSpenders.Database1DataSet1();
            this.database1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2 = new SmartSpenders.Database1DataSet2();
            this.financialInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialInfoTableAdapter = new SmartSpenders.Database1DataSet2TableAdapters.financialInfoTableAdapter();
            this.database1DataSet3 = new SmartSpenders.Database1DataSet3();
            this.financialInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.financialInfoTableAdapter1 = new SmartSpenders.Database1DataSet3TableAdapters.financialInfoTableAdapter();
            this.transactionButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.spendingLabel = new System.Windows.Forms.Label();
            this.categoryButton = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.creditButton = new System.Windows.Forms.Button();
            this.debitButton = new System.Windows.Forms.Button();
            this.bigFullName = new System.Windows.Forms.Label();
            this.profileButton = new System.Windows.Forms.Button();
            this.insightsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bankNameLabel
            // 
            this.bankNameLabel.AutoSize = true;
            this.bankNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.bankNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bankNameLabel.ForeColor = System.Drawing.Color.White;
            this.bankNameLabel.Location = new System.Drawing.Point(1023, 133);
            this.bankNameLabel.Name = "bankNameLabel";
            this.bankNameLabel.Size = new System.Drawing.Size(109, 25);
            this.bankNameLabel.TabIndex = 16;
            this.bankNameLabel.Text = "bank name";
            // 
            // cardTypeLabel
            // 
            this.cardTypeLabel.AutoSize = true;
            this.cardTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.cardTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cardTypeLabel.ForeColor = System.Drawing.Color.White;
            this.cardTypeLabel.Location = new System.Drawing.Point(869, 133);
            this.cardTypeLabel.Name = "cardTypeLabel";
            this.cardTypeLabel.Size = new System.Drawing.Size(92, 25);
            this.cardTypeLabel.TabIndex = 17;
            this.cardTypeLabel.Text = "card type";
            this.cardTypeLabel.Click += new System.EventHandler(this.cardTypeLabel_Click);
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.cardNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cardNumberLabel.ForeColor = System.Drawing.Color.White;
            this.cardNumberLabel.Location = new System.Drawing.Point(872, 173);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(91, 18);
            this.cardNumberLabel.TabIndex = 18;
            this.cardNumberLabel.Text = "card number";
            // 
            // bankBalanceLabel
            // 
            this.bankBalanceLabel.AutoSize = true;
            this.bankBalanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.bankBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bankBalanceLabel.ForeColor = System.Drawing.Color.White;
            this.bankBalanceLabel.Location = new System.Drawing.Point(871, 192);
            this.bankBalanceLabel.Name = "bankBalanceLabel";
            this.bankBalanceLabel.Size = new System.Drawing.Size(160, 29);
            this.bankBalanceLabel.TabIndex = 19;
            this.bankBalanceLabel.Text = "Bank Balance";
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(873, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Expire date:";
            // 
            // expireDateLabel
            // 
            this.expireDateLabel.AutoSize = true;
            this.expireDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.expireDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.expireDateLabel.ForeColor = System.Drawing.Color.White;
            this.expireDateLabel.Location = new System.Drawing.Point(871, 248);
            this.expireDateLabel.Name = "expireDateLabel";
            this.expireDateLabel.Size = new System.Drawing.Size(108, 25);
            this.expireDateLabel.TabIndex = 21;
            this.expireDateLabel.Text = "expire date";
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.fullnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.fullnameLabel.ForeColor = System.Drawing.Color.White;
            this.fullnameLabel.Location = new System.Drawing.Point(871, 283);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(95, 25);
            this.fullnameLabel.TabIndex = 22;
            this.fullnameLabel.Text = "FullName";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(874, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Cash In Hand";
            // 
            // banknameLabel1
            // 
            this.banknameLabel1.AutoSize = true;
            this.banknameLabel1.BackColor = System.Drawing.Color.Transparent;
            this.banknameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.banknameLabel1.ForeColor = System.Drawing.Color.White;
            this.banknameLabel1.Location = new System.Drawing.Point(874, 468);
            this.banknameLabel1.Name = "banknameLabel1";
            this.banknameLabel1.Size = new System.Drawing.Size(114, 25);
            this.banknameLabel1.TabIndex = 24;
            this.banknameLabel1.Text = "Bank Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(874, 545);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "Credit";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(874, 617);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 25);
            this.label13.TabIndex = 26;
            this.label13.Text = "Debit";
            // 
            // cashInHandLabel
            // 
            this.cashInHandLabel.AutoSize = true;
            this.cashInHandLabel.BackColor = System.Drawing.Color.Transparent;
            this.cashInHandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cashInHandLabel.ForeColor = System.Drawing.Color.White;
            this.cashInHandLabel.Location = new System.Drawing.Point(885, 427);
            this.cashInHandLabel.Name = "cashInHandLabel";
            this.cashInHandLabel.Size = new System.Drawing.Size(56, 25);
            this.cashInHandLabel.TabIndex = 27;
            this.cashInHandLabel.Text = "$$$$";
            // 
            // bankBalanceLabel1
            // 
            this.bankBalanceLabel1.AutoSize = true;
            this.bankBalanceLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bankBalanceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bankBalanceLabel1.ForeColor = System.Drawing.Color.White;
            this.bankBalanceLabel1.Location = new System.Drawing.Point(884, 500);
            this.bankBalanceLabel1.Name = "bankBalanceLabel1";
            this.bankBalanceLabel1.Size = new System.Drawing.Size(56, 25);
            this.bankBalanceLabel1.TabIndex = 28;
            this.bankBalanceLabel1.Text = "$$$$";
            this.bankBalanceLabel1.Click += new System.EventHandler(this.bankBalanceLabel1_Click);
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.BackColor = System.Drawing.Color.Transparent;
            this.creditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.creditLabel.ForeColor = System.Drawing.Color.White;
            this.creditLabel.Location = new System.Drawing.Point(884, 575);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(56, 25);
            this.creditLabel.TabIndex = 29;
            this.creditLabel.Text = "$$$$";
            // 
            // debitLabel
            // 
            this.debitLabel.AutoSize = true;
            this.debitLabel.BackColor = System.Drawing.Color.Transparent;
            this.debitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.debitLabel.ForeColor = System.Drawing.Color.White;
            this.debitLabel.Location = new System.Drawing.Point(884, 651);
            this.debitLabel.Name = "debitLabel";
            this.debitLabel.Size = new System.Drawing.Size(56, 25);
            this.debitLabel.TabIndex = 30;
            this.debitLabel.Text = "$$$$";
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSet1BindingSource
            // 
            this.database1DataSet1BindingSource.DataSource = this.database1DataSet1;
            this.database1DataSet1BindingSource.Position = 0;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // financialInfoBindingSource
            // 
            this.financialInfoBindingSource.DataMember = "financialInfo";
            this.financialInfoBindingSource.DataSource = this.database1DataSet2;
            // 
            // financialInfoTableAdapter
            // 
            this.financialInfoTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // financialInfoBindingSource1
            // 
            this.financialInfoBindingSource1.DataMember = "financialInfo";
            this.financialInfoBindingSource1.DataSource = this.database1DataSet3;
            // 
            // financialInfoTableAdapter1
            // 
            this.financialInfoTableAdapter1.ClearBeforeFill = true;
            // 
            // transactionButton
            // 
            this.transactionButton.BackColor = System.Drawing.Color.Transparent;
            this.transactionButton.FlatAppearance.BorderSize = 0;
            this.transactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.transactionButton.ForeColor = System.Drawing.Color.Transparent;
            this.transactionButton.Location = new System.Drawing.Point(51, 251);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(151, 32);
            this.transactionButton.TabIndex = 31;
            this.transactionButton.UseVisualStyleBackColor = false;
            this.transactionButton.Click += new System.EventHandler(this.transactionButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(1059, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 32);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.incomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.incomeLabel.ForeColor = System.Drawing.Color.Lime;
            this.incomeLabel.Location = new System.Drawing.Point(533, 270);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(78, 29);
            this.incomeLabel.TabIndex = 33;
            this.incomeLabel.Text = "$$$$$";
            // 
            // spendingLabel
            // 
            this.spendingLabel.AutoSize = true;
            this.spendingLabel.BackColor = System.Drawing.Color.Transparent;
            this.spendingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.spendingLabel.ForeColor = System.Drawing.Color.Red;
            this.spendingLabel.Location = new System.Drawing.Point(650, 270);
            this.spendingLabel.Name = "spendingLabel";
            this.spendingLabel.Size = new System.Drawing.Size(78, 29);
            this.spendingLabel.TabIndex = 34;
            this.spendingLabel.Text = "$$$$$";
            this.spendingLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.BackColor = System.Drawing.Color.Transparent;
            this.categoryButton.FlatAppearance.BorderSize = 0;
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.categoryButton.ForeColor = System.Drawing.Color.Transparent;
            this.categoryButton.Location = new System.Drawing.Point(50, 488);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(151, 32);
            this.categoryButton.TabIndex = 35;
            this.categoryButton.UseVisualStyleBackColor = false;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(1100, 43);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(32, 25);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 52;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.profilePictureBox_Click);
            // 
            // creditButton
            // 
            this.creditButton.BackColor = System.Drawing.Color.Transparent;
            this.creditButton.FlatAppearance.BorderSize = 0;
            this.creditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.creditButton.ForeColor = System.Drawing.Color.Transparent;
            this.creditButton.Location = new System.Drawing.Point(46, 312);
            this.creditButton.Name = "creditButton";
            this.creditButton.Size = new System.Drawing.Size(151, 32);
            this.creditButton.TabIndex = 53;
            this.creditButton.UseVisualStyleBackColor = false;
            this.creditButton.Click += new System.EventHandler(this.creditButton_Click);
            // 
            // debitButton
            // 
            this.debitButton.BackColor = System.Drawing.Color.Transparent;
            this.debitButton.FlatAppearance.BorderSize = 0;
            this.debitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.debitButton.ForeColor = System.Drawing.Color.Transparent;
            this.debitButton.Location = new System.Drawing.Point(46, 369);
            this.debitButton.Name = "debitButton";
            this.debitButton.Size = new System.Drawing.Size(151, 32);
            this.debitButton.TabIndex = 54;
            this.debitButton.UseVisualStyleBackColor = false;
            this.debitButton.Click += new System.EventHandler(this.debitButton_Click);
            // 
            // bigFullName
            // 
            this.bigFullName.AutoSize = true;
            this.bigFullName.BackColor = System.Drawing.Color.Transparent;
            this.bigFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.bigFullName.ForeColor = System.Drawing.Color.White;
            this.bigFullName.Location = new System.Drawing.Point(298, 160);
            this.bigFullName.Name = "bigFullName";
            this.bigFullName.Size = new System.Drawing.Size(130, 31);
            this.bigFullName.TabIndex = 55;
            this.bigFullName.Text = "FullName";
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.Transparent;
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.profileButton.ForeColor = System.Drawing.Color.Transparent;
            this.profileButton.Location = new System.Drawing.Point(44, 430);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(151, 32);
            this.profileButton.TabIndex = 56;
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // insightsButton
            // 
            this.insightsButton.BackColor = System.Drawing.Color.Transparent;
            this.insightsButton.FlatAppearance.BorderSize = 0;
            this.insightsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insightsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.insightsButton.ForeColor = System.Drawing.Color.Transparent;
            this.insightsButton.Location = new System.Drawing.Point(44, 193);
            this.insightsButton.Name = "insightsButton";
            this.insightsButton.Size = new System.Drawing.Size(151, 32);
            this.insightsButton.TabIndex = 57;
            this.insightsButton.UseVisualStyleBackColor = false;
            this.insightsButton.Click += new System.EventHandler(this.insightsButton_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartSpenders.Properties.Resources.dashboard__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 739);
            this.Controls.Add(this.insightsButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.bigFullName);
            this.Controls.Add(this.debitButton);
            this.Controls.Add(this.creditButton);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.spendingLabel);
            this.Controls.Add(this.incomeLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.transactionButton);
            this.Controls.Add(this.debitLabel);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.bankBalanceLabel1);
            this.Controls.Add(this.cashInHandLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.banknameLabel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.expireDateLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bankBalanceLabel);
            this.Controls.Add(this.cardNumberLabel);
            this.Controls.Add(this.cardTypeLabel);
            this.Controls.Add(this.bankNameLabel);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bankNameLabel;
        private System.Windows.Forms.Label cardTypeLabel;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.Label bankBalanceLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label expireDateLabel;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label banknameLabel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label cashInHandLabel;
        private System.Windows.Forms.Label bankBalanceLabel1;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Label debitLabel;
        private System.Windows.Forms.BindingSource database1DataSet1BindingSource;
        private Database1DataSet1 database1DataSet1;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource financialInfoBindingSource;
        private Database1DataSet2TableAdapters.financialInfoTableAdapter financialInfoTableAdapter;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource financialInfoBindingSource1;
        private Database1DataSet3TableAdapters.financialInfoTableAdapter financialInfoTableAdapter1;
        private System.Windows.Forms.Button transactionButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label spendingLabel;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Button creditButton;
        private System.Windows.Forms.Button debitButton;
        private System.Windows.Forms.Label bigFullName;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button insightsButton;
    }
}