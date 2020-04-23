using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public abstract class Account
    {
        protected string AccountName;
        protected int AccountNo;
        protected string BankName;
        private decimal balance;



        public Account (string acctName,int acctNum,string bankName,decimal intialBal)
        {
            AccountName = acctName;
            AccountNo = acctNum;
            BankName = bankName;
            Balance = intialBal;
        }
          
        public decimal Balance
        {
            get { return balance; }
            set
            {
                if(value > 0M)
                {
                    balance = value;
                }
            }
        }

        public abstract string Debit(decimal withdraw);
        public abstract void Credit(decimal deposit);
        public override string ToString()
        {
            return $"========Account Details=========\n Account Name: {AccountName}\n Account No: {AccountNo}\n" +
                $" Bank Name: {BankName}\n Account Balance: {Balance:C}";
        }

    }
}
