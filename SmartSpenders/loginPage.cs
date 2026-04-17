using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSpenders
{
    public partial class loginPage : Form
    {
        string username = "";
        string pass = "";
        string databaseFileName = "Database1.mdf";
        private DataAccess dataAccess;
        public loginPage()
        {
            InitializeComponent();
            dataAccess = new DataAccess(databaseFileName);
        }


        
        
        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "username")
            {
                richTextBox1.Text = "";
                richTextBox1.ForeColor = Color.Black;
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 16f, FontStyle.Regular);
            }
        }
        
        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "username";
                richTextBox1.ForeColor = Color.Gray;
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 16f, FontStyle.Regular);
            }
        }
        
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "password")
            {
                textBox1.Text = "";
                textBox1.PasswordChar = '*';
                textBox1.ForeColor = Color.Black;
                textBox1.Font = new Font(textBox1.Font.FontFamily, 16f, FontStyle.Regular);
            }
        }
        
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.PasswordChar = '\0';
                textBox1.Text = "password";
                textBox1.ForeColor = Color.Gray;
                textBox1.Font = new Font(textBox1.Font.FontFamily, 16f, FontStyle.Regular);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "username";
            richTextBox1.ForeColor = Color.Gray;
            textBox1.Text = "password";
            textBox1.ForeColor = Color.Gray;
         
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            username = richTextBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationPage1 form2 = new registrationPage1();
            form2.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pass = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM generalUserInfo WHERE UserName = @UserName AND Password = @Password";
            var cmd = dataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@Password", pass);

            DataTable user = dataAccess.ExecuteCommand(cmd);
            if (user.Rows.Count > 0)
            {
                string userType = user.Rows[0]["UserType"].ToString();
                if (userType == "Admin")
                {
                    adminHomePage form3 = new adminHomePage(user);
                    form3.Show();
                    this.Hide();
                }
                else
                {
                    dashboard dashboard = new dashboard(username);
                    dashboard.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }

        private void forgetPassButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            forgetPassword forgetPassword = new forgetPassword();
            forgetPassword.Show();
        }
    }
}
