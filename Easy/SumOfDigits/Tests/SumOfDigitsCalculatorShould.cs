#region Usings

using Application;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class SumOfDigitsCalculatorShould {
        [Test]
        public void ReturnZeroIfNumberIsZero() {
            var sumOfDigitsCalculator = new SumOfDigitsCalculator();

            var sum = sumOfDigitsCalculator.Calculate(0);

            Assert.That(sum, Is.EqualTo(0));
        }

        [Test]
        public void ReturnNumberIfInputIsThatNumber() {
            var sumOfDigitsCalculator = new SumOfDigitsCalculator();

            var sum = sumOfDigitsCalculator.Calculate(1);

            Assert.That(sum, Is.EqualTo(1));
        }

        [Test]
        public void ReturnSumOfTwoFiguresInNumber() {
            var sumOfDigitsCalculator = new SumOfDigitsCalculator();

            var sum = sumOfDigitsCalculator.Calculate(23);

            Assert.That(sum, Is.EqualTo(2 + 3));
        }

        [Test]
        public void ReturnSumOfAnyAmountOfFiguresInNumber() {
            var sumOfDigitsCalculator = new SumOfDigitsCalculator();

            var sum = sumOfDigitsCalculator.Calculate(12345);

            Assert.That(sum, Is.EqualTo(1 + 2 + 3 + 4 + 5));
        }
    }
}