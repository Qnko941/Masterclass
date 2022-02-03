using System;

namespace Problem_7._Sort_3_Numbers_with_Nested_Ifs
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); //1
            int b = int.Parse(Console.ReadLine()); //4
            int c = int.Parse(Console.ReadLine()); //7

            int biggest = 0;
            int middle = 0;
            int smallest = 0;


            if (a > b && a > c)
            {
                biggest = a;
                smallest = b;
                middle = c;
                if (b > c)
                {
                    middle = b;
                    smallest = c;
                }
            }
            if (b > a && b > c)
            {
                biggest = b;
                smallest = a;
                middle = c;
                if (a > c)
                {
                    middle = a;
                    smallest = c;
                }

            }
            if (c > b && c > a)
            {
                biggest = c;
                smallest = b;
                middle = a;
                if (b > a)
                {
                    middle = b;
                    smallest = a;
                }
            }


            Console.WriteLine(biggest);
            Console.WriteLine(middle);
            Console.WriteLine(smallest);

        }

    }
}
