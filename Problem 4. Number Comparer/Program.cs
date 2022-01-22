using System;

namespace Problem_4._Number_Comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that gets two numbers from the console and prints the greater of them.
            //Try to implement this without if statements.

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Greater Number is: " + Math.Max(a, b));

        }
    }
}
