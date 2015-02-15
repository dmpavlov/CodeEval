#region Usings

using Application;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class AlternateNumbersDetectorShould {
        [Test]
        public void PrintEmptyStringIfInputIsEmpty() {
            var detector = new AlternateNumbersDetector();

            var output = detector.GetAlternateNumbers("");

            Assert.That(output, Is.EqualTo(""));
        }

        [Test]
        public void PrintSingleNumberIfInputIsThatNumber() {
            var detector = new AlternateNumbersDetector();

            var output = detector.GetAlternateNumbers("1");

            Assert.That(output, Is.EqualTo("1"));
        }

        [Test]
        public void PrintSingleNumberIfInputHasOnlyTwoNumbers() {
            var detector = new AlternateNumbersDetector();

            var output = detector.GetAlternateNumbers("1 2");

            Assert.That(output, Is.EqualTo("2"));
        }

        [Test]
        public void PrintEveryAlternateNumber() {
            var detector = new AlternateNumbersDetector();

            var output = detector.GetAlternateNumbers("1 2 3 4");

            Assert.That(output, Is.EqualTo("4 2"));
        }

        [Test]
        public void PrintEveryAlternateNumberWithNegativeNumber() {
            var detector = new AlternateNumbersDetector();

            var output = detector.GetAlternateNumbers("10 -2 3 4");

            Assert.That(output, Is.EqualTo("4 -2"));
        }

        [Test]
        public void PrintEveryAlternateNumberIfInputHasFiveNumbers() {
            var detector = new AlternateNumbersDetector();

            var output = detector.GetAlternateNumbers("1 2 3 4 5");

            Assert.That(output, Is.EqualTo("5 3 1"));
        }
    }
}