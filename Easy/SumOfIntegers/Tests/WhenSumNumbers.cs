#region Usings

using NUnit.Framework;
using SumOfIntegers;

#endregion

namespace Tests {
    [TestFixture]
    public class WhenSumNumbers {
        [Test]
        public void ReturnZeroIfInputIsEmpty() {
            var summator = new Summator();

            var sum = summator.Calculate(new[] {""});

            Assert.That(sum, Is.EqualTo(0));
        }


        [Test]
        public void ReturnNumberIfInputIsThatNumber() {
            var summator = new Summator();

            var sum = summator.Calculate(new[] {"1"});

            Assert.That(sum, Is.EqualTo(1));
        }

        [Test]
        public void ReturnSumOfTwoNumbers() {
            var summator = new Summator();

            var sum = summator.Calculate(new[] {"1", "2"});

            Assert.That(sum, Is.EqualTo(1 + 2));
        }

        [Test]
        public void ReturnSumOfAnyNumbers() {
            var summator = new Summator();

            var sum = summator.Calculate(new[] {"1", "2", "3", "4", "5"});

            Assert.That(sum, Is.EqualTo(1 + 2 + 3 + 4 + 5));
        }
    }
}