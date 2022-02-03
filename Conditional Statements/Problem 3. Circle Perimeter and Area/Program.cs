using System;

namespace Problem_3._Circle_Perimeter_and_Area
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a program that reads the radius r of a circle and prints its perimeter and area 
            //formatted with 2 digits after the decimal point.

            double r = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * (Math.Pow(r, 2));

            Console.WriteLine(String.Format("Circle Perimeter : {0:0.##}{1}Circle Radius {2:0.##}", perimeter, Environment.NewLine, area));


        }
    }
}
