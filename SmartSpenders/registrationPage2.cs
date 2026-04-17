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
    public partial class registrationPage2 : Form
    {
        string databaseFileName = "Database1.mdf";
        DataAccess dataAccess;
        string username;
        public registrationPage2(string username)
        {
            InitializeComponent();
            this.username = username;
            dataAccess = new DataAccess(databaseFileName);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (bankNameTextBox.Text != "" && cardTypeComboBox.Text != "" && cardNumberTextBox.Text != "" && bankBalanceTextBox.Text != "" && expireDateTextBox.Text != "" && cashInHandTextBox.Text != "" && monthlyBudgetTextBox.Text != "")
                {
                    insertIntoGeneralDatabase();
                    updateAccountDatabase();
                    updateCategories(username, "Food");
                    updateCategories(username, "Transport");
                    updateCategories(username, "Bill");
                    updateCategories(username, "Income");
                    updateCategories(username, "Debit");
                    updateCategories(username, "Credit");



                    MessageBox.Show("Registration successfull");
                    loginPage form1 = new loginPage();
                    this.Hide();
                    form1.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Please fill the required fields");
                }
            /*}
            catch (Exception ex)
            {
                MessageBox.Show("\nPlease add valid values");
            }*/
        }
        private void updateCategories(string username, string category)
        {
            string query = "INSERT into categories ([Username], [Category], [Spending]) values(@username, @category, @spending)";
            var cmd = dataAccess.GetCommand(query);
            int spending = 0;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@spending", spending);

            dataAccess.ExecuteNonQueryCommand(cmd);

        }
        private void insertIntoGeneralDatabase()
        {
            string query = "insert into [financialInfo] ([Username], [BankName], [CardType], [CardNumber], [BankBalance], [ExpireDate], [CashInHand], [MonthlyBudget]) values(@username, @bankName, @cardType, @cardNumber, @bankBalance, @expireDate, @cashInHand, @monthlyBudget)";

            string bankName = bankNameTextBox.Text;
            string cardType = cardNumberTextBox.Text;
            string cardNumber = cardNumberTextBox.Text;
            int bankBalance = Convert.ToInt32(bankBalanceTextBox.Text);
            string expireDate = expireDateTextBox.Text;
            int cashInHand = Convert.ToInt32(cashInHandTextBox.Text);
            int monthlyBudget = Convert.ToInt32(monthlyBudgetTextBox.Text);

            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@bankName", bankName);
            cmd.Parameters.AddWithValue("@cardType", cardType);
            cmd.Parameters.AddWithValue("@cardNumber", cardNumber);
            cmd.Parameters.AddWithValue("@bankBalance", bankBalance);
            cmd.Parameters.AddWithValue("@expireDate", expireDate);
            cmd.Parameters.AddWithValue("@cashInHand", cashInHand);
            cmd.Parameters.AddWithValue("@monthlyBudget", monthlyBudget);
            cmd.Parameters.AddWithValue("@userName", username);
            dataAccess.ExecuteNonQueryCommand(cmd);
        }

        private void updateAccountDatabase()
        {
            string query = "insert into [accounts] ([Username], [CashInHand], [Bank], [Credit], [Debit]) values(@username, @cashInHand, @bank, @credit, @debit)";


            int cashInHand = Convert.ToInt32(cashInHandTextBox.Text);
            int bankBalance = Convert.ToInt32(bankBalanceTextBox.Text);
            int credit = 0;
            int debit = 0;

            var cmd = dataAccess.GetCommand(query);


            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@cashInHand", cashInHand);
            cmd.Parameters.AddWithValue("@bank", bankBalance);
            cmd.Parameters.AddWithValue("@credit", credit);
            cmd.Parameters.AddWithValue("@debit", debit);

            dataAccess.ExecuteNonQueryCommand(cmd);
        }

        private void bankNameTextBox_Enter(object sender, EventArgs e)
        {
            if(bankNameTextBox.Text == "Bank name")
            {
                bankNameTextBox.Text = "";
                bankNameTextBox.ForeColor = Color.Black;
                bankNameTextBox.Font = new Font(bankNameTextBox.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }

        private void bankNameTextBox_Leave(object sender, EventArgs e)
        {
            if (bankNameTextBox.Text == "")
            {
                bankNameTextBox.Text = "Bank name";
                bankNameTextBox.ForeColor = Color.Gray;
                bankNameTextBox.Font = new Font(bankNameTextBox.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }
        private void cardNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (cardNumberTextBox.Text == "Card number")
            {
                cardNumberTextBox.Text = "";
                cardNumberTextBox.ForeColor = Color.Black;
                cardNumberTextBox.Font = new Font(cardNumberTextBox.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }

        private void cardNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (cardNumberTextBox.Text == "")
            {
                cardNumberTextBox.Text = "Card number";
                cardNumberTextBox.ForeColor = Color.Gray;
                cardNumberTextBox.Font = new Font(cardNumberTextBox.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }
        private void expireDateTextBox_Enter(object sender, EventArgs e)
        {
            if (expireDateTextBox.Text == "MM-YY")
            {
                expireDateTextBox.Text = "";
                expireDateTextBox.ForeColor = Color.Black;
                expireDateTextBox.Font = new Font(expireDateTextBox.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }

        private void expireDateTextBox_Leave(object sender, EventArgs e)
        {
            if (expireDateTextBox.Text == "")
            {
                expireDateTextBox.Text = "MM-YY";
                expireDateTextBox.ForeColor = Color.Gray;
                expireDateTextBox.Font = new Font(expireDateTextBox.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }
        private void bankBalanceTextBox_Enter(object sender, EventArgs e)
        {
            if (bankBalanceTextBox.Text == "Bank balance")
            {
                bankBalanceTextBox.Text = "";
                bankBalanceTextBox.ForeColor = Color.Black;
                bankBalanceTextBox.Font = new Font(bankBalanceTextBox.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }

        private void bankBalanceTextBox_Leave(object sender, EventArgs e)
        {
            if (bankBalanceTextBox.Text == "")
            {
                bankBalanceTextBox.Text = "Bank balance";
                bankBalanceTextBox.ForeColor = Color.Gray;
                bankBalanceTextBox.Font = new Font(bankBalanceTextBox.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }
        private void cashInHandTextBox_Enter(object sender, EventArgs e)
        {
            if (cashInHandTextBox.Text == "Cash in hand")
            {
                cashInHandTextBox.Text = "";
                cashInHandTextBox.ForeColor = Color.Black;
                cashInHandTextBox.Font = new Font(cashInHandTextBox.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }

        private void cashInHandTextBox_Leave(object sender, EventArgs e)
        {
            if (cashInHandTextBox.Text == "")
            {
                cashInHandTextBox.Text = "Cash in hand";
                cashInHandTextBox.ForeColor = Color.Gray;
                cashInHandTextBox.Font = new Font(cashInHandTextBox.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }
        private void monthlyBudgetTextBox_Enter(object sender, EventArgs e)
        {
            if (monthlyBudgetTextBox.Text == "Monthly budget")
            {
                monthlyBudgetTextBox.Text = "";
                monthlyBudgetTextBox.ForeColor = Color.Black;
                monthlyBudgetTextBox.Font = new Font(monthlyBudgetTextBox.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }

        private void monthlyBudgetTextBox_Leave(object sender, EventArgs e)
        {
            if (monthlyBudgetTextBox.Text == "")
            {
                monthlyBudgetTextBox.Text = "Monthly budget";
                monthlyBudgetTextBox.ForeColor = Color.Gray;
                monthlyBudgetTextBox.Font = new Font(monthlyBudgetTextBox.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }

    }
}
