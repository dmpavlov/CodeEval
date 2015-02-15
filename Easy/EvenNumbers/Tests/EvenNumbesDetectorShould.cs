#region Usings

using Application;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class EvenNumbesDetectorShould {
        [Test]
        public void Return_0_IfNumberIsOdd() {
            var evenNumbesDetector = new EvenNumbesDetector();

            var result = evenNumbesDetector.IsEven(1);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Return_1_IfNumberIsEven() {
            var evenNumbesDetector = new EvenNumbesDetector();

            var result = evenNumbesDetector.IsEven(2);

            Assert.That(result, Is.EqualTo(1));
        }
    }
}