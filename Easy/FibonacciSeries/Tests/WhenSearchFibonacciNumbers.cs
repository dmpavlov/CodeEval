#region Usings

using Application;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class WhenSearchFibonacciNumbers {
        [Test]
        public void FirstFibonacciNumberIs_0() {
            var fibonacciSequence = new FibonacciSequence(1);

            Assert.AreEqual(0, fibonacciSequence.Items[0]);
        }

        [Test]
        public void SecondFibonacciNumberIs_1() {
            var fibonacciSequence = new FibonacciSequence(2);

            Assert.AreEqual(1, fibonacciSequence.Items[1]);
        }

        [Test]
        public void ThirdFibonacciNumberIs_1() {
            var fibonacciSequence = new FibonacciSequence(3);

            Assert.AreEqual(1, fibonacciSequence.Items[2]);
        }

        [Test]
        public void TenthFibonacciNumberIs_34() {
            var fibonacciSequence = new FibonacciSequence(10);

            Assert.AreEqual(34, fibonacciSequence.Items[9]);
        }
    }
}