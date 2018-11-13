using System;
using Hw02.Lib;

namespace Hw02Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter comma-separated numbers :");
            var numbers = Console.ReadLine();
            var myTextMultiplier = new MyTextMultiplier();
            var result = myTextMultiplier.GetFormattedString(numbers);

            Console.WriteLine(result);
        }
    }
}
