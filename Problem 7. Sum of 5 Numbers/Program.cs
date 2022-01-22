using System;

namespace Problem_7._Sum_of_5_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int[] ints = Array.ConvertAll(input, s => int.Parse(s));

            int sum = 0;

            foreach (var item in ints)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}
