using System;

namespace Problem_5._Formatting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            Console.WriteLine(String.Format("|{0}          |000{1}000|          {2:0.##}|{3:0.###}          |", a.ToString("X"), Convert.ToString(a, 2), b, c));

        }
    }
}
