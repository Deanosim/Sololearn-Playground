using System;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Welcome to Dean's Calculator, Press enter to Continue or Exit to Quit.");
                string str = Console.ReadLine();
                int x;
                if (str == "exit")
                    break;
                else
                Console.Write("x =");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("y =");
                int y = Convert.ToInt32(Console.ReadLine());

                int sum = y + x;
                Console.WriteLine("Result: {0}", sum);
            }
            while (true);
        }
    }
}
