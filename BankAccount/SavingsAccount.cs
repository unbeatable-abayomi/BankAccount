using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class SavingsAccount : CurrentAccount
    {
        private decimal interestRate;

        public SavingsAccount(string name, int acctNum, string bnkName, decimal intialBalance, decimal intRate) : base(name, acctNum, bnkName, intialBalance)
        {
            InterestRate = intRate;

        }

        public decimal InterestRate
        {
            get { return interestRate; }
            set
            {
                if (value > 0 && value <= 5)
                {
                    interestRate = value;
                }
            }
        }
        public decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }

        public override void Credit(decimal deposit)
        {
            Balance = Balance + deposit;
        }

        public override string Debit(decimal withdrawal)
        {
            if (withdrawal > Balance)
            {
                return "Insufficient balance";
            }
            Balance = Balance - withdrawal;
            return "Amount Debited Successfully";
        }

       
        public override string ToString()
        {
            return $"{base.ToString()}\n Intrest Paid On Savings Account: {CalculateInterest():C}";
        }
    }
}
