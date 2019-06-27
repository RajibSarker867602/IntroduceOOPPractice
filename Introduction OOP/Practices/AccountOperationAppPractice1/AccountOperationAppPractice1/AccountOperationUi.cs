using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        public AccountOperationUi()
        {
            InitializeComponent();
        }
        Account account = new Account();
        private void CreateButton_Click(object sender, EventArgs e)
        {
            account.accNo = accountNoTextBox.Text;
            account.customerName = customerNameTextBox.Text;
            MessageBox.Show("Account create successful.");
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            account.Deposite(Convert.ToDecimal(amountTextBox.Text));
            MessageBox.Show("Deposite successful.");
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            account.Withdraw(Convert.ToDecimal(amountTextBox.Text));
            MessageBox.Show("Withdraw successful.");
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(account.GetReport());
        }
    }
}
