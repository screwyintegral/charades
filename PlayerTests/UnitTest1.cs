using System;
using Xunit;
using NicoleBCharades.Models;

namespace PlayerTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Player nicole = new Player();
            nicole.Name = "Nicole";
            Assert.Equal("Nicole", nicole.Name);
        }
        [Theory]
        [InlineData("4", 4)]
        [InlineData("3", 3)]
        [InlineData("0", 0)]
        [InlineData("-100", -100)]
        // Set number of points
        public void Test2(string input, int expected_output)
        {
            int result = int.Parse(input);
            Assert.Equal(result, expected_output);
        }
        [Theory]
        [InlineData("Sally", "Sally")]
        [InlineData("Susan", "Susan")]
        [InlineData("Dominic", "Dominic")]
        [InlineData("Jenkins", "Jenkins")]
        // Set player name
        public void Test3(string input, string expected_output)
        {
            string result = input;
            Assert.Equal(result, expected_output);
        }
    }
}
