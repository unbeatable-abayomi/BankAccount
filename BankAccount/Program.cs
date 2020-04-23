using System;
using System.Collections.Generic;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CurrentAccount current1 = new CurrentAccount("yomi",23345,"gtb",1000M);
            Console.WriteLine($"{current1.Balance:C}");
            current1.Credit(200m);
            Console.WriteLine($"{current1.Balance:C}");
         //   Console.WriteLine(current1);
            
            
            SavingsAccount savings1 = new SavingsAccount("james stayrt",0292020,"Uba", 500m, 0.02m);
            Console.WriteLine($"{savings1.Balance:C}");
            decimal intrest1 = savings1.CalculateInterest();
            savings1.Credit(intrest1);
            Console.WriteLine($"{savings1.Balance:C}");
           // Console.WriteLine(savings1);
            
            SavingsAccount savings2 = new SavingsAccount("Kenny Show", 5677, "Union Bank", 500m, 0.03m);
            Console.WriteLine($"{savings2.Balance:C}");
            decimal intrest2 = savings2.CalculateInterest();
            savings2.Credit(intrest2);
            Console.WriteLine($"{savings2.Balance:C}");

            List<Account> accounts = new List<Account> { current1, savings1, savings2 };

            Console.WriteLine("==============Looping through Accounts polymorphically============= ");


            foreach(var account in accounts)
            {
                if (account is SavingsAccount)
                {
                    var savings = (SavingsAccount)account;
                    decimal intrestRate = savings.CalculateInterest();
                    savings.Credit(intrestRate);
                    Console.WriteLine($"Intrest Added To Savings Account: {intrestRate:C}");
                }

                Console.WriteLine($"Account Balance {account.Balance:C}");
            }

        }
    }
}
