using System;

namespace Problem_9._Play_with_Int__Double_and_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = Console.ReadLine();
            int value;

            if (int.TryParse(c, out value)) {
                value++;
                Console.WriteLine(value);
            }
            else
            {
                c += "*";
                Console.WriteLine(c);
            }

        }
    }
}
