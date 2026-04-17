using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSpenders
{
    public partial class addTransaction : Form
    {
        private DataAccess dataAccess;
        private DataTable accountDataTable;
        string username;
        bool warning = false;
        public addTransaction(string username)
        {
            InitializeComponent();
            this.username = username;
            dataAccess = new DataAccess("Database1.mdf");
            LoadData();
        }
        private void LoadData()
        {
            string query = "SELECT * FROM categories WHERE Username = @Username";

            // Parameters to filter by username (replace 'hasan1234' with the logged-in username)
            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@Username", username);
            // Execute the query and get a DataTable with the results
            DataTable dataTable = dataAccess.ExecuteCommand(cmd);

            // Clear the combo box before adding items
            categoryComboBox.Items.Clear();

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Loop through each row in the DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    string category = row["Category"].ToString();

                    // Format the string as "Name Amount TK" and add it to the combo box
                    categoryComboBox.Items.Add(category);
                }
            }
            updateAccountTable(username);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void noteTextBox_Enter(object sender, EventArgs e)
        {
            if(noteTextbox.Text == "Note")
            {
                noteTextbox.Text = "";
                noteTextbox.ForeColor = Color.Black;
                noteTextbox.Font = new Font(noteTextbox.Font.FontFamily, 14f, FontStyle.Regular);
            }
        }

        private void noteTextBox_Leave(object sender, EventArgs e)
        {
            if (noteTextbox.Text == "")
            {
                noteTextbox.Text = "Note";
                noteTextbox.ForeColor = Color.Gray;
                noteTextbox.Font = new Font(noteTextbox.Font.FontFamily, 14f, FontStyle.Regular);
            }
        }
        private void amountTextBox_Enter(object sender, EventArgs e)
        {
            if (amountTextBox.Text == "Amount")
            {
                amountTextBox.Text = "";
                amountTextBox.ForeColor = Color.Black;
                amountTextBox.Font = new Font(amountTextBox.Font.FontFamily, 14f, FontStyle.Regular);
            }
        }

        private void amountTextBox_Leave(object sender, EventArgs e)
        {
            if (amountTextBox.Text == "")
            {
                amountTextBox.Text = "Amount";
                amountTextBox.ForeColor = Color.Gray;
                amountTextBox.Font = new Font(amountTextBox.Font.FontFamily, 14f, FontStyle.Regular);
            }
        }

        private void addTransaction_Load(object sender, EventArgs e)
        {

        }

        private void accountLabel_Click(object sender, EventArgs e)
        {

        }

        private void updateCategoryTable(string username, int amount, string category)
        {
            string query = "UPDATE categories SET Spending = @spending WHERE Username = @username AND Category = @category";

            var cmd = dataAccess.GetCommand(query);

            int updatedAmount = getCategorySpending(username, category) + amount;

            cmd.Parameters.AddWithValue("@spending", updatedAmount);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@category", category);

            dataAccess.ExecuteNonQueryCommand(cmd);
        }

        private int getCategorySpending(string username, string category)
        {
            string query = "Select Spending FROM categories WHERE Username = @username AND Category = @category";

            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@category", category);

            DataTable categoryTable = dataAccess.ExecuteCommand(cmd);

            return Convert.ToInt32(categoryTable.Rows[0]["Spending"]);


        }
        private void updateAccountTable(string username)
        {
            string query = "SELECT Credit, CashInHand, Bank FROM accounts WHERE Username = @Username";

            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@Username", username);
            // Execute the query and get a DataTable with the results
            accountDataTable = dataAccess.ExecuteCommand(cmd);

        }
        private void updateCashInHandAmount(string username, int amount, string category)
        {
            string query = "UPDATE accounts SET CashInHand = @cash WHERE Username = @username";

            var cmd = dataAccess.GetCommand(query);

            if (category != "Income")
            {
                int updatedCashAmount = Convert.ToInt32(accountDataTable.Rows[0]["CashInHand"]) - amount;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@cash", updatedCashAmount);
                dataAccess.ExecuteNonQueryCommand(cmd);
                updateFinancialInfoTableForCash(username, updatedCashAmount);
            }
            else
            {
                int updatedCashAmount = Convert.ToInt32(accountDataTable.Rows[0]["CashInHand"]) + amount;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@cash", updatedCashAmount);
                dataAccess.ExecuteNonQueryCommand(cmd);
                updateFinancialInfoTableForCash(username, updatedCashAmount);
            }
            
        }
        private void updateFinancialInfoTableForCash(string username, int amount)
        {
            string query = "UPDATE financialInfo SET CashInHand = @cash WHERE Username = @username";

            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@cash", amount);
            dataAccess.ExecuteNonQueryCommand(cmd);
        }
        private void updateBankAmount(string username, int amount, string category)
        {
            string query = "UPDATE accounts SET Bank = @bank WHERE Username = @username";

            var cmd = dataAccess.GetCommand(query);

            if (category != "Income")
            {
                int updatedBankAmount = Convert.ToInt32(accountDataTable.Rows[0]["Bank"]) - amount;

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@bank", updatedBankAmount);
                dataAccess.ExecuteNonQueryCommand(cmd);
                updateFinancialInfoTableForBank(username, updatedBankAmount);
            }
            else
            {
                int updatedBankAmount = Convert.ToInt32(accountDataTable.Rows[0]["Bank"]) + amount;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@bank", updatedBankAmount);
                dataAccess.ExecuteNonQueryCommand(cmd);
                updateFinancialInfoTableForBank(username, updatedBankAmount);
            }
        }

        private void updateFinancialInfoTableForBank(string username, int amount)
        {
            string query = "UPDATE financialInfo SET BankBalance = @bank WHERE Username = @username";

            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@bank", amount);
            dataAccess.ExecuteNonQueryCommand(cmd);

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
            if(!entryExistCheck(username, monthNumber)) 
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
            if(table.Rows.Count > 0)
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
        private void updateDailyTable(string username, string type, string amount)
        {
            string query = "insert into dailyExpenseIncome ([Username], [Type], [Amount]) values(@username, @type, @amount)";

            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@amount", amount);

            dataAccess.ExecuteNonQueryCommand(cmd);
        }
        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(categoryComboBox.Text != "" && accountComboBox.Text != "" && amountTextBox.Text != "" && noteTextbox.Text != "")
                {
                    string query = "insert into [transaction] ([Username], [Category], [Account], [Note], [Amount]) values(@username, @Category, @Account, @Note, @Amount)";

                    string category = categoryComboBox.Text;
                    string account = accountComboBox.Text;
                    string amount = (amountTextBox.Text);
                    string note = noteTextbox.Text;


                    int Amount = Convert.ToInt32(amount);

                    if(account == "Cash in Hand")
                    {
                        if (category != "Income")
                        {
                            if (Convert.ToInt32(accountDataTable.Rows[0]["CashInHand"]) >= Amount)
                            {
                                updateCashInHandAmount(username, Amount, category);
                                updateCategoryTable(username, Amount, category);

                                updateMonthlyTableExpense(username, Amount);
                                updateDailyTable(username, "Expense", amount);



                                var cmd = dataAccess.GetCommand(query);

                                cmd.Parameters.AddWithValue("@username", username);
                                cmd.Parameters.AddWithValue("@Category", category);
                                cmd.Parameters.AddWithValue("@Account", account);
                                cmd.Parameters.AddWithValue("@Note", note);
                                cmd.Parameters.AddWithValue("@Amount", amount);
                                dataAccess.ExecuteNonQueryCommand(cmd);

                                MessageBox.Show("Transaction updated");
                            }

                            else
                            {
                                MessageBox.Show("Not enough balance in selected account");
                            }
                        }
                        else
                        {
                            updateCashInHandAmount(username, Amount, category);
                            updateCategoryTable(username, Amount, category);

                            updateMonthlyTableIncome(username, Amount);
                            updateDailyTable(username, "Income", amount);


                            var cmd = dataAccess.GetCommand(query);

                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@Category", category);
                            cmd.Parameters.AddWithValue("@Account", account);
                            cmd.Parameters.AddWithValue("@Note", note);
                            cmd.Parameters.AddWithValue("@Amount", amount);
                            dataAccess.ExecuteNonQueryCommand(cmd);

                            MessageBox.Show("Transaction updated");
                        }
                    }
                    else
                    {
                        if (category != "Income")
                        {
                            if (Convert.ToInt32(accountDataTable.Rows[0]["Bank"]) >= Amount)
                            {
                                updateBankAmount(username, Amount, category);
                                updateCategoryTable(username, Amount, category);

                                updateMonthlyTableExpense(username, Amount);
                                updateDailyTable(username, "Expense", amount);


                                var cmd = dataAccess.GetCommand(query);

                                cmd.Parameters.AddWithValue("@username", username);
                                cmd.Parameters.AddWithValue("@Category", category);
                                cmd.Parameters.AddWithValue("@Account", account);
                                cmd.Parameters.AddWithValue("@Note", note);
                                cmd.Parameters.AddWithValue("@Amount", amount);
                                dataAccess.ExecuteNonQueryCommand(cmd);

                                MessageBox.Show("Transaction updated");
                            }
                            else
                            {
                                MessageBox.Show("Not enough balance in selected account");
                            }
                        }
                        else
                        {
                            updateBankAmount(username, Amount, category);
                            updateCategoryTable(username, Amount, category);
                            updateMonthlyTableIncome(username, Amount);
                            updateDailyTable(username, "Income", amount);

                            var cmd = dataAccess.GetCommand(query);

                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@Category", category);
                            cmd.Parameters.AddWithValue("@Account", account);
                            cmd.Parameters.AddWithValue("@Note", note);
                            cmd.Parameters.AddWithValue("@Amount", amount);
                            dataAccess.ExecuteNonQueryCommand(cmd);

                            MessageBox.Show("Transaction updated");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Please fill all the required field");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please add valid value");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            transaction transaction = new transaction(username);
            transaction.Show();
        }
    }
}
