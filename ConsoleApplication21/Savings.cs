using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Savings:BaseAccount
    {


        // Constructors

        public Savings(string name, string accountNumber):base(name, accountNumber, "Savings")

        {

            this.Balance = 2000;

        }


        //Methods 


        public void Transaction()

        {
            Console.WriteLine("Would you like to make a deposit or withdrawal from your savings account?");
            string transactionAnswer = Console.ReadLine().ToUpper();

            if (transactionAnswer == "DEPOSIT")
            {
                Console.WriteLine("How much would you like to deposit into savings?");
                string depositChoiceAsString = Console.ReadLine();
                this.Deposit = Convert.ToInt32(depositChoiceAsString);
                this.Balance = this.Balance + this.Deposit;


            }
            if (transactionAnswer == "WITHDRAWEL")

            {
                Console.WriteLine("How much would you like to withdraw from savings?");
                string withdrawelChoiceAsString = Console.ReadLine();
                this.Withdrawel = Convert.ToInt32(withdrawelChoiceAsString);
                this.Balance = this.Balance - this.Withdrawel;

            }


        }



    }

}