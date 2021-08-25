using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706A1
{
    abstract class Account
    {
        private double balance;
        string accountName;
        private double depositAmount;
        private double withdrawalAmount;
        //With the accountID, I have included this for future use when a login is added to identify accounts with customers
        //int accountID;
        private double interestRate;
        bool transFail;

    //insert get and set methods for balance

        //The constructor for showin transaction calculation on account children forms
        public void showTransaction()
        {

        }

        //The constructor for calculating interest added
        public void calculateInterest()
        {

        }
    }
}
