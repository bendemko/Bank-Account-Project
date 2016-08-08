using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Reserve:BaseAccount
    {


        // Constructors

        public Reserve(string name, string accountNumber):base(name, accountNumber, "Reserve")

        {

            this.Balance = 2000;

        }


        //Methods 


        public void Transaction()

        {
            Console.WriteLine("Would you like to make a deposit or withdrawal from your reserve account?");
            string transactionAnswer = Console.ReadLine().ToUpper();

            if (transactionAnswer == "DEPOSIT")
            {
                Console.WriteLine("How much would you like to deposit into reserve?");
                string depositChoiceAsString = Console.ReadLine();
                this.Deposit = Convert.ToInt32(depositChoiceAsString);
                this.Balance = this.Balance + this.Deposit;


            }
            if (transactionAnswer == "WITHDRAWEL")

            {
                Console.WriteLine("How much would you like to withdraw from reserve?");
                string withdrawelChoiceAsString = Console.ReadLine();
                this.Withdrawel = Convert.ToInt32(withdrawelChoiceAsString);
                this.Balance = this.Balance - this.Withdrawel;

            }


        }



    }

}