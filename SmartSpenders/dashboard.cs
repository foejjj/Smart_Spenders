using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSpenders
{
    public partial class dashboard : Form
    {
        private DataAccess dataAccess;
        string databaseFileName = "Database1.mdf";
        string username;
        private Label[] categorylabels;
        private Label[] timelabels;
        private Label[] accountlabels;
        private Label[] amountlabels;
        public dashboard(string username)
        {
            InitializeComponent();
            dataAccess = new DataAccess(databaseFileName);
            int numberOfLabels = 4; // Example: create 5 labels
            categorylabels = new Label[numberOfLabels];
            timelabels = new Label[numberOfLabels];
            accountlabels = new Label[numberOfLabels];
            amountlabels = new Label[numberOfLabels];
            this.username = username;
            CreateLabels();
            transactionBlockLoad();
            bankInfoLoad();
            LoadIncome();
            LoadExpense();
            CreditUpdate();
            DebitUpdate();
            LoadProfilePicture(username);
        }

        private void CreateLabels()
        {
            int j = 0;
            for (int i = 0; i < 4; i++)
            {
                // Create a new Label
                categorylabels[i] = new Label();

                // Set label properties
                categorylabels[i].Text = "";
                categorylabels[i].Location = new Point(370, 475 + j); // Set position
                j = j + 50;
                categorylabels[i].Size = new Size(87, 25); // Set size
                categorylabels[i].BackColor = Color.Transparent;
                categorylabels[i].ForeColor = Color.White;
                categorylabels[i].Font = new Font(categorylabels[i].Font.FontFamily, 14f, FontStyle.Regular);
                
                // Add the label to the form's controls

                this.Controls.Add(categorylabels[i]);
            }
            j = 0;
            for (int i = 0; i < 4; i++)
            {
                // Create a new Label
                timelabels[i] = new Label();

                // Set label properties
                timelabels[i].Text = "";
                timelabels[i].Location = new Point(370, 501 + j); // Set position
                j = j + 50;
                timelabels[i].Size = new Size(200, 17); // Set size
                timelabels[i].BackColor = Color.Transparent;
                timelabels[i].ForeColor = Color.Gray;
                timelabels[i].Font = new Font(timelabels[i].Font.FontFamily, 9f, FontStyle.Regular);
                
                // Add the label to the form's controls
                this.Controls.Add(timelabels[i]);
            }
            j = 0;
            for (int i = 0; i < 4; i++)
            {
                // Create a new Label
                accountlabels[i] = new Label();

                // Set label properties
                accountlabels[i].Text = "";
                accountlabels[i].Location = new Point(560, 475 + j); // Set position
                j = j + 50;
                accountlabels[i].Size = new Size(81, 25); // Set size
                accountlabels[i].BackColor = Color.Transparent;
                accountlabels[i].ForeColor = Color.White;
                accountlabels[i].Font = new Font(timelabels[i].Font.FontFamily, 14f, FontStyle.Regular);
                // Add the label to the form's controls
                this.Controls.Add(accountlabels[i]);
            }
            j = 0;
            for (int i = 0; i < 4; i++)
            {
                // Create a new Label
                amountlabels[i] = new Label();

                // Set label properties
                amountlabels[i].Text = "";
                amountlabels[i].Location = new Point(710, 475 + j); // Set position
                j = j + 50;
                amountlabels[i].Size = new Size(81, 25); // Set size
                amountlabels[i].BackColor = Color.Transparent;
                amountlabels[i].ForeColor = Color.White;
                amountlabels[i].Font = new Font(timelabels[i].Font.FontFamily, 14f, FontStyle.Regular);
                // Add the label to the form's controls
                this.Controls.Add(amountlabels[i]);
            }
        }

        private void updateMonthlyTableIncome(string username, int income)
        {
            int monthNumber = DateTime.Now.Month;
            if (!entryExistCheck(username, monthNumber))
            {
                string query = "INSERT into monthlyTotalIncomeExpense ([Username], [MonthNumber], [MonthlyBudget], [Expense], [Income]) values(@username, @monthNumber, @monthlyBudget, @expense, @income)";

                int expense = 0;
                int monthlyBudget = getMonthlyBudget(username);
                var cmd = dataAccess.GetCommand(query);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@monthNumber", monthNumber);
                cmd.Parameters.AddWithValue("@monthlyBudget", monthlyBudget);
                cmd.Parameters.AddWithValue("@expense", expense);
                cmd.Parameters.AddWithValue("@income", income);
                dataAccess.ExecuteNonQueryCommand(cmd);
            }
            else
            {
                string query = "UPDATE monthlyTotalIncomeExpense SET Income = @income WHERE Username = @username";
                int finalIncome = getMonthlyIncome(username, monthNumber) + income;
                var cmd = dataAccess.GetCommand(query);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@income", finalIncome);
                dataAccess.ExecuteNonQueryCommand(cmd);

            }
        }
        private void updateMonthlyTableExpense(string username, int expense)
        {
            int monthNumber = DateTime.Now.Month;
            if (!entryExistCheck(username, monthNumber))
            {
                string query = "INSERT into monthlyTotalIncomeExpense ([Username], [MonthNumber], [MonthlyBudget], [Expense], [Income]) values(@username, @monthNumber, @monthlyBudget, @expense, @income)";

                int income = 0;
                int monthlyBudget = getMonthlyBudget(username);
                var cmd = dataAccess.GetCommand(query);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@monthNumber", monthNumber);
                cmd.Parameters.AddWithValue("@monthlyBudget", monthlyBudget);
                cmd.Parameters.AddWithValue("@expense", expense);
                cmd.Parameters.AddWithValue("@income", income);
                dataAccess.ExecuteNonQueryCommand(cmd);
            }
            else
            {
                string query = "UPDATE monthlyTotalIncomeExpense SET Expense = @expense WHERE Username = @username";
                int finalExpense = getMonthlyExpense(username, monthNumber) + expense;
                var cmd = dataAccess.GetCommand(query);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@expense", finalExpense);
                dataAccess.ExecuteNonQueryCommand(cmd);

            }
        }
        private int getMonthlyExpense(string username, int month)
        {
            string query = "select Expense from monthlyTotalIncomeExpense where Username = @username AND MonthNumber = @month";
            var cmd = dataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@month", month);
            DataTable table = dataAccess.ExecuteCommand(cmd);

            return Convert.ToInt32(table.Rows[0]["Expense"]);
        }
        private int getMonthlyIncome(string username, int month)
        {
            string query = "select Income from monthlyTotalIncomeExpense where Username = @username AND MonthNumber = @month";
            var cmd = dataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@month", month);
            DataTable table = dataAccess.ExecuteCommand(cmd);

            return Convert.ToInt32(table.Rows[0]["Income"]);
        }
        private bool entryExistCheck(string username, int month)
        {
            string query = "select * from monthlyTotalIncomeExpense where Username = @username AND MonthNumber = @month";
            var cmd = dataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@month", month);
            DataTable table = dataAccess.ExecuteCommand(cmd);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int getMonthlyBudget(string username)
        {
            string query = "Select MonthlyBudget from financialInfo WHERE Username = @username";
            var cmd = dataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@username", username);
            DataTable monthlyBudgetTable = dataAccess.ExecuteCommand(cmd);
            return Convert.ToInt32(monthlyBudgetTable.Rows[0]["MonthlyBudget"]);
        }
        private void LoadIncome()
        {
            int monthNumber = DateTime.Now.Month;
            if (entryExistCheck(username, monthNumber))
            {
                string query = "SELECT * from monthlyTotalIncomeExpense where Username = @username AND MonthNumber = @monthNumber";

                var cmd = dataAccess.GetCommand(query);
                int month = DateTime.Now.Month;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@monthNumber", month);

                DataTable table = dataAccess.ExecuteCommand(cmd);
                incomeLabel.Text = table.Rows[0]["Income"].ToString() + " TK";
            }
            else
            {
                string query = "INSERT into monthlyTotalIncomeExpense ([Username], [MonthNumber], [MonthlyBudget], [Expense], [Income]) values(@username, @monthNumber, @monthlyBudget, @expense, @income)";

                int income = 0;
                int expense = 0;
                int monthlyBudget = getMonthlyBudget(username);
                var cmd = dataAccess.GetCommand(query);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@monthNumber", monthNumber);
                cmd.Parameters.AddWithValue("@monthlyBudget", monthlyBudget);
                cmd.Parameters.AddWithValue("@expense", expense);
                cmd.Parameters.AddWithValue("@income", income);
                dataAccess.ExecuteNonQueryCommand(cmd);
            }
        }
        private void LoadExpense()
        {
            int monthNumber = DateTime.Now.Month;
            if (entryExistCheck(username, monthNumber))
            {
                string query = "SELECT * from monthlyTotalIncomeExpense where Username = @username AND MonthNumber = @monthNumber";

                var cmd = dataAccess.GetCommand(query);
                int month = DateTime.Now.Month;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@monthNumber", month);

                DataTable table = dataAccess.ExecuteCommand(cmd);
                spendingLabel.Text = table.Rows[0]["Expense"].ToString() + " TK";
            }
            else
            {
                string query = "INSERT into monthlyTotalIncomeExpense ([Username], [MonthNumber], [MonthlyBudget], [Expense], [Income]) values(@username, @monthNumber, @monthlyBudget, @expense, @income)";

                int income = 0;
                int expense = 0;
                int monthlyBudget = getMonthlyBudget(username);
                var cmd = dataAccess.GetCommand(query);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@monthNumber", monthNumber);
                cmd.Parameters.AddWithValue("@monthlyBudget", monthlyBudget);
                cmd.Parameters.AddWithValue("@expense", expense);
                cmd.Parameters.AddWithValue("@income", income);
                dataAccess.ExecuteNonQueryCommand(cmd);
            }
        }
        
        private void transactionBlockLoad()
        {
            string query = "SELECT * FROM [dbo].[transaction] where Username= @username ORDER BY id DESC";
            var cmd = dataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@username", username);
            DataTable table = dataAccess.ExecuteCommand(cmd);
            if (table.Rows.Count <= 4)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    categorylabels[i].Text = table.Rows[i]["Category"].ToString();
                    timelabels[i].Text = table.Rows[i]["CreatedDate"].ToString();
                    accountlabels[i].Text = table.Rows[i]["Account"].ToString();
                    amountlabels[i].Text = table.Rows[i]["Amount"].ToString() + " TK";
                    if(categorylabels[i].Text == "Income")
                    {
                        amountlabels[i].ForeColor = Color.Green;
                    }
                    else
                    {
                        amountlabels[i].ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    categorylabels[i].Text = table.Rows[i]["Category"].ToString();
                    timelabels[i].Text = table.Rows[i]["CreatedDate"].ToString();
                    accountlabels[i].Text = table.Rows[i]["Account"].ToString();
                    amountlabels[i].Text = table.Rows[i]["Amount"].ToString() + " TK";
                    if (categorylabels[i].Text == "Income")
                    {
                        amountlabels[i].ForeColor = Color.Green;
                    }
                    else
                    {
                        amountlabels[i].ForeColor = Color.Red;
                    }
                }
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void bankInfoLoad()
        {
            string query = "SELECT * FROM [dbo].[financialInfo] where Username= @username";
            var cmd = dataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@username", username);
            DataTable table = dataAccess.ExecuteCommand(cmd);
            cardTypeLabel.Text = table.Rows[0]["CardType"].ToString();
            bankNameLabel.Text = table.Rows[0]["BankName"].ToString();
            cardNumberLabel.Text = table.Rows[0]["CardNumber"].ToString();
            bankBalanceLabel.Text = table.Rows[0]["BankBalance"].ToString() + " TK";
            expireDateLabel.Text = table.Rows[0]["ExpireDate"].ToString();
            bankBalanceLabel1.Text = table.Rows[0]["BankBalance"].ToString() + " TK";
            cashInHandLabel.Text = table.Rows[0]["CashInHand"].ToString() + " TK";
            query = "SELECT FirstName+' '+LastName AS FullName FROM generalUserInfo WHERE UserName = @username";
            cmd = dataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@username", username);
            table = dataAccess.ExecuteCommand(cmd);

            fullnameLabel.Text = table.Rows[0]["FullName"].ToString();
            bigFullName.Text = table.Rows[0]["FullName"].ToString();
        }

        private void CreditUpdate()
        {
            string query = "SELECT SUM(Amount) AS Amount FROM credit WHERE Username = @username";

            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@username", username);

            DataTable table = dataAccess.ExecuteCommand(cmd);

            creditLabel.Text = table.Rows[0]["Amount"].ToString() + " TK";
        }
        private void DebitUpdate()
        {
            string query = "SELECT SUM(Amount) AS Amount FROM debit WHERE Username = @username";

            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@username", username);

            DataTable table = dataAccess.ExecuteCommand(cmd);

            debitLabel.Text = table.Rows[0]["Amount"].ToString() + " TK";
        }

        private void dashboard_Load(object sender, EventArgs e) 
        {
            // TODO: This line of code loads data into the 'database1DataSet3.financialInfo' table. You can move, or remove it, as needed.
            this.financialInfoTableAdapter1.Fill(this.database1DataSet3.financialInfo);
            // TODO: This line of code loads data into the 'database1DataSet2.financialInfo' table. You can move, or remove it, as needed.
            this.financialInfoTableAdapter.Fill(this.database1DataSet2.financialInfo);

        }

        private void bankBalanceLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginPage loginPage = new loginPage();
            this.Hide();
            loginPage.Show();
        }

        private void transactionButton_Click(object sender, EventArgs e)
        {
            transaction transaction = new transaction(username);
            transaction.Show();
            this.Hide();
        }

        private void cardTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            categories categories = new categories(username);
            this.Close();
            categories.Show();
        }
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }
        private void LoadProfilePicture(string userName)
        {
            string query = "SELECT ProfilePicture FROM [generalUserInfo] WHERE UserName = @UserName";
            var cmd = dataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@UserName", userName);

            // Execute the scalar command to retrieve the image bytes from the database
            object imageBytesObj = dataAccess.ExecuteScalar(cmd);

            if (imageBytesObj != null && imageBytesObj != DBNull.Value)
            {
                byte[] imageBytes = (byte[])imageBytesObj;

                // Convert the byte array to an image and display it in the PictureBox
                profilePictureBox.Image = ByteArrayToImage(imageBytes);
            }
            else
            {
                MessageBox.Show("No profile picture found.");
            }
        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void creditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            credit credit = new credit(username);
            credit.Show();
        }

        private void debitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            debit debit = new debit(username);
            debit.Show();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            profile profile = new profile(username);
            profile.Show();
        }

        private void insightsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            insights insights = new insights(username);
            insights.Show();
        }
    }
}
