#region Usings

using Application;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class MorseCodesConverterShould {
        [Test]
        public void Return_1_IfInputIsOne() {
            var parser = new MorseCodesConverter();

            var output = parser.Convert(".----");

            Assert.AreEqual("1", output);
        }

        [Test]
        public void Return_2_IfInputIsTwo() {
            var parser = new MorseCodesConverter();

            var output = parser.Convert("..---");

            Assert.AreEqual("2", output);
        }

        [Test]
        public void Return_3_IfInputIsThree() {
            var parser = new MorseCodesConverter();

            var output = parser.Convert("...--");

            Assert.AreEqual("3", output);
        }

        [Test]
        public void Return_A_IfInputIsA() {
            var parser = new MorseCodesConverter();

            var output = parser.Convert(".-");

            Assert.AreEqual("A", output);
        }

        [Test]
        public void ReturnSpaceIfInputIsEmpty() {
            var converter = new MorseCodesConverter();

            var output = converter.Convert("");

            Assert.AreEqual(" ", output);
        }
    }
}