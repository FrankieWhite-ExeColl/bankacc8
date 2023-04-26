using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankacct
{
    public partial class Form1 : Form
    {
        String userChoice;
        String amount;
        Account testAccount;
        


        public Form1()
        {
            InitializeComponent();
            testAccount = new Account();
            testAccount.Deposit("100.00");
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            amount = testAccount.GetBalance();
            lblBalance.Text = amount;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            amountForm form = new amountForm();
            form.ShowDialog();

            this.amount = form.ReturnValue1;
            amount = testAccount.Deposit(amount);
            lblBalance.Text = amount;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            amountForm form = new amountForm();
            form.ShowDialog();

            this.amount = form.ReturnValue1;
            amount = testAccount.Withdraw(amount);
            lblBalance.Text = amount;
        }
    }
}
