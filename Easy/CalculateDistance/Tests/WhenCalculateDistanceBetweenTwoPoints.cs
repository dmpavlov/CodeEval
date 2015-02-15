#region Usings

using Domain;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class WhenCalculateDistanceBetweenTwoPoints {
        [Test]
        public void OutputSingleIntegerResult() {
            var distanceCalculator = new DistanceCalculator();

            var distance = distanceCalculator.CalculateDistance("(25, 4) (1, -6)");

            Assert.AreEqual(26, distance);
        }

        [Test]
        public void ReturnZeroIfSamePoint() {
            var distanceCalculator = new DistanceCalculator();

            var distance = distanceCalculator.CalculateDistance("(25, 4) (25, 4)");

            Assert.AreEqual(0, distance);
        }
    }
}