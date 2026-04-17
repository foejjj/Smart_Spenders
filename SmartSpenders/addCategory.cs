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
    public partial class addCategory : Form
    {
        DataAccess dataAccess;
        string username;
        public addCategory(string username)
        {
            InitializeComponent();
            dataAccess = new DataAccess("Database1.mdf");
            this.username = username;
        }

        private void amountTextBox_Enter(object sender, EventArgs e)
        {
            if(categoryNameTextBox.Text == "Category Name")
            {
                categoryNameTextBox.Text = "";
                categoryNameTextBox.ForeColor = Color.Black;
                categoryNameTextBox.Font = new Font(categoryNameTextBox.Font.FontFamily, 14f, FontStyle.Regular);
            }
        }

        private void categoryNameTextBox_Leave(object sender, EventArgs e)
        {
            if (categoryNameTextBox.Text == "")
            {
                categoryNameTextBox.Text = "Category Name";
                categoryNameTextBox.ForeColor = Color.Gray;
                categoryNameTextBox.Font = new Font(categoryNameTextBox.Font.FontFamily, 14f, FontStyle.Regular);
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(categoryNameTextBox.Text != "")
                {
                    string query = "INSERT into categories ([Username], [Category], [Spending]) values(@username, @category, @spending)";

                    var cmd = dataAccess.GetCommand(query);

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@category", categoryNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@spending", "0");

                    dataAccess.ExecuteNonQueryCommand(cmd);

                    MessageBox.Show("Category updated");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter valid values");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
