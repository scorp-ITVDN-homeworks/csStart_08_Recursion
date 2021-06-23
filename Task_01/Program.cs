using System;
using System.Threading;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal debt = 0.0m;
            bool payWasDone = true;
            bool exitWasDone = true;
            decimal sumOfLoan = 0.0m;
            decimal sumOfPay = 0.0m;
            short currentChoice = 1;
            int sessionCounter = 0;

            do
            {
                if (exitWasDone)
                {
                    Console.Clear();
                    Console.WriteLine("The Bank H/-\\E-BANK greetings you!!!");
                    if (sessionCounter == 0)
                        Console.WriteLine("Thank you for contacting us! What is your purpose?");
                    if (sessionCounter > 0)
                        Console.WriteLine("We glad to see you again!!! What is your purpose?");
                    exitWasDone = false;
                }
                else
                {
                    Console.WriteLine("Do another operation?");
                }
                    

                ShowPurposeList(ref currentChoice);

                if (currentChoice == 1)
                {
                    GetLoan(sumOfLoan, ref debt);
                }

                if (currentChoice == 2)
                {
                    PayLoan(sumOfPay, ref debt, ref payWasDone);
                }

                if (currentChoice == 3)
                {
                    Console.WriteLine(new string('-', 50));
                    ShowBalance(debt);
                    Console.WriteLine(new string('-', 50));
                }

                if (currentChoice == 4)
                {
                    if (!payWasDone)
                    {
                        Console.WriteLine("Sorry, you can't leave without pay in this months");
                        Console.WriteLine(new string('-', 50));
                    }
                    else
                    {
                        exitWasDone = true;
                        sessionCounter++;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        ShowHardWorkOfServer(50);
                        ShowHardWorkOfServer(25);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ResetColor();

                        if (debt > 0) payWasDone = false;
                    }
                }

                if (currentChoice == 5)
                {
                    if (debt <= 0) break;

                    Console.WriteLine("Sorry, you can't do that before you have debt");
                    Console.WriteLine(new string('-', 50));
                }

                if (currentChoice == 6)
                {
                    Console.WriteLine(new string('-', 50));
                    ShowHardWorkOfServer(); ShowHardWorkOfServer();
                    Console.WriteLine("Sorry, all managers are busy now. Try to contact us later");
                    Console.WriteLine(new string('-', 50));
                }
            }
            while (true);

        }

        public static void GetLoan(decimal sumOfLoan, ref decimal debt)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Please, input required value of loan:");
            sumOfLoan = Convert.ToDecimal(Console.ReadLine());
            debt += sumOfLoan;
            ShowHardWorkOfServer();
            Console.WriteLine();
            Console.WriteLine("Congrateulations!!! You got loan!!! Conditinos will be sent to your mail");
            ShowBalance(debt);
            Console.WriteLine(new string('-', 50));
        }

        public static void PayLoan(decimal sumOfPay, ref decimal debt, ref bool payWasDone)
        {
            if (debt <= 0)
            {
                Console.WriteLine("Your balance is 0, you do not have debts");
                return;
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("note: we don't give out change");
            Console.ResetColor();
            Console.WriteLine("Please, input sum of pay:");
            sumOfPay = Convert.ToDecimal(Console.ReadLine());            
            debt -= sumOfPay;
            payWasDone = true;
            if (debt > 0 && sumOfPay == 0) payWasDone = false;
            if (debt < 0) debt = 0.0m;
            ShowHardWorkOfServer();
            Console.WriteLine();
            Console.WriteLine("Operation complete!!! Payment done!!!");
            ShowBalance(debt);
            if(debt == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("We stay in sorrow, because now you free from debts!!!");
                Console.ResetColor();
            }

            Console.WriteLine(new string('-', 50));            
        }

        public static void ShowBalance(decimal debt)
        {
            Console.WriteLine($"Your balance now = {-debt}");
        }

        public static void ShowPurposeList(ref short currentChoice)
        {
            Console.WriteLine("1 - Get a Loan");
            Console.WriteLine("2 - Pay a Loan");
            Console.WriteLine("3 - Show balance");
            Console.WriteLine("4 - Come back later");
            Console.WriteLine("5 - Close account and never come back");
            Console.WriteLine("6 - Connect to Manager");

            Console.WriteLine(new string('-', 50));
            Console.Write("Your case: ");
            currentChoice = Convert.ToSByte(Console.ReadLine());
        }

        public static void ShowHardWorkOfServer()
        {
            for(int i = 0; i < 20; i++)
            {
                Console.Write(".");
                Thread.Sleep(150);
            }            
        }

        public static void ShowHardWorkOfServer(int time)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write(".");
                Thread.Sleep(time);
            }
        }
    }
}
