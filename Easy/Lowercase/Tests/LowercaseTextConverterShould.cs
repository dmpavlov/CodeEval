#region Usings

using Lowercase;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class LowercaseTextConverterShould {
        [Test]
        public void ReturnEmptyStringOnEmptyInput() {
            var lowercaseText = LowercaseTextConverter.Convert("");

            Assert.That(lowercaseText, Is.EqualTo(""));
        }

        [Test]
        public void Return_a_IfSentenseIs_A() {
            var lowercaseText = LowercaseTextConverter.Convert("A");

            Assert.That(lowercaseText, Is.EqualTo("a"));
        }

        [Test]
        public void Return_hello_IfSentenseIs_HELLO() {
            var lowercaseText = LowercaseTextConverter.Convert("HELLO");

            Assert.That(lowercaseText, Is.EqualTo("hello"));
        }


        [Test]
        public void Return_hello_IfSentenseIs_HeLlO() {
            var lowercaseText = LowercaseTextConverter.Convert("HeLlO");

            Assert.That(lowercaseText, Is.EqualTo("hello"));
        }
    }
}