#region Usings

using Application;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class MixedContentSeparatorShould {
        [Test]
        public void ReturnEmptyStringIfInputIsEmpty() {
            var mixedContentSeparator = new MixedContentSeparator();

            var output = mixedContentSeparator.Separate("");

            Assert.That(output, Is.EqualTo(string.Empty));
        }

        [Test]
        public void ReturnSingleNumberIfInputIsThatNumber() {
            var mixedContentSeparator = new MixedContentSeparator();

            var output = mixedContentSeparator.Separate("1");

            Assert.That(output, Is.EqualTo("1"));
        }

        [Test]
        public void ReturnAnyAmountOfOnlyNumbersInInput() {
            var mixedContentSeparator = new MixedContentSeparator();

            var output = mixedContentSeparator.Separate("24,13,14,43,41");

            Assert.That(output, Is.EqualTo("24,13,14,43,41"));
        }

        [Test]
        public void ReturnSingleWordIfInputIsThatWord() {
            var mixedContentSeparator = new MixedContentSeparator();

            var output = mixedContentSeparator.Separate("apple");

            Assert.That(output, Is.EqualTo("apple"));
        }

        [Test]
        public void ReturnAnyAmountOfOnlyWordsInInput() {
            var mixedContentSeparator = new MixedContentSeparator();

            var output = mixedContentSeparator.Separate("apple,char,pie");

            Assert.That(output, Is.EqualTo("apple,char,pie"));
        }

        [Test]
        public void ReturnSeparatedSingleWordAndNumber() {
            var mixedContentSeparator = new MixedContentSeparator();

            var output = mixedContentSeparator.Separate("1,apple");

            Assert.That(output, Is.EqualTo("apple|1"));
        }

        [Test]
        public void ReturnAnyAmountOfSeparatedWordsAndNumbers() {
            var mixedContentSeparator = new MixedContentSeparator();

            var output = mixedContentSeparator.Separate("8,33,21,0,16,50,37,0,melon,7,apricot,peach,pineapple,17,21");

            Assert.That(output, Is.EqualTo("melon,apricot,peach,pineapple|8,33,21,0,16,50,37,0,7,17,21"));
        }
    }
}