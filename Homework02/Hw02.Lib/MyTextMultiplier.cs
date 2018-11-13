using System;
using System.Linq;
using System.Text;

namespace Hw02.Lib
{
    public class MyTextMultiplier : ITextMultiplier
    {
        public string GetFormattedString(string text)
        {
            var splitted = text.Split(',');
            var numbers = splitted.Select(it => int.Parse(it) * 11);
            var sb = new StringBuilder();
            bool firstNumber = true;

            sb.AppendLine("[");
            foreach (var n in numbers)
            {
                if (firstNumber)
                {
                    firstNumber = false;
                } else
                {
                    sb.AppendLine(",");
                }
                sb.Append($"    {n}");
            }
            sb.AppendLine();
            sb.Append("]");

            return sb.ToString();
        }
    }
}
