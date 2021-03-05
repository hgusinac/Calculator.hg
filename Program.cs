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

                    double sum = 0;


                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("---Menu---\nPress number key to run menu options\nA=Addition\nS=Subtraction\nM=Multiplication\nD=Division");
                    Console.ResetColor();

                    char AssigmentChoice = Console.ReadKey(true).KeyChar;

                    switch (AssigmentChoice)
                    {
                        case 'a':
                        case 'A':
                            Console.WriteLine(Addition(num1, num2));
                            break;
                        case 's':
                        case 'S':
                            Console.WriteLine(Subtraction(num1, num2));
                            break;
                        case 'm':
                        case 'M':
                            Console.WriteLine(Multiplication(num1, num2));
                            break;
                        case 'd':
                        case 'D':
                            if (num2 == 0)
                            { Console.WriteLine("U can't devide by 0"); }
                            else
                            {
                            Division(num1, num2);
                            }

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
            return num1 + num2;
        }
        public static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                return 0;
            }

            else
            {
                return num1 / num2;
            }

        }

    }
}

