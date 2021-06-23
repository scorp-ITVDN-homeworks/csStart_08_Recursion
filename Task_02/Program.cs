using System;
using System.Threading;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Type number to get N-factorial from it:");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Processing...");
                ShowHardWorkOfServer(100);
                Console.WriteLine();

                Console.WriteLine($"N-factorial from {number} = {GetRecoursinoFactorial(number)}");

                Console.WriteLine("Do another operation? (y/n)");
                if (Console.ReadLine() != "y") break;

            } while (true);

            Console.ReadKey();
        }

        public static int GetRecoursinoFactorial(int number)
        {
            if (number == 1) return 1;
            int result = number;
            result = GetRecoursinoFactorial(number - 1) * result;
            return result;
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
