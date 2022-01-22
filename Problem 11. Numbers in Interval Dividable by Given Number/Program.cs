using System;

namespace Problem_11._Numbers_in_Interval_Dividable_by_Given_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int numbersDivisbleBy5 = 0;

            for (int i = Math.Min(n, m); i < Math.Max(n, m); i++)
            {
                if (i % 5 == 0)
                {
                    numbersDivisbleBy5++;
                }
            }
            Console.WriteLine(numbersDivisbleBy5);
        }
    }
}
