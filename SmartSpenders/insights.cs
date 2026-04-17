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
using System.Windows.Forms.DataVisualization.Charting;

namespace SmartSpenders
{
    public partial class insights : Form
    {
        string username;
        private DataAccess dataAccess;
        DataTable spendingTable;
        string databaseFileName = "Database1.mdf";
        public insights(string username)
        {
            InitializeComponent();
            this.username = username;
            dataAccess = new DataAccess(databaseFileName);
            LoadTable();
            LoadChart();

            CreditUpdate();
            DebitUpdate();
            bankInfoLoad();
            LoadProfilePicture(username);
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
        
        private void LoadTable()
        {
            string query = "SELECT * FROM categories where Username = @username";
            var cmd = dataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@username", username);
            spendingTable = dataAccess.ExecuteCommand(cmd);
        }

        private void LoadChart()
        {
            chart2.Series.Clear();
            chart2.Titles.Clear();

            Series series = new Series
            {
                Name = "Spending",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie,
            };
            chart2.Series.Add(series);

            foreach (DataRow row in spendingTable.Rows)
            {
                int spendingValue = Convert.ToInt32(row["Spending"]);
                if (spendingValue > 0)
                {
                    series.Points.AddXY(row["Category"].ToString(), spendingValue);
                }
            }

            Title chartTitle = new Title
            {
                Text = "Spending Categories",
                ForeColor = Color.White // Set the title color to white
            };

            chart2.Titles.Add(chartTitle);
        }

        private void test_Load(object sender, EventArgs e)
        {

        }

        private void transactionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            transaction transaction = new transaction(username);
            transaction.Show();
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

        private void categoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            categories categories = new categories(username);
            categories.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginPage loginPage = new loginPage();
            loginPage.Show();
        }

        private void insights_Load(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard dashboard = new dashboard(username);
            dashboard.Show();
        }
    }
}
