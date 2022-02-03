using System;
using System.Globalization;

namespace Problem_10._Beer_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string strDate = Console.ReadLine();
            DateTimeFormatInfo dtinfo = new DateTimeFormatInfo();
            dtinfo.ShortDatePattern = "MM/dd/yyyy HH:MM TT";
            DateTime resultDate = Convert.ToDateTime(strDate, dtinfo);

            Console.WriteLine(resultDate);
        }
    }
}
