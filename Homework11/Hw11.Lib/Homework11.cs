using System;

namespace Hw11.Lib
{
    public class Homework11 : IHomework11
    {
        private string[] OneDigitText = new [] {
            "ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า"
        };

        public string GetReadWordOfNumber(int number)
        {
            return OneDigitText[number];
        }
    }
}
