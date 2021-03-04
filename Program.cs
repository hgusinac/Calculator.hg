using System;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello");

            do
            {
                try
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
                double sum = num1 + num2;

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
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not a number. ");
                    Console.ResetColor();
                }
                Console.WriteLine("Try some more numbers (M to Menu)");
                Console.ResetColor();

            } while (Console.ReadKey(true).KeyChar == 'm');

        }



        public static double Addition(double[] numbers)
        {
            double sum = 0;
            foreach (double number in numbers)
            {
                sum = number + sum;
            }

            return sum;
        }
        public static double Subtraction(double[] numbers)
        {
            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;

            }

            return sum;
        }
        public static double Addition(double num1, double num2)
        {
            double sum = num1 + num2;
            Console.WriteLine(num1 + num2);

            return sum;
        }
        public static double Subtraction(double num1, double num2)
        {
            double sum = num1 - num2;
            Console.WriteLine(num1 - num2);
            return sum;
        }
        public static double Multiplication(double num1, double num2)
        {
            double sum = num1 * num2;
            Console.WriteLine(num1 * num2);
            return sum;
        }
        public static double Division(double num1, double num2)
        {
            double sum = num1 / num2;

            if (num2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("u cant devide by 0");
                Console.ResetColor();

                return 0;

            }

            else
            {
                Console.WriteLine(num1 / num2);
            }
            return sum;

        }

    }
}

