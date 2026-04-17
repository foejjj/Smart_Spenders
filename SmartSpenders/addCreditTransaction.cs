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
    public partial class addCreditTransaction : Form
    {
        DataAccess dataAccess;
        DataTable accountDataTable;
        string username;
        int id;
        public addCreditTransaction(string username)
        {
            InitializeComponent();
            this.username = username;
            dataAccess = new DataAccess("Database1.mdf");
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT Id, Name, Amount FROM credit WHERE Username = @Username";

            // Parameters to filter by username (replace 'hasan1234' with the logged-in username)
            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@Username", username);
            // Execute the query and get a DataTable with the results
            DataTable dataTable = dataAccess.ExecuteCommand(cmd);

            // Clear the combo box before adding items
            creditComboBox.Items.Clear();

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
                    creditComboBox.Items.Add($"{id} {name} {amount} TK");
                }
            }
            else
            {
                MessageBox.Show("No data found in the 'credit' table.");
            }
            updateAccountTable(username);

        }

        private void addCreditTransaction_Load(object sender, EventArgs e)
        {
            
        }

        private void deleteRowFromCreditTable(int id)
        {
            string query = "DELETE FROM credit WHERE Id = @id";

            var cmd = dataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@id", id);
            dataAccess.ExecuteNonQueryCommand(cmd);

        }

        private void updateCreditAmount(int amount)
        {
            string query = "UPDATE accounts SET Credit = @credit WHERE Username = @username";

            var cmd = dataAccess.GetCommand(query);



            int updatedCreditAmount = Convert.ToInt32(accountDataTable.Rows[0]["Credit"]) - amount;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@credit", updatedCreditAmount);
            dataAccess.ExecuteNonQueryCommand(cmd);
        }

        private void updateBankAmount(string username, int amount)
        {
            string query = "UPDATE accounts SET Bank = @bank WHERE Username = @username";

            var cmd = dataAccess.GetCommand(query);

            int updatedBankAmount = Convert.ToInt32(accountDataTable.Rows[0]["Bank"]) - amount;
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

            int updatedCashAmount = Convert.ToInt32(accountDataTable.Rows[0]["CashInHand"]) - amount;
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

        private void updateAccountTable(string username)
        {
            string query = "SELECT Credit, CashInHand, Bank FROM accounts WHERE Username = @Username";

            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@Username", username);
            // Execute the query and get a DataTable with the results
            accountDataTable = dataAccess.ExecuteCommand(cmd);

            //return Convert.ToInt32(accountDataTable.Rows[0]["Credit"]);
        }
        
        
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            transaction transaction = new transaction(username);
            transaction.Show();
        }

        private void updateTransaction(int amount)
        {
            string query = "insert into [transaction] ([Username], [Category], [Account], [Note], [Amount]) values(@username, @Category, @Account, @Note, @Amount)";

            string category = "Credit";
            string account = accountComboBox.Text;
            string note = "cleared credit amount";

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
            if (creditComboBox.SelectedItem != null)
            {
                // Get the selected item from the ComboBox
                string selectedItem = creditComboBox.SelectedItem.ToString();

                // Extract the Name and Amount from the selected item
                string[] parts = selectedItem.Split(' ');
                int id = Convert.ToInt16(parts[0]);
                int amount = Convert.ToInt32(parts[2]);
                string accountName = accountComboBox.Text;

                

                if (accountName == "Bank")
                {
                    if (Convert.ToInt32(accountDataTable.Rows[0]["Bank"]) >= amount)
                    {
                        updateBankAmount(username, amount);
                        updateCreditAmount(amount);

                        // Delete the row from the database
                        deleteRowFromCreditTable(id);
                        updateTransaction(amount);
                        // Refresh the ComboBox to reflect the changes
                        LoadData();
                        MessageBox.Show("Transaction updated");
                    }
                    else
                    {
                        MessageBox.Show("Not enough balance in selected account");
                    }
                }
                else if (accountName == "Cash in Hand")
                {
                    if (Convert.ToInt32(accountDataTable.Rows[0]["CashInHand"]) >= amount)
                    {
                        updateCashInHandAmount(username, amount);
                        updateCreditAmount(amount);

                        // Delete the row from the database
                        deleteRowFromCreditTable(id);
                        updateTransaction(amount);
                        // Refresh the ComboBox to reflect the changes
                        LoadData();
                        MessageBox.Show("Transaction updated");
                    }

                    else
                    {
                        MessageBox.Show("Not enough balance in selected account");
                    }
                }

                
            }
            
        }
    }
}
