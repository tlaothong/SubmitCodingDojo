using System;

namespace Hw01.Lib
{
    public class MyTextSorting : ITextSorting
    {
        public string SortByAlphabetical(string text)
        {
            var splitted = text.Split(',');
            Array.Sort(splitted);
            return string.Join(",", splitted);
        }
    }
}
