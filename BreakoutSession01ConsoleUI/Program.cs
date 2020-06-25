using System;

namespace BreakoutSession01ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //string hello = "Hello, ";

            //string name = "Cruz";

            //string greeting = hello + name;

            //Console.WriteLine(hello);
            //Console.WriteLine(name);
            //Console.WriteLine(greeting);

            //Console.WriteLine("Please enter your age!");
            //string userAnswer = Console.ReadLine();

            //Parse takes a string verison of a number and convert it to a number variable
            //int age = int.Parse(userAnswer);

            //Console.WriteLine($"Hi my name is {name}, I am {age} years old.");

            //CheckAge(age);

            //Console.WriteLine();

            //Console.WriteLine();

            //CheckAge(age);


            Console.WriteLine("Please enter a number to count to...");

            int userNumber = int.Parse(Console.ReadLine());

            UserCounter(userNumber);

        }

        static void CheckAge(int age)
        {
            string message = age >= 18 ? "You may vote in America!" : "You are too young to vote!";
            Console.WriteLine(message);
        }

        public static void UserCounter(int upperBound)
        {
            int sum = 0;

            for(int i = 1; i <= upperBound; i++)
            {
                Console.WriteLine($"The current sum is: {sum}");
                sum = sum + i;

                //Console.ReadLine();
            }

            Console.WriteLine($"The final total is: {sum}");
        }
    }
}
