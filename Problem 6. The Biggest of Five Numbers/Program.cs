using System;

namespace Problem_6._The_Biggest_of_Five_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); //1
            int b = int.Parse(Console.ReadLine()); // 50
            int c = int.Parse(Console.ReadLine()); // 20
            int d = int.Parse(Console.ReadLine()); // 40
            int e = int.Parse(Console.ReadLine()); //2


            int biggest = 0;

            biggest = a;
            if (b > biggest)
            {
                biggest = b;
            }
            if (c > biggest)
            {
                biggest = c;
            }
            if (d > biggest)
            {
                biggest = d;
            }
            if (e > biggest)
            {
                biggest = e;
            }



            Console.WriteLine(biggest);

        }
    }
}
