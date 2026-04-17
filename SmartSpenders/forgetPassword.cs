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
    public partial class forgetPassword : Form
    {
        private DataAccess dataAccess;
        bool userExist = false;
        public forgetPassword()
        {
            InitializeComponent();
            dataAccess = new DataAccess("Database1.mdf");
        }

        private void forgetPassword_Load(object sender, EventArgs e)
        {

        }
        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Username")
            {
                usernameTextBox.Text = "";
                usernameTextBox.ForeColor = Color.Black;
                usernameTextBox.Font = new Font(usernameTextBox.Font.FontFamily, 16f, FontStyle.Regular);
            }
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                usernameTextBox.Text = "Username";
                usernameTextBox.ForeColor = Color.Gray;
                usernameTextBox.Font = new Font(usernameTextBox.Font.FontFamily, 16f, FontStyle.Regular);
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "New Password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.PasswordChar = '*';
                passwordTextBox.ForeColor = Color.Black;
                passwordTextBox.Font = new Font(passwordTextBox.Font.FontFamily, 16f, FontStyle.Regular);
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.PasswordChar = '\0';
                passwordTextBox.Text = "New Password";
                passwordTextBox.ForeColor = Color.Gray;
                passwordTextBox.Font = new Font(passwordTextBox.Font.FontFamily, 16f, FontStyle.Regular);
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != "" && passwordTextBox.Text != "")
            {
                try
                {
                    string query = "UPDATE generalUserInfo SET Password = @password WHERE UserName = @username";
                    var cmd = dataAccess.GetCommand(query);

                    string username = usernameTextBox.Text;
                    usernameCheck(username);  // Ensure userExist is being set correctly
                    if (userExist)
                    {
                        string password = passwordTextBox.Text;
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        // Check if the password update actually happened
                        int rowsAffected = dataAccess.ExecuteNonQueryCommand(cmd);
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Your password has been changed successfully.");
                            loginPage login = new loginPage();
                            this.Hide();
                            loginPage loginPage = new loginPage();
                            loginPage.Show();
                        }
                        else
                        {
                            MessageBox.Show("Password change failed. Please try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No user found with this username.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the required fields.");
            }
        }

        private void usernameCheck(string username)
        {

            string query = "SELECT * FROM generalUserInfo WHERE UserName = @username";
            var cmd = dataAccess.GetCommand(query);

            cmd.Parameters.AddWithValue("@username", username);

            DataTable table = dataAccess.ExecuteCommand(cmd);

            if(table.Rows.Count > 0)
            {
                userExist = true;
            }
            else
            {
                userExist = false;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginPage loginPage = new loginPage();
            loginPage.Show();
        }
    }
}
