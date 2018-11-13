using System;
using Xunit;

namespace Hw01.Lib.Tests
{
    public class ITextSortingTests
    {
        [Theory]
        [InlineData("without,hello,bag,world", "bag,hello,without,world")]
        public void SortByAlphabeticalReturnValidResults(string input, string expected)
        {
            var sut = new MyTextSorting();
            var result = sut.SortByAlphabetical(input);

            Assert.Equal(expected, result);
        }
    }
}
