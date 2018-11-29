using System;
using System.Text;

namespace Hw11.Lib
{
    public class Homework11 : IHomework11
    {
        private string[] OneDigitText = new[] {
            "ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า"
        };

        private SignificantDigitText[] SignificantDigits = new[] {
            new SignificantDigitText { Value = 1_000_000_000, Text = "พัน" },
            new SignificantDigitText { Value = 100_000_000, Text = "ร้อย" },
            new SignificantDigitText { Value = 10_000_000, Text = "สิบ" },
            new SignificantDigitText { Value = 1_000_000, Text = "ล้าน", AlwaysShow = true },
            new SignificantDigitText { Value = 100_000, Text = "แสน" },
            new SignificantDigitText { Value = 10_000, Text = "หมื่น" },
            new SignificantDigitText { Value = 1_000, Text = "พัน" },
            new SignificantDigitText { Value = 100, Text = "ร้อย" },
            new SignificantDigitText { Value = 10, Text = "สิบ" },
        };

        public Homework11()
        {
            SetupDigitTexts();
        }

        public string GetReadWordOfNumber(int number)
        {
            var sb = new StringBuilder();
            var digitWritten = false;
            var remaining = number;
            foreach (var significantDigit in SignificantDigits)
            {
                var digit = remaining / significantDigit.Value;
                if (digit > 0)
                {
                    var digitTexts = GetDigitTexts(significantDigit.Value, digitWritten);
                    sb.Append(digitTexts[digit]);
                    sb.Append(significantDigit.Text);
                    digitWritten = true;
                }
                else if (significantDigit.AlwaysShow && digitWritten)
                {
                    sb.Append(significantDigit.Text);
                }
                remaining %= significantDigit.Value;
            }
            if (remaining > 0 || !digitWritten)
            {
                var digitTexts = GetDigitTexts(0, digitWritten);
                sb.Append(digitTexts[remaining]);
            }

            return sb.ToString();
        }

        private string[] NonZeroDigitText;
        private string[] TenDigitText;
        private string[] LastDigitText;
        public void SetupDigitTexts()
        {
            var arrayLen = OneDigitText.Length;
            NonZeroDigitText = new string[arrayLen];
            Array.Copy(OneDigitText, NonZeroDigitText, arrayLen);
            NonZeroDigitText[0] = "";

            TenDigitText = new string[arrayLen];
            Array.Copy(NonZeroDigitText, TenDigitText, arrayLen);
            TenDigitText[2] = "ยี่";
            TenDigitText[1] = "";

            LastDigitText = new string[arrayLen];
            Array.Copy(NonZeroDigitText, LastDigitText, arrayLen);
            LastDigitText[1] = "เอ็ด";
        }

        public string[] GetDigitTexts(int value, bool hasDigitWritten)
        {
            switch (value)
            {
                case 1_000_000_000:
                case 100_000_000:
                case 1_000_000:
                case 100_000:
                case 10_000:
                case 1_000:
                case 100:
                    return NonZeroDigitText;
                case 10_000_000:
                case 10:
                    return TenDigitText;
                default:
                    return hasDigitWritten ? LastDigitText : OneDigitText;
            }
        }
    }
}
