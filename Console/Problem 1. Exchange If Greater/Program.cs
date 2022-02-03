using System;

namespace Problem_1._Exchange_If_Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                double c;
                c = a;
                a = b;
                b = c;
            }

            Console.WriteLine(a +  " " + b);
        }
    }
}
