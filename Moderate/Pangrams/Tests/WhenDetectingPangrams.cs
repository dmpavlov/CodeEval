#region Usings

using Domain;
using NUnit.Framework;

#endregion

namespace Tests
{
    [TestFixture]
    public class WhenDetectingPangrams
    {
        [Test]
        public void Return_NULL_IfInputSentenceContainsAllAlphabetLetters()
        {
            var analyzer = CreateAnalyzer();

            var result = analyzer.FindMissingLetters("A quick brown fox jumps over the lazy dog");

            Assert.That(result, Is.EqualTo("NULL"));
        }

        [Test]
        public void ReturnAllAlphabetIfInputSentenseIsEmpty()
        {
            var analyzer = CreateAnalyzer();

            var result = analyzer.FindMissingLetters("");

            Assert.That(result, Is.EqualTo("abcdefghijklmnopqrstuvwxyz"));
        }

        [Test]
        public void ReturnMissingLettersIfInputSentenseIsSingleLetter_A()
        {
            var analyzer = CreateAnalyzer();

            var result = analyzer.FindMissingLetters("a");

            Assert.That(result, Is.EqualTo("bcdefghijklmnopqrstuvwxyz"));
        }

        [Test]
        public void ReturnMissingLettersIfInputSentenseIsSingleLetter_Z()
        {
            var analyzer = CreateAnalyzer();

            var result = analyzer.FindMissingLetters("z");

            Assert.That(result, Is.EqualTo("abcdefghijklmnopqrstuvwxy"));
        }

        [Test]
        public void ReturnMissingLettersIfInputSentenseContainsCapitalLetters()
        {
            var analyzer = CreateAnalyzer();

            var result = analyzer.FindMissingLetters("ABC");

            Assert.That(result, Is.EqualTo("defghijklmnopqrstuvwxyz"));
        }

        [Test]
        public void ReturnMissingLettersIfInputSentenseContainsWhiteSpaces()
        {
            var analyzer = CreateAnalyzer();

            var result = analyzer.FindMissingLetters("ABC DEF h i j z");

            Assert.That(result, Is.EqualTo("gklmnopqrstuvwxy"));
        }

        [Test]
        public void ReturnMissingLettersFromCodeEvalExample()
        {
            var analyzer = CreateAnalyzer();

            var result = analyzer.FindMissingLetters("A slow yellow fox crawls under the proactive dog");

            Assert.That(result, Is.EqualTo("bjkmqz"));
        }

        [Test]
        public void ReturnAllAlphabetIfInputContainsNumbersOnly()
        {
            var analyzer = CreateAnalyzer();

            var result = analyzer.FindMissingLetters("123");

            Assert.That(result, Is.EqualTo("abcdefghijklmnopqrstuvwxyz"));
        }

        private static PangramsAnalyzer CreateAnalyzer()
        {
            return new PangramsAnalyzer();
        }
    }
}