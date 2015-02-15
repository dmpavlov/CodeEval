#region Usings

using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Application;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class WhenSortNumbers {
        [Test]
        public void ReturnSortedSequenceWithOneNumber() {
            var sortedNumbers = SimpleSorter.Sort("1");

            CollectionAssert.AreEquivalent(new[] {1}, sortedNumbers);
        }

        [Test]
        public void ReturnSortedSequenceWithTwoNumbers() {
            var sortedNumbers = SimpleSorter.Sort("1.0 2.0");

            Assert.AreEqual(1.0, sortedNumbers[0]);
            Assert.AreEqual(2.0, sortedNumbers[1]);
        }

        [Test]
        public void ReturnSortedSequenceWithThreeNumbers() {
            var sortedNumbers = SimpleSorter.Sort("5.0 2.0 3.0");

            Assert.AreEqual(2.0, sortedNumbers[0]);
            Assert.AreEqual(3.0, sortedNumbers[1]);
            Assert.AreEqual(5.0, sortedNumbers[2]);
        }

        [Test]
        public void ReturnSortedSequenceWithMultipleNumbers() {
            var sortedNumbers = SimpleSorter.Sort("5 2 4 6 1 3");

            Assert.AreEqual(1, sortedNumbers[0]);
            Assert.AreEqual(2, sortedNumbers[1]);
            Assert.AreEqual(3, sortedNumbers[2]);
            Assert.AreEqual(4, sortedNumbers[3]);
            Assert.AreEqual(5, sortedNumbers[4]);
            Assert.AreEqual(6, sortedNumbers[5]);
        }
    }
}