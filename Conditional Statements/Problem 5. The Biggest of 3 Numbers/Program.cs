using System;

namespace Problem_5._The_Biggest_of_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a + " is the biggest number.");
                }
            }
            else if (b > c) 
            {
                Console.WriteLine(b + " is the biggest number");
            }
            else
            {
                Console.WriteLine(c + " is the biggest number");
            }

        }
    }
}
