#region Usings

using Application;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class WhenIdentiryIfPointIsLocatedInsideCircle {
        [Test]
        public void CanParsePointCoordinates() {
            var point = new Point("Point: (1.00, 2.00)");

            Assert.AreEqual(1.00, point.X);
            Assert.AreEqual(2.00, point.Y);
        }

        [Test]
        public void CanParseCircleCoordinates() {
            var circle = new Circle("Center: (2.12, -3.48)", "Radius: 17.22");

            Assert.AreEqual(2.12, circle.Center.X);
            Assert.AreEqual(-3.48, circle.Center.Y);
            Assert.AreEqual(17.22, circle.Radius);
        }

        [Test]
        public void ReturnTrueIfPointIsCenterOfTheCircle() {
            var circle = new Circle("Center: (1.00, 1.00)", " Radius: 1.00");
            var point = new Point("Point: (1.00, 1.00)");

            var isInsideCircle = circle.Contains(point);

            Assert.True(isInsideCircle);
        }

        [Test]
        public void ReturnFalseIfPointIsOutsideOfTheCircle() {
            var circle = new Circle("Center: (5.05, -11)", "Radius: 21.2");
            var point = new Point("Point: (-31, -45)");

            var isInsideCircle = circle.Contains(point);

            Assert.False(isInsideCircle);
        }

        [Test]
        public void ReturnTrueIfPointIsInsideTheCircle() {
            var circle = new Circle("Center: (-9.86, 1.95)", "Radius: 47.28");
            var point = new Point("Point: (6.03, -6.42)");

            var isInsideCircle = circle.Contains(point);

            Assert.True(isInsideCircle);
        }
    }
}