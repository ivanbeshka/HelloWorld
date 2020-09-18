using System;

namespace HelloWorld
{
    class Program
    {
        static void Main2()
        {
            Console.WriteLine(Decode("123"));
        }

        static string Decode(string stroke)
        {
            var parsedNumber = int.Parse(stroke.Replace(".", ""));
            return parsedNumber > 1024 ? (parsedNumber - 1024).ToString() : parsedNumber.ToString();
        }

        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}