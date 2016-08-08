using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication21
{
    public class BaseAccount

    //Fields
    {
        private string name;
        private string accountNumber;
        private int balance;
        private int deposit;
        private int withdrawel;
        private string accountType;

        //Properties

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        public int Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public int Deposit
        {
            get { return this.deposit; }
            set { this.deposit = value; }
        }

        public int Withdrawel
        {
            get { return this.withdrawel; }
            set { this.withdrawel = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        //Constructor

        public BaseAccount(string name, string accountNumber, string accountType)
        {
            this.name = name;
            this.accountNumber = accountNumber;
            this.accountType = accountType;
            

        }

        public void PrintStats()

        {

            Console.WriteLine(this.accountType+" Balance= "+ this.Balance);

        }


        //Unable to get this to work

        //public void printDetails()
        //{
        //    StreamWriter accountBaseInfo = new StreamWriter();
        //    accountBaseInfo.Append("Name: " + name);
        //    accountBaseInfo.Append("\nAccount Number: " + accountNumber);
        //    accountBaseInfo.Append("\nAccount Type: " + accountType);
        //    accountBaseInfo.Append("\nDeposit +: " + deposit);
        //    accountBaseInfo.Append("\nWithdrawel -: " + withdrawel);
        //    accountBaseInfo.Append("\nBalance: " + balance);

        //    Console.WriteLine(accountBaseInfo.ToString());
        //}



    }
}
