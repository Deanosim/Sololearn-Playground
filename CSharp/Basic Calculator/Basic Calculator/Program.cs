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
                string result = "Result = {0}";

                char op;
                int x;
                int y;

                if (str == "exit")
                    break;
                else

                Console.Write("Select Opterator (+, -, *, /) =");
                op = Char.Parse(Console.ReadLine());

                Console.Write("x =");
                x = Int32.Parse(Console.ReadLine());

                Console.Write("y =");
                y = Int32.Parse(Console.ReadLine());

                switch(op)
                {
                    case '+':
                        Console.WriteLine(result, x + y);
                        break;
                    case '*':
                        Console.WriteLine(result, x * y);
                        break;
                    case '-':
                        Console.WriteLine(result, x - y);
                        break;
                    case '/':
                        Console.WriteLine(result, x / y);
                        break;
                }
            }
            while (true);
        }
    }
}
