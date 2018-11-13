using System;
using Hw01.Lib;

namespace Hw01Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter list of words using comma-seperated");
            var words = Console.ReadLine();
            var myTextSorting = new MyTextSorting();
            var result = myTextSorting.SortByAlphabetical(words);
            Console.WriteLine(result);
        }
    }
}
