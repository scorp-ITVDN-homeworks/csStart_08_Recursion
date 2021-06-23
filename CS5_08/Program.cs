using System;

namespace CS5_08
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Set 3 numbers");
                Console.WriteLine("Set first number:");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Set second number:");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Set third number:");
                int thirdNumber = Convert.ToInt32(Console.ReadLine());

                DivideArgsByFive(ref firstNumber, ref secondNumber, ref thirdNumber);

                Console.WriteLine(new string('-', 60));

                Console.WriteLine($"firstNumber become {firstNumber} \n" +
                    $"secondNumber become {secondNumber}\n" +
                    $"thirdNumber become {thirdNumber}");

                Console.WriteLine(new string('-', 60));

                Console.WriteLine("Continue? (y/n)");

                if (Console.ReadLine() != "y") break;
            }
            while (true);
        }

        public static void DivideArgsByFive(ref int first, ref int second, ref int third)
        {
            first /= 5;
            second /= 5;
            third /= 5;
        }
    }
}
