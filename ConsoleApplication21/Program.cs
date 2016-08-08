using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)


        {
            //Create new objects

            Checking checking = new Checking("Ben's Checking Account", "001");
            Savings savings = new Savings("Ben's Savings Account", "002" );
            Reserve reserve = new Reserve("Ben's Reserve Account", "003");



            //User Greeting
            {
                Console.WriteLine("Welcome to KeyBank.");
                
            }



            //Execute methods from derived classes

            string cont;
            
                do


                {
                Console.WriteLine("Ben Demko\n3083 Edgehill Rd.\nCleveland Heights, Ohio 44118");
                checking.PrintStats();
                savings.PrintStats();
                reserve.PrintStats();


                    Console.WriteLine("Would you like to access your checking, savings, or reserve account?");
                    string choice = Console.ReadLine().ToUpper();

                    if (choice == "CHECKING")
                    {

                        checking.Transaction();

                    }

                    else if (choice == "SAVINGS")

                    {
                    savings.Transaction();


                    }

                    else if (choice == "RESERVE")

                    {
                    reserve.Transaction();


                    }

                    else
                    {
                         Console.WriteLine(" Please choose an account to access: Checking, Savings, or Reserve.");
                    }

                

                    Console.WriteLine("Do you want to continue?");
                    cont = Console.ReadLine().ToUpper();
                    Console.Clear();

                


                }

                 while (cont == "YES");

        }

    }
}

