using System;
using System.Collections.Generic;
using System.Text;

namespace SampleBank
{
    class BankAccount
    {
        private readonly int _account_number;
        private string account_holdername;
        private int account_balance = 0;

        public BankAccount(int _account_number, string account_holdername)
        {
            this._account_number = _account_number;
            Account_holdername = account_holdername;
        }
        
        public int Account_number => _account_number;

        public string Account_holdername { get => account_holdername; set => account_holdername = value; }
        public int Account_balance { get => account_balance; set => account_balance = value; }

        public int amountDeposit(int amount)
        {
            Account_balance = Account_balance + amount;
            return Account_balance;
        }

        public int amountWithdraw(int amount)
        {
            if(amount>Account_balance)
            {
                Console.WriteLine("Entered Amount is inValid");
                return -1;
            }
            else if(amount <= Account_balance)
            {
                Account_balance -= amount;
                return Account_balance;
            }
            return -1;
        }
    }
}
