using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class CurrentAccount: Account
    {
        

        public CurrentAccount(string name,int acctNum,string bnkName, decimal intialBalance):base(name,acctNum,bnkName,intialBalance)
        {
           

        }

      
       

        public override void Credit(decimal deposit)
        {
            Balance = Balance + deposit;
        }

        public override string Debit(decimal withdrawal)
        {
            if(withdrawal > Balance)
            {
                return "Insufficient balance";
            }
            Balance = Balance - withdrawal;
            return "Amount Debited Successfully";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
