using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSpenders
{
    public partial class transaction : Form
    {
        private DataAccess dataAccess;
        string username;
        bool isEditable = false;
        DataGridViewButtonColumn deleteButton;
        public transaction(string username)
        {
            InitializeComponent();
            this.username = username;
            dataAccess = new DataAccess("Database1.mdf");
            warningPanel.Visible = false;
            waningCloseButton.Visible = false;
            // Load data
            LoadData();

            // Add the delete button column
            AddDeleteButtonColumn();


            bankInfoLoad();
            CreditUpdate();
            DebitUpdate();
            LoadProfilePicture(username);
            if (checkMonthlyBudget(username))
            {
                warningPanel.Visible = true;
                waningCloseButton.Visible = true;
            }
        }

        private void LoadData()
        {
            string query = "SELECT * FROM [dbo].[transaction] where Username= @username ORDER BY id DESC";
            var cmd = dataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@username", username);
            dataGridView1.DataSource = dataAccess.ExecuteCommand(cmd);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
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
        private void AddDeleteButtonColumn()
        {
            deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true; // Show "Delete" on all buttons
            dataGridView1.Columns.Add(deleteButton);
            deleteButton.Visible = false;
        }

        private void DeleteRow(int columnIndex, int rowIndex)
        {
            if (columnIndex == 6) // Ensure the row index is valid
            {
                // Confirm the deletion
                var confirmResult = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo);
                 try
                 {

                    // Get the Id of the selected row
                    int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Id"].Value);

                    // Remove the row from the database
                    string query = "DELETE FROM [dbo].[transaction] WHERE Id = @Id";
                    var cmd = dataAccess.GetCommand(query);
                    cmd.Parameters.AddWithValue("@Id", id);

                    // Execute the deletion command
                    dataAccess.ExecuteNonQueryCommand(cmd);

                    // Remove the row from the DataGridView
                    dataGridView1.Rows.RemoveAt(rowIndex);

                    MessageBox.Show("Row deleted successfully.");
                 }
                 catch (Exception ex)
                 {
                    MessageBox.Show("Error while deleting the row: " + ex.Message);
                 }
                
            }
            else
            {
                MessageBox.Show("Invalid row selected.");
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private bool checkMonthlyBudget(string username)
        {
            int month = DateTime.Now.Month;
            string query = "SELECT * FROM monthlyTotalIncomeExpense WHERE Username = @username AND MonthNumber = @month";
            var cmd = dataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@month", month);
            DataTable table = dataAccess.ExecuteCommand(cmd);
            int expense = Convert.ToInt32(table.Rows[0]["Expense"]);
            int monthlyBudget = Convert.ToInt32(table.Rows[0]["MonthlyBudget"]);
            if (expense > monthlyBudget)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            addTransactionChoice addTransactionChoice1 = new addTransactionChoice(username);
            addTransactionChoice1.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Now you can edit transactions");
            dataGridView1.ReadOnly = false;
            isEditable = true;
            deleteButton.Visible = true;
        }

        private void transaction_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.database1DataSet.transaction);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isEditable)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Id"].Value != null && !row.IsNewRow)
                    {
                        int id = Convert.ToInt32(row.Cells["Id"].Value);

                        string category = row.Cells["Category"].Value?.ToString();
                        string account = row.Cells["Account"].Value?.ToString();
                        string note = row.Cells["Note"].Value?.ToString();
                        string amount = row.Cells["Amount"].Value?.ToString();

                        // Make sure to use correct casing for column names
                        string query = "UPDATE [dbo].[transaction] SET Category = @category, Account = @account, Note = @note, Amount = @amount WHERE Id = @Id";

                        var cmd = dataAccess.GetCommand(query);

                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@account", account);
                        cmd.Parameters.AddWithValue("@note", note);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@Id", id);

                        dataAccess.ExecuteNonQueryCommand(cmd);
                    }
                }

                dataGridView1.ReadOnly = true;
                MessageBox.Show("Saved successfully");

                // Refresh data
                string refreshQuery = "SELECT * FROM [dbo].[transaction] where Username= @username ORDER BY id DESC";
                var refreshCmd = dataAccess.GetCommand(refreshQuery);
                refreshCmd.Parameters.AddWithValue("@username", username);
                dataGridView1.DataSource = dataAccess.ExecuteCommand(refreshCmd);
            }
            else
            {
                MessageBox.Show("Can't save, Edit values first");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                // Call the function to delete the row
                DeleteRow(e.ColumnIndex, e.RowIndex);
            }
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard(username);
            dashboard.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            loginPage loginPage = new loginPage();
            loginPage.Show();
            this.Hide();
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            categories categories = new categories(username);
            this.Hide();
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

        private void waningCloseButton_Click(object sender, EventArgs e)
        {
            waningCloseButton.Visible = false;
            warningPanel.Visible = false;
        }

        private void insightsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            insights insights = new insights(username);
            insights.Show();
        }
    }
}
