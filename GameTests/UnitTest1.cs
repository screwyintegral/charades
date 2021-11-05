using System;
using Xunit;
using NicoleBCharades.Models;


namespace GameTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Game my_game = new Game();
            my_game.NumberOfPlayers = 4;
            Assert.Equal(4, my_game.NumberOfPlayers);
        }
        [Theory]
        [InlineData("4", 4)]
        [InlineData("3", 3)]
        [InlineData("0", 0)]
        [InlineData("-100", -100)]
        // Set number of players
        public void Test2(string input, int expected_output)
        {
            int result = int.Parse(input);
            Assert.Equal(result, expected_output);
        }
        [Theory]
        [InlineData("4", 4)]
        [InlineData("3", 3)]
        [InlineData("0", 0)]
        [InlineData("-100", -100)]
        // Set number of rounds
        public void Test3(string input, int expected_output)
        {
            int result = int.Parse(input);
            Assert.Equal(result, expected_output);
        }
    }
}
