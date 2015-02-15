#region Usings

using Application;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class DecimalToBinaryConverterShould {
        [Test]
        public void Return_0_IfInputIs_0() {
            var binaryValue = DecimalToBinaryConverter.Convert(0);

            Assert.That(binaryValue, Is.EqualTo("0"));
        }
        
        [Test]
        public void Return_1_IfInputIs_1() {
            var binaryValue = DecimalToBinaryConverter.Convert(1);

            Assert.That(binaryValue, Is.EqualTo("1"));
        }

        [Test]
        public void Return_10_IfInputIs_2() {
            var binaryValue = DecimalToBinaryConverter.Convert(2);

            Assert.That(binaryValue, Is.EqualTo("10"));
        }

        [Test]
        public void Return_1010_IfInputIs_10() {
            var binaryValue = DecimalToBinaryConverter.Convert(10);

            Assert.That(binaryValue, Is.EqualTo("1010"));
        }

        [Test]
        public void Return_1000011_IfInputIs_67() {
            var binaryValue = DecimalToBinaryConverter.Convert(67);

            Assert.That(binaryValue, Is.EqualTo("1000011"));
        }
    }
}