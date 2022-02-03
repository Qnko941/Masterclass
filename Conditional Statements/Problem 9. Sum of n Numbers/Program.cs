using System;

namespace Problem_9._Sum_of_n_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                sum += m;
            }

            Console.WriteLine("Sum is: " + sum);
        }
    }
}
