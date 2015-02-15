#region Usings

using Application;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class SentenceProcessorShould {
        [Test]
        public void ReturnEmptyStringIfInputSentenceIsEmptyString() {
            var sentenceProcessor = new SentenceProcessor();

            var output = sentenceProcessor.ReverseWords("");

            Assert.That(output, Is.EqualTo(string.Empty));
        }

        [Test]
        public void ReturnSingleWordIfInputIsThatWord() {
            var sentenceProcessor = new SentenceProcessor();

            var output = sentenceProcessor.ReverseWords("word");

            Assert.That(output, Is.EqualTo("word"));
        }

        [Test]
        public void ReverseTwoWordsInInputSentense() {
            var sentenceProcessor = new SentenceProcessor();

            var output = sentenceProcessor.ReverseWords("first second");

            Assert.That(output, Is.EqualTo("second first"));
        }

        [Test]
        public void ReversenyAmountOfWordsInInputSentense() {
            var sentenceProcessor = new SentenceProcessor();

            var output = sentenceProcessor.ReverseWords("1 2 3 4 5");

            Assert.That(output, Is.EqualTo("5 4 3 2 1"));
        }

        [Test]
        public void ReverseHelloCodeEvalSentense() {
            var sentenceProcessor = new SentenceProcessor();

            var output = sentenceProcessor.ReverseWords("Hello CodeEval");

            Assert.That(output, Is.EqualTo("CodeEval Hello"));
        }
    }
}