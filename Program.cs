using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello");

            do
            {

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Enter your first Number:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter ur secund Number:");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("---Menu---\nPress number key to run menu options\nA=Addition\nS=Subtraction\nM=Multiplication\nD=Division");
                Console.ResetColor();

                char AssigmentChoice = Console.ReadKey(true).KeyChar;


                switch (AssigmentChoice)
                {
                    case 'a':
                    case 'A':

                        Addition(num1, num2);
                        break;
                    case 's':
                    case 'S':
                        Subtraction(num1, num2);
                        break;
                    case 'm':
                    case 'M':
                        Multiplication(num1, num2);
                        break;
                    case 'd':
                    case 'D':
                        Division(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid Keypress");

                        break;

                }
                Console.WriteLine("Try some more numbers (M to Menu)");
                Console.ResetColor();

            } while (Console.ReadKey(true).KeyChar == 'm');

        }
        static void Addition(double num1, double num2)
        {
            Console.WriteLine(num1 + num2);
        }
        static void Subtraction(double num1, double num2)
        {
            Console.WriteLine(num1 - num2);
        }
        static void Multiplication(double num1, double num2)
        {
            Console.WriteLine(num1 * num2);
        }
        static void Division(double num1, double num2)
        {

            if (num2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("U cant devide by 0");
                Console.ResetColor();
            }

            else
            {
                Console.WriteLine(num1 / num2);
            }


        }

    }
}

