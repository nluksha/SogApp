using FluentAssertions;
using Xunit;

namespace ParenthesesBalancing.UnitTests
{
    /// <summary>
    /// The unit tests for Parenthesis Balancing.
    /// Changing or removing of unit tests is not allowed, these are there to validate the implementation. You are of course free to add tests at will.
    /// </summary>
    public class ParenthesesBalancingTest
    {
        [Fact]
        public void givenEmptyText_whenIsBalanced_thenReturnTrue()
        {
            var result = new ParenthesesBalancing().IsBalanced("");
            result.Should().BeTrue();
        }

        [Fact]
        public void givenTextWithoutParentheses_whenIsBalanced_thenReturnTrue()
        {
            var result = new ParenthesesBalancing().IsBalanced("this does not contain any parentheses");
            result.Should().BeTrue();
        }

        [Fact]
        public void givenTextWithBalancedParentheses_whenIsBalanced_thenReturnTrue()
        {
            const string maryAndHerPuppy = "Mary (poor dear) lost her puppy (which she loved so much).";
            var result = new ParenthesesBalancing().IsBalanced(maryAndHerPuppy);
            result.Should().BeTrue();
        }

        [Fact]
        public void givenTextWithUnBalancedLeftParentheses_whenIsBalanced_thenReturnFalse()
        {
            const string unfinishedEquation = "(a + b - (c * d)";
            var result = new ParenthesesBalancing().IsBalanced(unfinishedEquation);
            result.Should().BeFalse();
        }

        [Fact]
        public void givenTextWithUnbalancedTheeTwoParentheses_whenIsBalanced_thenReturnFalse()
        {
            const string unfinishedEquation = "(a + b - (c * d";
            var result = new ParenthesesBalancing().IsBalanced(unfinishedEquation);
            result.Should().BeFalse();
        }

        [Fact]
        public void givenTextWithUnBalancedRightParentheses_whenIsBalanced_thenReturnFalse()
        {
            const string unfinishedEquation = "a + b - (c * d))";
            var result = new ParenthesesBalancing().IsBalanced(unfinishedEquation);
            result.Should().BeFalse();
        }

        [Fact]
        public void givenComplicatedTextWithBalancedParentheses_whenIsBalanced_thenReturnTrue()
        {
            const string weirdText = "d('')b + ((a :-) - b :-( =)) ";
            var result = new ParenthesesBalancing().IsBalanced(weirdText);
            result.Should().BeTrue();
        }

        [Fact]
        public void givenComplicatedTextWithUnnBalancedParentheses_whenIsBalanced_thenReturnFalse()
        {
            const string weirdText = "d)(('')b + ((a :-) - b :-( =)) ";
            var result = new ParenthesesBalancing().IsBalanced(weirdText);
            result.Should().BeFalse();
        }
    }
}