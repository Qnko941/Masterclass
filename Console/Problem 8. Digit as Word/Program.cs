using System;

namespace Problem_8._Digit_as_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string digit = Console.ReadLine();

            switch (digit)
            {

                case "0":
                    Console.WriteLine("Zero");
                    
                case "1":
                    Console.WriteLine("One");
                    
                case "2":
                    Console.WriteLine("Two");
                    
                case "3":
                    Console.WriteLine("Three");
                    
                case "4":
                    Console.WriteLine("Four");
                    
                case "5":
                    Console.WriteLine("Five");
                    
                case "6":
                    Console.WriteLine("Six");
                    
                case "7":
                    Console.WriteLine("Seven");
                    
                case "8":
                    Console.WriteLine("Eight");
                    
                case "9":
                    Console.WriteLine("Nine");
                    

                default:
                    Console.WriteLine("not a digit");
                    
            }
        }
    }
}
