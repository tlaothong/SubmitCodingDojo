using System;
using Xunit;

namespace Hw11.Lib.Tests
{
    public class Homework11Tests
    {
        [Theory]
        [InlineData(0, "ศูนย์")]
        [InlineData(1, "หนึ่ง")]
        [InlineData(10, "สิบ")]
        [InlineData(20, "ยี่สิบ")]
        [InlineData(121, "หนึ่งร้อยยี่สิบเอ็ด")]
        [InlineData(5034, "ห้าพันสามสิบสี่")]
        [InlineData(876530, "แปดแสนเจ็ดหมื่นหกพันห้าร้อยสามสิบ")]
        [InlineData(1234567, "หนึ่งล้านสองแสนสามหมื่นสี่พันห้าร้อยหกสิบเจ็ด")]
        [InlineData(120_000_050, "หนึ่งร้อยยี่สิบล้านห้าสิบ")]
        [InlineData(1200_000_000, "หนึ่งพันสองร้อยล้าน")]
        public void GetReadWordOfNumberTests(int number, string expected)
        {
            var sut = new Homework11();
            var result = sut.GetReadWordOfNumber(number);
            Assert.Equal(expected, result);
        }
    }
}
