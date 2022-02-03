using System;

namespace Problem_10._Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstNum = 0;
            int secondNum = 1;

            while(n > 0)
            {
                //there's probably a better way to do this but...
                if (n == 1)
                {
                    Console.Write(firstNum + ", " + secondNum);
                }
                else
                {
                    Console.Write(firstNum + ", " + secondNum + ", ");
                }

                firstNum = firstNum + secondNum;
                secondNum = firstNum + secondNum;

                n--;
            }
        }
    }
}
