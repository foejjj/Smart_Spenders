using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSpenders
{
    public partial class profile : Form
    {
        string username;
        private DataAccess dataAccess;
        DataTable generalUserInfoDataTable;
        DataTable FinancialInfoDataTable;
        DataTable accountDataTable;
        public profile(string username)
        {
            InitializeComponent();
            dataAccess = new DataAccess("Database1.mdf");
            this.username = username;
            GeneralInfoLoadData();
            FinancialInfoLoadData();
            LoadProfilePicture(username);
            LoadSmallProfilePicture(username);
            updateAccountTable(username);
        }

        private void GeneralInfoLoadData()
        {
            string query = "SELECT * From generalUserInfo WHERE Username = @username";

            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@username", username);

            generalUserInfoDataTable = dataAccess.ExecuteCommand(cmd);

            usernameLabel.Text = ": "+ generalUserInfoDataTable.Rows[0]["UserName"].ToString();
            firstNameLabel1.Text = ": " + generalUserInfoDataTable.Rows[0]["FirstName"].ToString();
            lastNameLabel1.Text = ": " + generalUserInfoDataTable.Rows[0]["LastName"].ToString(); 
            emailLabel.Text = ": " + generalUserInfoDataTable.Rows[0]["EmailAddress"].ToString();
            joinDateLabel.Text = ": " + generalUserInfoDataTable.Rows[0]["CreatedDate"].ToString();
            dateOfBirthLabel.Text = ": " + generalUserInfoDataTable.Rows[0]["DOB"].ToString();

        }

        private void FinancialInfoLoadData()
        {
            string query = "SELECT * From financialInfo WHERE Username = @username";

            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@username", username);

            FinancialInfoDataTable = dataAccess.ExecuteCommand(cmd);

            bankNameLabel.Text = ": " + FinancialInfoDataTable.Rows[0]["BankName"].ToString();
            bankBalanceLabel.Text = ": " + FinancialInfoDataTable.Rows[0]["BankBalance"].ToString();
            expireDateLabel.Text = ": " + FinancialInfoDataTable.Rows[0]["ExpireDate"].ToString();
            cardNoLabel.Text = ": " + FinancialInfoDataTable.Rows[0]["CardNumber"].ToString();
            cardTypeLabel.Text = ": " + FinancialInfoDataTable.Rows[0]["CardType"].ToString();
            monthlyBudgetLabel.Text = ": " + FinancialInfoDataTable.Rows[0]["MonthlyBudget"].ToString();


        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
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
        private void LoadSmallProfilePicture(string userName)
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
                smallProfilePictureBox.Image = ByteArrayToImage(imageBytes);
            }
            else
            {
                MessageBox.Show("No profile picture found.");
            }
        }

        private void PictureBox1Load()
        {
            string query = "SELECT ProfilePicture FROM [generalUserInfo] WHERE UserName = @UserName";
            var cmd = dataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@UserName", username);

            // Execute the scalar command to retrieve the image bytes from the database
            object imageBytesObj = dataAccess.ExecuteScalar(cmd);

            if (imageBytesObj != null && imageBytesObj != DBNull.Value)
            {
                byte[] imageBytes = (byte[])imageBytesObj;

                // Convert the byte array to an image and display it in the PictureBox
                pictureBox1.Image = ByteArrayToImage(imageBytes);
            }
            else
            {
                MessageBox.Show("No profile picture found.");
            }
        }

        private void profile_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void updateAccountTable(string username)
        {
            string query = "SELECT Credit, CashInHand, Bank FROM accounts WHERE Username = @Username";

            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@Username", username);
            // Execute the query and get a DataTable with the results
            accountDataTable = dataAccess.ExecuteCommand(cmd);

        }
        private void updateBankAmount(string username, int amount)
        {
            string query = "UPDATE accounts SET Bank = @bank WHERE Username = @username";

            var cmd = dataAccess.GetCommand(query);

            int updatedBankAmount = Convert.ToInt32(accountDataTable.Rows[0]["Bank"]) + amount;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@bank", updatedBankAmount);
            dataAccess.ExecuteNonQueryCommand(cmd);
        }

        private void editButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Now you can edit");


            firstNameTextBox.Visible = true;
            lastNameTextBox.Visible = true;
            emailTextBox.Visible = true;
            dateOfBirthTextBox.Visible = true;
            bankNameTextBox.Visible = true;
            bankBalanceTextBox.Visible = true;
            cardTypeTextBox.Visible = true;
            cardNumberTextBox.Visible = true;
            expireDateTextBox.Visible = true;
            monthlyBudgetTextBox.Visible = true;
            profilePictureFilePathTextBox.Visible = true;
            imageUploadButton.Visible = true;
            profilePictureLabel.Visible = true;
            pictureBox1.Visible = true;

            firstNameLabel1.Visible = false;
            lastNameLabel1.Visible = false;
            emailLabel.Visible = false;
            dateOfBirthLabel.Visible = false;
            bankNameLabel.Visible = false;
            bankBalanceLabel.Visible = false;
            cardTypeLabel.Visible = false;
            cardNoLabel.Visible = false;
            expireDateLabel.Visible = false;
            monthlyBudgetLabel.Visible = false;

            PictureBox1Load();


            firstNameTextBox.Text = generalUserInfoDataTable.Rows[0]["FirstName"].ToString();
            lastNameTextBox.Text = generalUserInfoDataTable.Rows[0]["LastName"].ToString();
            emailTextBox.Text = generalUserInfoDataTable.Rows[0]["EmailAddress"].ToString();
            dateOfBirthTextBox.Text = generalUserInfoDataTable.Rows[0]["DOB"].ToString();

            bankNameTextBox.Text = FinancialInfoDataTable.Rows[0]["BankName"].ToString();
            bankBalanceTextBox.Text = FinancialInfoDataTable.Rows[0]["BankBalance"].ToString();
            cardTypeTextBox.Text = FinancialInfoDataTable.Rows[0]["CardType"].ToString();
            cardNumberTextBox.Text = FinancialInfoDataTable.Rows[0]["CardNumber"].ToString();
            expireDateTextBox.Text = FinancialInfoDataTable.Rows[0]["ExpireDate"].ToString();
            monthlyBudgetTextBox.Text = FinancialInfoDataTable.Rows[0]["MonthlyBudget"].ToString();



        }
        public void UpdateGeneralInfo(string updatedFirstname, string updatedLastname, string updatedEmail, string updatedDateOfBirth, int id)
        {

            if (profilePictureFilePathTextBox.Text == "")
            {

                string query = "UPDATE generalUserInfo SET FirstName = @firstname, LastName = @lastname, EmailAddress = @email, DOB = @dateOfBirth WHERE Id = @id";
                var cmd = dataAccess.GetCommand(query);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@firstname", updatedFirstname);
                cmd.Parameters.AddWithValue("@lastname", updatedLastname);
                cmd.Parameters.AddWithValue("@email", updatedEmail);
                cmd.Parameters.AddWithValue("@dateOfBirth", updatedDateOfBirth);

                dataAccess.ExecuteNonQueryCommand(cmd);
            }
            else
            {
                updateProfilePicture(updatedFirstname, updatedLastname, updatedEmail, updatedDateOfBirth, id);
            }
        }
        private void updateProfilePicture(string updatedFirstname, string updatedLastname, string updatedEmail, string updatedDateOfBirth, int id)
        {
            string query = "UPDATE generalUserInfo SET FirstName = @firstname, LastName = @lastname, EmailAddress = @email, DOB = @dateOfBirth, ProfilePicture = @ProfilePicture WHERE Id = @id";


            var cmd = dataAccess.GetCommand(query);

            byte[] imageBytes = ImageToByteArray(pictureBox1.Image);
            cmd.Parameters.AddWithValue("@ProfilePicture", imageBytes);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@firstname", updatedFirstname);
            cmd.Parameters.AddWithValue("@lastname", updatedLastname);
            cmd.Parameters.AddWithValue("@email", updatedEmail);
            cmd.Parameters.AddWithValue("@dateOfBirth", updatedDateOfBirth);

            dataAccess.ExecuteNonQueryCommand(cmd);
        }

        public void UpdateFinancialInfo(string updatedBankName, string updatedBankBalance, string updatedCardType,
                                string updatedCardNumber, string updatedExpireDate, string updatedMonthlyBudget, int id)
        {
            string query = "UPDATE financialInfo SET BankName = @bankName, BankBalance = @bankBalance, CardType = @cardType, " +
                           "CardNumber = @cardNumber, ExpireDate = @expireDate, MonthlyBudget = @monthlyBudget " +
                           "WHERE Id = @id"; // Assuming 'UserName' is used as a key to update financial info.

            var cmd = dataAccess.GetCommand(query);

            // Assigning the updated values to the query parameters
            cmd.Parameters.AddWithValue("@bankName", updatedBankName);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@bankBalance", updatedBankBalance);
            cmd.Parameters.AddWithValue("@cardType", updatedCardType);
            cmd.Parameters.AddWithValue("@cardNumber", updatedCardNumber);
            cmd.Parameters.AddWithValue("@expireDate", updatedExpireDate);
            cmd.Parameters.AddWithValue("@monthlyBudget", updatedMonthlyBudget);

            // Assuming the username is available (for example, from a session or passed as an argument)

            // Execute the command to update the database
            dataAccess.ExecuteNonQueryCommand(cmd);
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            // Check if any of the textboxes are empty
            if (
                string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                string.IsNullOrWhiteSpace(dateOfBirthTextBox.Text) ||
                string.IsNullOrWhiteSpace(bankNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(bankBalanceTextBox.Text) ||
                string.IsNullOrWhiteSpace(cardTypeTextBox.Text) ||
                string.IsNullOrWhiteSpace(cardNumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(expireDateTextBox.Text) ||
                string.IsNullOrWhiteSpace(monthlyBudgetTextBox.Text))
            {
                MessageBox.Show("Please fill all required fields.");
            }
            else
            {
                try
                {
                    string updatedFirstname = firstNameTextBox.Text;
                    string updatedLastName = lastNameTextBox.Text;
                    string updatedEmail = emailTextBox.Text;
                    string updatedDateOfBirth = dateOfBirthTextBox.Text;

                    DateTime dob = DateTime.Parse(updatedDateOfBirth);
                    string updatedDOB = dob.ToString("yyyy-MM-dd");
                    int genId = Convert.ToInt32(generalUserInfoDataTable.Rows[0]["Id"]);

                    string updatedBankName = bankNameTextBox.Text;
                    string updatedBankBalance = bankBalanceTextBox.Text;
                    string updatedCardType = cardTypeTextBox.Text;
                    string updatedCardNumber = cardNumberTextBox.Text;
                    string updatedExpireDate = expireDateTextBox.Text;
                    string updatedMonthlyBudget = monthlyBudgetTextBox.Text;
                    int finId = Convert.ToInt32(FinancialInfoDataTable.Rows[0]["Id"]);
                    

                    UpdateGeneralInfo(updatedFirstname,updatedLastName, updatedEmail, updatedDOB, genId);
                    UpdateFinancialInfo(updatedBankName, updatedBankBalance, updatedCardType, updatedCardNumber, updatedExpireDate, updatedMonthlyBudget, finId);

                    updateBankAmount(username, Convert.ToInt32(updatedBankBalance));

                    firstNameTextBox.Visible = false;
                    lastNameTextBox.Visible = false;
                    emailTextBox.Visible = false;
                    dateOfBirthTextBox.Visible = false;
                    bankNameTextBox.Visible = false;
                    bankBalanceTextBox.Visible = false;
                    cardTypeTextBox.Visible = false;
                    cardNumberTextBox.Visible = false;
                    expireDateTextBox.Visible = false;
                    monthlyBudgetTextBox.Visible = false;

                    profilePictureFilePathTextBox.Visible = false;
                    imageUploadButton.Visible = false;
                    profilePictureLabel.Visible = false;
                    pictureBox1.Visible = false;

                    firstNameLabel1.Visible = true;
                    lastNameLabel1.Visible = true;
                    emailLabel.Visible = true;
                    dateOfBirthLabel.Visible = true;
                    bankNameLabel.Visible = true;
                    bankBalanceLabel.Visible = true;
                    cardTypeLabel.Visible = true;
                    cardNoLabel.Visible = true;
                    expireDateLabel.Visible = true;
                    monthlyBudgetLabel.Visible = true;

                    GeneralInfoLoadData();
                    FinancialInfoLoadData();
                    LoadSmallProfilePicture(username);
                    updateAccountTable(username);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please add valid values");
                }
            }
        }

        private void imageUploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {

                profilePictureFilePathTextBox.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);

            PrintDialog printDialog = new PrintDialog
            {
                Document = printDoc
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font printFont = new Font("Arial", 14);
            Brush brush = Brushes.Black;

            // Text to be printed
            string printData = $"Username: {usernameLabel.Text}\n" +
                               $"First Name: {firstNameLabel1.Text}\n" +
                               $"Last Name: {lastNameLabel1.Text}\n" +
                               $"Email: {emailLabel.Text}\n" +
                               $"Date of Birth: {dateOfBirthLabel.Text}\n" +
                               $"Joining Date: {joinDateLabel.Text}\n" +
                               $"Monthly Budget: {monthlyBudgetLabel.Text}\n" +
                               $"Bank: {bankNameLabel.Text}\n" +
                               $"Balance: {bankBalanceLabel.Text}\n" +
                               $"Card Type: {cardTypeLabel.Text}\n" +
                               $"Card No: {cardNoLabel.Text}\n" +
                               $"Expiry: {expireDateLabel.Text}";

            // Draw the text
            e.Graphics.DrawString(printData, printFont, brush, 100, 100);

            // Get the image from the profilePictureBox
            if (profilePictureBox.Image != null)
            {
                // Define the location and size where the image will be printed
                int imageX = 500;
                int imageY = 100; // Adjust this to position the image below the text
                int imageWidth = 300;  // You can adjust the width
                int imageHeight = 300; // You can adjust the height

                // Print the image
                e.Graphics.DrawImage(profilePictureBox.Image, imageX, imageY, imageWidth, imageHeight);
            }
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard dashboard = new dashboard(username);
            dashboard.Show();
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

        private void categoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            categories categories = new categories(username);
            categories.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            insights insights = new insights(username);
            insights.Show();
        }
    }
}
