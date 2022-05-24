using FluentAssertions;
using Xunit;

namespace Reverse.UnitTests
{
    /// <summary>
    /// The unit tests from Character Reverse.
    /// Changing or removing of unit tests is not allowed, these are there to validate the implementation. You are of course free to add tests at will.
    /// </summary>
    public class CharReverseTest
    {
        private readonly CharReverse charReverse;

        public CharReverseTest()
        {
            charReverse = new CharReverse();
        }

        [Fact]
        public void emptyString()
        {
            var result = charReverse.Reverse("");
            result.Should().Be("");
        }

        [Fact]
        public void singleWord()
        {
            var result = charReverse.Reverse("cba");
            result.Should().Be("abc");
        }

        [Fact]
        public void singleSentence()
        {
            string sentence = "Most people consider piranhas to be dangerous.";
            string expected = "tsoM elpoep redisnoc sahnarip ot eb suoregnad.";

            var result = charReverse.Reverse(sentence);
            result.Should().Be(expected);
        }

        [Fact]
        public void compoundSentence()
        {
            string sentence = "Most people consider piranhas to be dangerous,  they are harmless..";
            string expected = "tsoM elpoep redisnoc sahnarip ot eb suoregnad,  yeht era sselmrah..";

            var result = charReverse.Reverse(sentence);
            result.Should().Be(expected);
        }

        [Fact]
        public void paragraph()
        {
            string sentence = "Although most people consider piranhas to be quite dangerous, they are, for the most part, entirely harmless. Piranhas rarely feed on large animals.they eat smaller fish and aquatic plants.";
            string expected = "hguohtlA tsom elpoep redisnoc sahnarip ot eb etiuq suoregnad, yeht era, rof eht tsom trap, yleritne sselmrah. sahnariP ylerar deef no egral slamina.yeht tae rellams hsif dna citauqa stnalp.";

            var result = charReverse.Reverse(sentence);
            result.Should().Be(expected);
        }
    }
}