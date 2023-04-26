using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankacct
{
    class Account
    {
        String balance;
        String overdraftLimit;
        String holder;

        public String GetBalance()
        {
            return balance;
        }

        public String Withdraw(String amount)
        {
            decimal balance2 =  Convert.ToDecimal(balance) - Convert.ToDecimal(amount);
            balance = Convert.ToString(balance2);
            return balance;
        }

        public string Deposit(String amount)
        {
            decimal balance2 = Convert.ToDecimal(amount) + Convert.ToDecimal(balance);
            balance = Convert.ToString(balance2);
            return balance;
        }

    }

}
