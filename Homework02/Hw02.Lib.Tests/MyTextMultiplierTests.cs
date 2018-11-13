using System;
using Xunit;

namespace Hw02.Lib.Tests
{
    public class MyTextMultiplierTests
    {
        [Theory]
        [InlineData("34,67,55,33,12,28",
@"[
    374,
    737,
    605,
    363,
    132,
    308
]")]
        [InlineData("",
@"[]")] 
        [InlineData("33",
@"[
    363
]")] 
        public void GetFormattedStringReturnsValidResult(string input, string expected)
        {
            var sut = new MyTextMultiplier();
            var result = sut.GetFormattedString(input);

            Assert.Equal(expected, result);
        }
    }
}
