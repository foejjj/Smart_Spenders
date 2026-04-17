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
    public partial class adminHomePage : Form
    {
        string name, username, userType;
        private DataAccess dataAccess;
        private DataTable user;
        string databaseFileName = "Database1.mdf";
        public adminHomePage(DataTable user)
        {
            InitializeComponent();
            this.user = user;
            
            name = user.Rows[0]["FirstName"].ToString() + " " + user.Rows[0]["LastName"].ToString();
            username = user.Rows[0]["username"].ToString();
            userType = user.Rows[0]["userType"].ToString();
            label6.Text = name;
            label5.Text = username;
            label4.Text = userType;
            dataAccess = new DataAccess(databaseFileName);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            dataGridView1.Enabled = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                

                string query = "SELECT * FROM generalUserInfo";
                var cmd = dataAccess.GetCommand(query);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginPage form1 = new loginPage();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Id"].Value != null) { 

                    int id = Convert.ToInt32(row.Cells["Id"].Value);
                    string firstName = row.Cells["FirstName"].Value?.ToString();
                    string lastName = row.Cells["LastName"].Value?.ToString();
                    string userName = row.Cells["UserName"].Value?.ToString();
                    string password = row.Cells["Password"].Value?.ToString();
                    string emailAddress = row.Cells["EmailAddress"].Value?.ToString();
                    string UserType = row.Cells["UserType"].Value?.ToString();
                    DateTime dob = Convert.ToDateTime(row.Cells["DOB"].Value);

                    string query = "UPDATE generalUserInfo SET FirstName = @FirstName, LastName = @LastName, Password = @password, UserName = @UserName, EmailAddress = @EmailAddress, DOB = @DOB, UserType = @UserType WHERE Id = @Id";

                    var cmd = dataAccess.GetCommand(query);

                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@EmailAddress", emailAddress);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@UserType", UserType);
                    cmd.Parameters.AddWithValue("@Id", id);

                    dataAccess.ExecuteNonQueryCommand(cmd);
                }
            }
            MessageBox.Show("All of the values were successfully updated");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
