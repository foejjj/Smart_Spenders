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
    public partial class registrationPage1 : Form
    {
        private DataAccess dataAccess;
        string databaseFileName = "Database1.mdf";
        bool usernameExist = false;
        public registrationPage1()
        {
            InitializeComponent();
            dataAccess = new DataAccess(databaseFileName);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "First name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                textBox1.Font = new Font(textBox1.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "First name";
                textBox1.ForeColor = Color.Gray;
                textBox1.Font = new Font(textBox1.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Last name")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.Font = new Font(textBox2.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Last name";
                textBox2.ForeColor = Color.Gray;
                textBox2.Font = new Font(textBox2.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Username")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
                textBox3.Font = new Font(textBox3.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Username";
                textBox3.ForeColor = Color.Gray;
                textBox3.Font = new Font(textBox3.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Password")
            {
                textBox4.Text = "";
                textBox4.PasswordChar = '*';
                textBox4.ForeColor = Color.Black;
                textBox4.Font = new Font(textBox4.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.PasswordChar = '\0';
                textBox4.Text = "Password";
                textBox4.ForeColor = Color.Gray;
                textBox4.Font = new Font(textBox4.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Email")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
                textBox5.Font = new Font(textBox5.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Username";
                textBox5.ForeColor = Color.Gray;
                textBox5.Font = new Font(textBox5.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }
        private void userNameExistCheck(string username)
        {
            string query = "SELECT * FROM [dbo].[generalUserInfo] where Username= @username";
            var cmd = dataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@username", username);
            DataTable user = dataAccess.ExecuteCommand(cmd);
            if (user.Rows.Count > 0)
            {
                usernameExist = true;
            }
            else
            {
                usernameExist = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && comboBox1.Text != "")
                {
                    userNameExistCheck(textBox3.Text);
                    if (!usernameExist)
                    {
                        string query = "INSERT INTO [generalUserInfo] ([UserName], [FirstName], [LastName], [Password], [EmailAddress], [DOB], [UserType], [ProfilePicture]) " +
                                   "VALUES (@UserName, @FirstName, @LastName, @Password, @EmailAddress, @DOB, @UserType, @ProfilePicture)";
                        string firstName = textBox1.Text;
                        string lastName = textBox2.Text;
                        string userName = textBox3.Text;
                        string password = textBox4.Text;
                        string email = textBox5.Text;
                        string userType = comboBox1.Text;
                        string dateOfBirth = textBox6.Text;

                        var cmd = dataAccess.GetCommand(query);

                        cmd.Parameters.AddWithValue("@UserName", userName);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@EmailAddress", email);
                        cmd.Parameters.AddWithValue("@UserType", userType);
                        cmd.Parameters.AddWithValue("@DOB", dateOfBirth);

                        if (profilePictureBox.Image != null)
                        {
                            byte[] imageBytes = ImageToByteArray(profilePictureBox.Image);
                            cmd.Parameters.AddWithValue("@ProfilePicture", imageBytes);
                        }
                        else
                        {
                            // If no image is uploaded, you can store null or handle accordingly
                            cmd.Parameters.AddWithValue("@ProfilePicture", DBNull.Value);
                        }


                        dataAccess.ExecuteNonQueryCommand(cmd);

                        if (userType != "Admin")
                        {
                            registrationPage2 form1 = new registrationPage2(userName);
                            this.Hide();
                            form1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Registration Completed!");
                            this.Hide();
                            loginPage login = new loginPage();
                            login.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username already exists, please add new one");
                    }


                }
                else
                {
                    MessageBox.Show("Please fill the required fields");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\nPlease add valid values");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "YYYY-MM-DD")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
                textBox6.Font = new Font(textBox6.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }
        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "YYYY-MM-DD";
                textBox6.ForeColor = Color.Gray;
                textBox6.Font = new Font(textBox6.Font.FontFamily, 12f, FontStyle.Regular);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void imageUploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if(open.ShowDialog() == DialogResult.OK)
            {

                profilePictureFilePathTextBox.Text = open.FileName;
                profilePictureBox.Image = new Bitmap(open.FileName);
            }
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

        private void profilePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void registrationPage1_Load(object sender, EventArgs e)
        {

        }
    }
}
