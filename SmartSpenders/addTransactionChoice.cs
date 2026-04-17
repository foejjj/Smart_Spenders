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
    public partial class addTransactionChoice : Form
    {
        string username;
        public addTransactionChoice(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void normalTransactionButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            using (addTransaction addTransaction = new addTransaction(username))
            {
                // Show the form as a modal dialog
                addTransaction.ShowDialog();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void creditTransactionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (addCreditTransaction addCreditTransaction = new addCreditTransaction(username))
            {
                // Show the form as a modal dialog
                addCreditTransaction.ShowDialog();
            }
        }

        private void debitTransactionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using(addDebitTransaction addDebitTransaction = new addDebitTransaction(username))
            {
                // Show the form as a modal dialog
                addDebitTransaction.ShowDialog();
            }
        }

        private void addTransactionChoice_Load(object sender, EventArgs e)
        {

        }
    }
}
