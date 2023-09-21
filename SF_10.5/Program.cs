using System;

namespace SF_10._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger;
            int a, b;
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Enter the first number");
                a = ConvertStringToInt(Console.ReadLine());

                Console.WriteLine("Enter the second number");
                b = ConvertStringToInt(Console.ReadLine());
                logger = new Logger(new LogEvent());
                logger.Log("Calculated Sum is " + new Calculator().Sum(a, b).ToString());
                Console.ReadKey();
            }
        }
        public static int ConvertStringToInt(string enteredString)
        {
            Logger logger;
            int? n = null;
            string s = enteredString;
            while (n == null)
            {
                try
                {
                    n = int.Parse(s);
                }
                catch (Exception ex)
                {
                    if (ex is FormatException)
                    {
                        logger = new Logger(new LogError());
                        logger.Log("Entered incorrect symbols");
                    }
                    if (ex is OverflowException)
                    {
                        logger = new Logger(new LogError());
                        logger.Log("Entered value is too big or too small");
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Enter the number");
                    s = Console.ReadLine();
                }
            }
            return (int)n;
        }
    }
}
