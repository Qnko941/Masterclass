using System;

namespace Problem_3._Check_for_a_Play_Card
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = Console.ReadLine();

            if (a.Equals("2") || a.Equals("3") || a.Equals("4") || a.Equals("5") || a.Equals("6") || a.Equals("7") || a.Equals("8") || a.Equals("9") || a.Equals("10") || a.Equals("J") || a.Equals("Q") || a.Equals("K") || a.Equals("A"))
            {
                Console.WriteLine("yes");
            } else
            {
                Console.WriteLine("no");
            }
        }
    }
}
