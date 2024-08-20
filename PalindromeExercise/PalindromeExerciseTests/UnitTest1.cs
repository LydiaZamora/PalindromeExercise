using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("chowder", false)]
        public void PalindromeTest(string word, bool expected)
        {
            var palindrome = new WordSmith();

            var actual = palindrome.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
