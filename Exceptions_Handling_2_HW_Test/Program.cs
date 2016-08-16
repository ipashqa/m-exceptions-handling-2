using System;

using Exceptions_Handling_2_HW;

namespace Exceptions_Handling_2_HW_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IntParser.Parse("-2147483649");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Exception: value < int.MinValue");
            }

            try
            {
                IntParser.Parse("2147483648");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Exception: value > int.MaxValue");
            }

            try
            {
                IntParser.Parse("sadasd");
            }
            catch (FormatException)
            {
                Console.WriteLine("Exception: Incorrect format");
            }

            Console.WriteLine(IntParser.Parse("256"));
            Console.WriteLine(IntParser.Parse("-54132"));
            Console.WriteLine(IntParser.Parse(int.MaxValue.ToString()));
            Console.WriteLine(IntParser.Parse(int.MinValue.ToString()));
        }
    }
}
