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
    public partial class addCredit : Form
    {
        DataAccess dataAccess;
        string username;

        DataTable accountDataTable;
        public addCredit(string username)
        {
            InitializeComponent();
            
            dataAccess = new DataAccess("Database1.mdf");
            this.username = username;
            updateAccountTable(username);
        }


        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Name")
            {
                nameTextBox.Text = "";
                nameTextBox.ForeColor = Color.Black;
                nameTextBox.Font = new Font(nameTextBox.Font.FontFamily, 14f, FontStyle.Regular);
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                nameTextBox.Text = "Name";
                nameTextBox.ForeColor = Color.Gray;
                nameTextBox.Font = new Font(nameTextBox.Font.FontFamily, 14f, FontStyle.Regular);
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
        private void updateAccountTable(string username)
        {
            string query = "SELECT Credit, CashInHand, Bank FROM accounts WHERE Username = @Username";

            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@Username", username);
            // Execute the query and get a DataTable with the results
            accountDataTable = dataAccess.ExecuteCommand(cmd);

        }
        private void updateCreditAmount(int amount)
        {
            string query = "UPDATE accounts SET Credit = @credit WHERE Username = @username";

            var cmd = dataAccess.GetCommand(query);



            int updatedDebitAmount = Convert.ToInt32(accountDataTable.Rows[0]["Credit"]) + amount;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@credit", updatedDebitAmount);
            dataAccess.ExecuteNonQueryCommand(cmd);
        }
        private void updateBankAmount(string username, int amount)
        {
            string query = "UPDATE accounts SET Bank = @bank WHERE Username = @username";

            var cmd = dataAccess.GetCommand(query);

            int updatedBankAmount = Convert.ToInt32(accountDataTable.Rows[0]["Bank"]) + amount;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@bank", updatedBankAmount);
            dataAccess.ExecuteNonQueryCommand(cmd);
            updateFinancialInfoTableForBank(username, updatedBankAmount);
        }

        private void updateFinancialInfoTableForBank(string username, int amount)
        {
            string query = "UPDATE financialInfo SET BankBalance = @bank WHERE Username = @username";

            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@bank", amount);
            dataAccess.ExecuteNonQueryCommand(cmd);

        }
        private void updateCashInHandAmount(string username, int amount)
        {
            string query = "UPDATE accounts SET CashInHand = @cash WHERE Username = @username";

            var cmd = dataAccess.GetCommand(query);

            int updatedCashAmount = Convert.ToInt32(accountDataTable.Rows[0]["CashInHand"]) + amount;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@cash", updatedCashAmount);
            dataAccess.ExecuteNonQueryCommand(cmd);
            updateFinancialInfoTableForCash(username, updatedCashAmount);
        }

        private void updateFinancialInfoTableForCash(string username, int amount)
        {
            string query = "UPDATE financialInfo SET CashInHand = @cash WHERE Username = @username";

            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@cash", amount);
            dataAccess.ExecuteNonQueryCommand(cmd);
        }
        private void updateTransaction(int amount)
        {
            string query = "insert into [transaction] ([Username], [Category], [Account], [Note], [Amount]) values(@username, @Category, @Account, @Note, @Amount)";

            string category = "Credit";
            string account = accountComboBox.Text;
            string note = "Took Credit";

            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@Category", category);
            cmd.Parameters.AddWithValue("@Account", account);
            cmd.Parameters.AddWithValue("@Note", note);
            cmd.Parameters.AddWithValue("@Amount", amount);
            dataAccess.ExecuteNonQueryCommand(cmd);
        }
        private void enterButton_Click(object sender, EventArgs e)
        {
           try
           {
                if (nameTextBox.Text != "" && amountTextBox.Text != "" && accountComboBox.Text != "")
                {
                    string query = "INSERT into credit ([Username], [Name], [Amount]) values(@username, @name, @amount)";

                    var cmd = dataAccess.GetCommand(query);

                    string accountName = accountComboBox.Text;
                    string name = nameTextBox.Text;
                    int amount = Convert.ToInt32(amountTextBox.Text);

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@amount", amount);

                    dataAccess.ExecuteNonQueryCommand(cmd);

                    

                    updateCreditAmount(amount);

                    if (accountName == "Bank")
                    {
                        updateBankAmount(username, amount);
                    }
                    else if (accountName == "Cash in Hand")
                    {
                        updateCashInHandAmount(username, amount);
                    }
                    updateTransaction(amount);

                    MessageBox.Show("Credit updated");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid values");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCredit_Load(object sender, EventArgs e)
        {

        }
    }
}
