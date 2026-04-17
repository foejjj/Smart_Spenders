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
    public partial class addDebitTransaction : Form
    {
        private DataAccess dataAccess;
        DataTable accountDataTable;
        string username;
        int id;
        public addDebitTransaction(string username)
        {
            InitializeComponent();
            this.username = username;
            dataAccess = new DataAccess("Database1.mdf");
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT Id, Name, Amount FROM debit WHERE Username = @Username";

            // Parameters to filter by username (replace 'hasan1234' with the logged-in username)
            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@Username", username);
            // Execute the query and get a DataTable with the results
            DataTable dataTable = dataAccess.ExecuteCommand(cmd);

            // Clear the combo box before adding items
            debitComboBox.Items.Clear();

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Loop through each row in the DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    // Get the Name and Amount columns from each row
                    int id = Convert.ToInt32(row["Id"]);
                    string name = row["Name"].ToString();
                    int amount = Convert.ToInt32(row["Amount"]);

                    // Format the string as "Name Amount TK" and add it to the combo box
                    debitComboBox.Items.Add($"{id} {name} {amount} TK");
                }
            }
            else
            {
                MessageBox.Show("No data found in the 'credit' table.");
            }
            updateAccountTable(username);

        }
        private void updateAccountTable(string username)
        {
            string query = "SELECT Debit, CashInHand, Bank FROM accounts WHERE Username = @Username";

            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@Username", username);
            // Execute the query and get a DataTable with the results
            accountDataTable = dataAccess.ExecuteCommand(cmd);

        }
        private void deleteRowFromCreditTable(int id)
        {
            string query = "DELETE FROM debit WHERE Id = @id";

            var cmd = dataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@id", id);
            dataAccess.ExecuteNonQueryCommand(cmd);

        }
        private void updateDebitAmount(int amount)
        {
            string query = "UPDATE accounts SET Debit = @debit WHERE Username = @username";

            var cmd = dataAccess.GetCommand(query);



            int updatedDebitAmount = Convert.ToInt32(accountDataTable.Rows[0]["Debit"]) + amount;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@debit", updatedDebitAmount);
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

            string category = "Debit";
            string account = accountComboBox.Text;
            string note = "cleared debit amount";

            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@Category", category);
            cmd.Parameters.AddWithValue("@Account", account);
            cmd.Parameters.AddWithValue("@Note", note);
            cmd.Parameters.AddWithValue("@Amount", amount);
            dataAccess.ExecuteNonQueryCommand(cmd);
        }
        private void addDebitTransaction_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            transaction transaction = new transaction(username);
            transaction.Show();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (debitComboBox.SelectedItem != null)
            {
                // Get the selected item from the ComboBox
                string selectedItem = debitComboBox.SelectedItem.ToString();

                // Extract the Name and Amount from the selected item
                string[] parts = selectedItem.Split(' ');
                int id = Convert.ToInt16(parts[0]);
                int amount = Convert.ToInt32(parts[2]);
                string accountName = accountComboBox.Text;



                //update accounts table
                updateDebitAmount(amount);

                if (accountName == "Bank")
                {
                    updateBankAmount(username, amount);
                }
                else if (accountName == "Cash in Hand")
                {
                    updateCashInHandAmount(username, amount);
                }

                // Delete the row from the database
                deleteRowFromCreditTable(id);
                updateTransaction(amount);
                // Refresh the ComboBox to reflect the changes
                LoadData();
            }

            MessageBox.Show("Transaction updated");
        }
    }
}
