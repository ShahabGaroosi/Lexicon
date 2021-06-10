using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int userSelection;

            do
            {
                userSelection = Menu();

                switch(userSelection)
                {
                    case 1:
                        Addition();
                        break;
                    case 2:
                        Subtraction();
                        break;
                    case 3:
                        Multiplication();
                        break;
                    case 4:
                        Division();
                        break;
                }
            }while (userSelection != 0) ;
        }

        static int Menu()
        {
            Console.WriteLine("----Menu----");
            Console.WriteLine("1: Addition.");
            Console.WriteLine("2: Subraction.");
            Console.WriteLine("3: Multiplication.");
            Console.WriteLine("4: Division.");
            Console.WriteLine("0: Exit.");

            int userSelection = 0;
            int.TryParse(Console.ReadLine(), out userSelection);

            return userSelection;
        }
        static double GetValue()
        {
            double i = 0;
            Double.TryParse(Console.ReadLine(), out i);
            return i;
        }
        static void Addition()
        {
            double a = GetValue(), b = GetValue();
            Console.WriteLine(a + b);
        }
        static void Subtraction()
        {
            double a = GetValue(), b = GetValue();
            Console.WriteLine(a - b);
        }
        static void Multiplication()
        {
            double a = GetValue(), b = GetValue();
            Console.WriteLine(a * b);
        }
        static void Division()
        {
            double a = GetValue(), b = GetValue();
            if (b != 0)
            {
                Console.WriteLine(a / b);
            }
            else
            {
                Console.WriteLine("Error: Could not divide by zero!");
            }
        }
    }
}
