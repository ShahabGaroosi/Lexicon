using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Character = new Person();
            Person Contender = new Person();
            int i;
            do
            {
                i = Meny();
                switch (i)
                {
                    case 1:
                        Function1();
                        break;
                    case 2:
                        Function2();
                        break;
                    case 3:
                        Function3();
                        break;
                    case 4:
                        Function4();
                        break;
                    case 5:
                        Function5();
                        break;
                    case 6:
                        Function6();
                        break;
                    case 7:
                        Function7();
                        break;
                    case 8:
                        Function8();
                        break;
                    case 9:
                        Function9();
                        break;
                    case 10:
                        Function10();
                        break;
                    case 11:
                        Function11();
                        break;
                    case 12:
                        Function12();
                        break;
                    case 13:
                        Function13();
                        break;
                    case 14:
                        Function14();
                        break;
                    case 15:
                        Function15();
                        break;
                    case 16:
                        Character.Function16("character ");
                        Contender.Function16("contender ");
                        Console.WriteLine("Character Name: " + Character.name + ", Health:" + Character.health + ", Strength: " + Character.strength + ", Luck: " + Character.luck);
                        Console.WriteLine("Contender Name: " + Contender.name + ", Health:" + Contender.health + ", Strength: " + Contender.strength + ", Luck: " + Contender.luck);
                        break;
                }
            }
            while (i != 0);
        }
        //Take inputted meny option.
        static int Meny()
        {
            Console.WriteLine("Meny - choose option (1-16):");
            int i = Convert.ToInt32(Console.ReadLine());
            return i;
        }
        //Output Hello World
        static void Function1()
        {
            Console.WriteLine("Hello World");
        }
        //Output inputted first and last name and age
        static void Function2()
        {
            Console.WriteLine("Write first name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Write last name:");
            string LastName = Console.ReadLine();
            Console.WriteLine("Write age:");
            string Age = Console.ReadLine();
            Console.WriteLine(FirstName + ' ' + LastName + ' ' + Age);
        }
        //Change text color, to blue if gray and back to gray if blue.
        static void Function3()
        {
            Console.ForegroundColor = (Console.ForegroundColor == ConsoleColor.Gray) ? ConsoleColor.Blue : ConsoleColor.Gray;
        }
        //Output today's date.
        static void Function4()
        {
            Console.WriteLine("Today's date: " + DateTime.Today.ToString("dd/MM/yyyy"));
        }
        //Output the max value of two inputed numbers.
        static void Function5()
        {
            Console.WriteLine("Write number:");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write number:");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max value: " + Math.Max(i, j));
        }
        //Game of guessing a random created number, between 1 and 100.
        static void Function6()
        {
            Random rnd = new Random();
            int i = rnd.Next(1, 100);
            int j;
            int k = 0;
            do
            {
                Console.WriteLine("Guess number (between 1 and 100):");
                j = Convert.ToInt32(Console.ReadLine());
                if (j < i)
                {
                    Console.WriteLine("Number too small.");
                }
                else if (j > i)
                {
                    Console.WriteLine("Number too high.");
                }
                k += 1;
            }
            while (i != j);
            Console.WriteLine("Right guess after " + k + " attempts.");
        }
        //Save input text to file C:/Users/shaha/source/repos/AF_test/AF_test/Function7.txt.
        static void Function7()
        {
            Console.WriteLine("Write text to save to file (C:/Users/shaha/source/repos/AF_test/AF_test/Function7.txt):");
            File.WriteAllText("C:/Users/shaha/source/repos/AF_test/AF_test/Function7.txt", Console.ReadLine());
        }
        //Output text in file C:/Users/shaha/source/repos/AF_test/AF_test/Function7.txt.
        static void Function8()
        {
            Console.WriteLine("Text in file (C:/Users/shaha/source/repos/AF_test/AF_test/Function7.txt):");
            Console.WriteLine(File.ReadAllText("C:/Users/shaha/source/repos/AF_test/AF_test/Function7.txt"));
        }
        //Output the square, power to 2 and power to 10 of inputted number.
        static void Function9()
        {
            Console.WriteLine("Write number:");
            double i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sqrt: " + Math.Sqrt(i) + "; Power to 2: " + Math.Pow(i, 2) + "; Power to 10: " + Math.Pow(i, 10));
        }
        //Output multiplication table (10x10).
        static void Function10()
        {
            string m;
            for (int i = 1; i <= 10; i++)
            {
                m = "";
                for (int j = 1; j <= 10; j++)
                {
                    m += Convert.ToString(i * j) + "    ";
                }
                Console.WriteLine(m);
            }
        }
        //Create and sort an array with elements of random values 
        static void Function11()
        {
            Random rnd = new Random();
            int[] A = { rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100) };
            int[] B = new int[A.Length];
            A.CopyTo(B, 0);
            Array.Sort(B);
            Console.WriteLine("[{0}]", string.Join(", ", A));
            Console.WriteLine("[{0}]", string.Join(", ", B));
        }
        //Check whether input string is a palindrom.
        static void Function12()
        {
            Console.WriteLine("Write a string:");
            string A = Console.ReadLine().ToLower();
            char[] B = A.ToCharArray();
            Array.Reverse(B);
            string C = new string(B);
            if (A == C)
            {
                Console.WriteLine("String is a palindrom.");
            }
            else
            {
                Console.WriteLine("String is not a palindrom.");
            }
        }
        //Output all integers between two inputted integers.
        static void Function13()
        {
            Console.WriteLine("Write number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers between:");
            for (int i = Math.Min(a, b) + 1; i < Math.Max(a, b); i++)
            {
                Console.WriteLine(i);
            }
        }
        //Sort and output on odd respectively even numbers of inputted comma-seperated numbers.
        static void Function14()
        {
            Console.WriteLine("Write comma-seperated numbers:");
            int[] a = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
            Array.Sort(a);
            Console.WriteLine("Odd sorted numbers:");
            foreach (int i in a)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Even sorted numbers:");
            foreach (int i in a)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        //Output sum of inputted comma-seperated numbers.
        static void Function15()
        {
            Console.WriteLine("Write comma-seperated numbers:");
            int[] a = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
            Console.WriteLine("Sum: " + a.Sum());
        }
        class Person
        {
            public string name;
            public int health;
            public int strength;
            public int luck;
            //Read name and assign random values (1-10) on health, strength and luck.
            public void Function16(string person)
            {
                Console.WriteLine("Write " + person + "name:");
                name = Console.ReadLine();
                Random rnd = new Random();
                health = rnd.Next(1, 10);
                strength = rnd.Next(1, 10);
                luck = rnd.Next(1, 10);
            }
        }
    }
}
