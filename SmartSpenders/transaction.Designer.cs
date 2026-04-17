
namespace SmartSpenders
{
    partial class transaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new SmartSpenders.Database1DataSet();
            this.addTransactionButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.transactionTableAdapter = new SmartSpenders.Database1DataSetTableAdapters.transactionTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.debitLabel = new System.Windows.Forms.Label();
            this.creditLabel = new System.Windows.Forms.Label();
            this.bankBalanceLabel1 = new System.Windows.Forms.Label();
            this.cashInHandLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.banknameLabel1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.expireDateLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bankBalanceLabel = new System.Windows.Forms.Label();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.cardTypeLabel = new System.Windows.Forms.Label();
            this.bankNameLabel = new System.Windows.Forms.Label();
            this.categoryButton = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.creditButton = new System.Windows.Forms.Button();
            this.debitButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.warningPanel = new System.Windows.Forms.Panel();
            this.waningCloseButton = new System.Windows.Forms.Button();
            this.insightsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.warningPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.Account,
            this.Note,
            this.Amount,
            this.createdDateDataGridViewTextBoxColumn,
            this.Id});
            this.dataGridView1.DataSource = this.transactionBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(36)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView1.Location = new System.Drawing.Point(332, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 5;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(554, 477);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Account
            // 
            this.Account.DataPropertyName = "Account";
            this.Account.HeaderText = "Account";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            this.createdDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdDateDataGridViewTextBoxColumn.Width = 126;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 48;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "transaction";
            this.transactionBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addTransactionButton
            // 
            this.addTransactionButton.BackColor = System.Drawing.Color.Transparent;
            this.addTransactionButton.FlatAppearance.BorderSize = 0;
            this.addTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTransactionButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addTransactionButton.Location = new System.Drawing.Point(733, 666);
            this.addTransactionButton.Name = "addTransactionButton";
            this.addTransactionButton.Size = new System.Drawing.Size(156, 31);
            this.addTransactionButton.TabIndex = 2;
            this.addTransactionButton.Text = "Add Transaction";
            this.addTransactionButton.UseVisualStyleBackColor = false;
            this.addTransactionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editButton.Location = new System.Drawing.Point(540, 666);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(138, 31);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // transactionTableAdapter
            // 
            this.transactionTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(336, 666);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(140, 31);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.BackColor = System.Drawing.Color.Transparent;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboardButton.Location = new System.Drawing.Point(64, 137);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(140, 31);
            this.dashboardButton.TabIndex = 5;
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1148, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 31);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // debitLabel
            // 
            this.debitLabel.AutoSize = true;
            this.debitLabel.BackColor = System.Drawing.Color.Transparent;
            this.debitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.debitLabel.ForeColor = System.Drawing.Color.White;
            this.debitLabel.Location = new System.Drawing.Point(960, 654);
            this.debitLabel.Name = "debitLabel";
            this.debitLabel.Size = new System.Drawing.Size(56, 25);
            this.debitLabel.TabIndex = 64;
            this.debitLabel.Text = "$$$$";
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.BackColor = System.Drawing.Color.Transparent;
            this.creditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.creditLabel.ForeColor = System.Drawing.Color.White;
            this.creditLabel.Location = new System.Drawing.Point(960, 576);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(56, 25);
            this.creditLabel.TabIndex = 63;
            this.creditLabel.Text = "$$$$";
            // 
            // bankBalanceLabel1
            // 
            this.bankBalanceLabel1.AutoSize = true;
            this.bankBalanceLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bankBalanceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bankBalanceLabel1.ForeColor = System.Drawing.Color.White;
            this.bankBalanceLabel1.Location = new System.Drawing.Point(960, 501);
            this.bankBalanceLabel1.Name = "bankBalanceLabel1";
            this.bankBalanceLabel1.Size = new System.Drawing.Size(56, 25);
            this.bankBalanceLabel1.TabIndex = 62;
            this.bankBalanceLabel1.Text = "$$$$";
            // 
            // cashInHandLabel
            // 
            this.cashInHandLabel.AutoSize = true;
            this.cashInHandLabel.BackColor = System.Drawing.Color.Transparent;
            this.cashInHandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cashInHandLabel.ForeColor = System.Drawing.Color.White;
            this.cashInHandLabel.Location = new System.Drawing.Point(960, 427);
            this.cashInHandLabel.Name = "cashInHandLabel";
            this.cashInHandLabel.Size = new System.Drawing.Size(56, 25);
            this.cashInHandLabel.TabIndex = 61;
            this.cashInHandLabel.Text = "$$$$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(955, 614);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 25);
            this.label13.TabIndex = 60;
            this.label13.Text = "Debit";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(955, 542);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 25);
            this.label12.TabIndex = 59;
            this.label12.Text = "Credit";
            // 
            // banknameLabel1
            // 
            this.banknameLabel1.AutoSize = true;
            this.banknameLabel1.BackColor = System.Drawing.Color.Transparent;
            this.banknameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.banknameLabel1.ForeColor = System.Drawing.Color.White;
            this.banknameLabel1.Location = new System.Drawing.Point(955, 465);
            this.banknameLabel1.Name = "banknameLabel1";
            this.banknameLabel1.Size = new System.Drawing.Size(114, 25);
            this.banknameLabel1.TabIndex = 58;
            this.banknameLabel1.Text = "Bank Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(955, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 25);
            this.label11.TabIndex = 57;
            this.label11.Text = "Cash In Hand";
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.fullnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.fullnameLabel.ForeColor = System.Drawing.Color.White;
            this.fullnameLabel.Location = new System.Drawing.Point(938, 283);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(95, 25);
            this.fullnameLabel.TabIndex = 56;
            this.fullnameLabel.Text = "FullName";
            // 
            // expireDateLabel
            // 
            this.expireDateLabel.AutoSize = true;
            this.expireDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.expireDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.expireDateLabel.ForeColor = System.Drawing.Color.White;
            this.expireDateLabel.Location = new System.Drawing.Point(938, 248);
            this.expireDateLabel.Name = "expireDateLabel";
            this.expireDateLabel.Size = new System.Drawing.Size(108, 25);
            this.expireDateLabel.TabIndex = 55;
            this.expireDateLabel.Text = "expire date";
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(940, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 18);
            this.label10.TabIndex = 54;
            this.label10.Text = "Expire date:";
            // 
            // bankBalanceLabel
            // 
            this.bankBalanceLabel.AutoSize = true;
            this.bankBalanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.bankBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bankBalanceLabel.ForeColor = System.Drawing.Color.White;
            this.bankBalanceLabel.Location = new System.Drawing.Point(938, 192);
            this.bankBalanceLabel.Name = "bankBalanceLabel";
            this.bankBalanceLabel.Size = new System.Drawing.Size(160, 29);
            this.bankBalanceLabel.TabIndex = 53;
            this.bankBalanceLabel.Text = "Bank Balance";
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.cardNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cardNumberLabel.ForeColor = System.Drawing.Color.White;
            this.cardNumberLabel.Location = new System.Drawing.Point(939, 173);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(91, 18);
            this.cardNumberLabel.TabIndex = 52;
            this.cardNumberLabel.Text = "card number";
            // 
            // cardTypeLabel
            // 
            this.cardTypeLabel.AutoSize = true;
            this.cardTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.cardTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cardTypeLabel.ForeColor = System.Drawing.Color.White;
            this.cardTypeLabel.Location = new System.Drawing.Point(936, 133);
            this.cardTypeLabel.Name = "cardTypeLabel";
            this.cardTypeLabel.Size = new System.Drawing.Size(92, 25);
            this.cardTypeLabel.TabIndex = 51;
            this.cardTypeLabel.Text = "card type";
            // 
            // bankNameLabel
            // 
            this.bankNameLabel.AutoSize = true;
            this.bankNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.bankNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bankNameLabel.ForeColor = System.Drawing.Color.White;
            this.bankNameLabel.Location = new System.Drawing.Point(1090, 133);
            this.bankNameLabel.Name = "bankNameLabel";
            this.bankNameLabel.Size = new System.Drawing.Size(109, 25);
            this.bankNameLabel.TabIndex = 50;
            this.bankNameLabel.Text = "bank name";
            // 
            // categoryButton
            // 
            this.categoryButton.BackColor = System.Drawing.Color.Transparent;
            this.categoryButton.FlatAppearance.BorderSize = 0;
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoryButton.Location = new System.Drawing.Point(53, 486);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(151, 31);
            this.categoryButton.TabIndex = 65;
            this.categoryButton.UseVisualStyleBackColor = false;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(1192, 40);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(42, 30);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 66;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.profilePictureBox_Click);
            // 
            // creditButton
            // 
            this.creditButton.BackColor = System.Drawing.Color.Transparent;
            this.creditButton.FlatAppearance.BorderSize = 0;
            this.creditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.creditButton.Location = new System.Drawing.Point(42, 312);
            this.creditButton.Name = "creditButton";
            this.creditButton.Size = new System.Drawing.Size(151, 31);
            this.creditButton.TabIndex = 67;
            this.creditButton.UseVisualStyleBackColor = false;
            this.creditButton.Click += new System.EventHandler(this.creditButton_Click);
            // 
            // debitButton
            // 
            this.debitButton.BackColor = System.Drawing.Color.Transparent;
            this.debitButton.FlatAppearance.BorderSize = 0;
            this.debitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.debitButton.Location = new System.Drawing.Point(43, 369);
            this.debitButton.Name = "debitButton";
            this.debitButton.Size = new System.Drawing.Size(151, 31);
            this.debitButton.TabIndex = 68;
            this.debitButton.UseVisualStyleBackColor = false;
            this.debitButton.Click += new System.EventHandler(this.debitButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.Transparent;
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profileButton.Location = new System.Drawing.Point(51, 429);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(151, 31);
            this.profileButton.TabIndex = 69;
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // warningPanel
            // 
            this.warningPanel.BackColor = System.Drawing.Color.Transparent;
            this.warningPanel.BackgroundImage = global::SmartSpenders.Properties.Resources.Add_a_heading;
            this.warningPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.warningPanel.Controls.Add(this.waningCloseButton);
            this.warningPanel.Location = new System.Drawing.Point(546, 31);
            this.warningPanel.Name = "warningPanel";
            this.warningPanel.Size = new System.Drawing.Size(292, 57);
            this.warningPanel.TabIndex = 71;
            // 
            // waningCloseButton
            // 
            this.waningCloseButton.BackColor = System.Drawing.Color.Transparent;
            this.waningCloseButton.FlatAppearance.BorderSize = 0;
            this.waningCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.waningCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waningCloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.waningCloseButton.Location = new System.Drawing.Point(268, -2);
            this.waningCloseButton.Name = "waningCloseButton";
            this.waningCloseButton.Size = new System.Drawing.Size(19, 23);
            this.waningCloseButton.TabIndex = 72;
            this.waningCloseButton.UseVisualStyleBackColor = false;
            this.waningCloseButton.Visible = false;
            this.waningCloseButton.Click += new System.EventHandler(this.waningCloseButton_Click);
            // 
            // insightsButton
            // 
            this.insightsButton.BackColor = System.Drawing.Color.Transparent;
            this.insightsButton.FlatAppearance.BorderSize = 0;
            this.insightsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insightsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.insightsButton.ForeColor = System.Drawing.Color.Transparent;
            this.insightsButton.Location = new System.Drawing.Point(52, 192);
            this.insightsButton.Name = "insightsButton";
            this.insightsButton.Size = new System.Drawing.Size(151, 32);
            this.insightsButton.TabIndex = 72;
            this.insightsButton.UseVisualStyleBackColor = false;
            this.insightsButton.Click += new System.EventHandler(this.insightsButton_Click);
            // 
            // transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartSpenders.Properties.Resources.Transaction__6_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 739);
            this.Controls.Add(this.insightsButton);
            this.Controls.Add(this.warningPanel);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.debitButton);
            this.Controls.Add(this.creditButton);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.categoryButton);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dashboardButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addTransactionButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "transaction";
            this.Text = "transaction";
            this.Load += new System.EventHandler(this.transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.warningPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addTransactionButton;
        private System.Windows.Forms.Button editButton;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private Database1DataSetTableAdapters.transactionTableAdapter transactionTableAdapter;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label debitLabel;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Label bankBalanceLabel1;
        private System.Windows.Forms.Label cashInHandLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label banknameLabel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.Label expireDateLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label bankBalanceLabel;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.Label cardTypeLabel;
        private System.Windows.Forms.Label bankNameLabel;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Button creditButton;
        private System.Windows.Forms.Button debitButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Panel warningPanel;
        private System.Windows.Forms.Button waningCloseButton;
        private System.Windows.Forms.Button insightsButton;
    }
}