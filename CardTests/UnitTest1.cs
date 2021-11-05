using System;
using Xunit;
using NicoleBCharades.Models;

namespace CardTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Card panda = new Card();
            panda.Description = "Panda";
            Assert.Equal("Panda", panda.Description);
        }
        [Theory]
        [InlineData("4", 4)]
        [InlineData("3", 3)]
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        // Get card by id
        public void Test2(string input, int expected_output)
        {
            int result = int.Parse(input);
            Assert.Equal(result, expected_output);
        }
        [Theory]
        [InlineData("Panda", "Panda")]
        [InlineData("Jack Skeleton", "Jack Skeleton")]
        [InlineData("Minecraft Steve", "Minecraft Steve")]
        [InlineData("Buzz Lightyear", "Buzz Lightyear")]
        // Set card description
        public void Test3(string input, string expected_output)
        {
            string result = input;
            Assert.Equal(result, expected_output);
        }
    }
}
