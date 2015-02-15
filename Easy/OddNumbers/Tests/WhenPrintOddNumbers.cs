#region Usings

using System;
using NUnit.Framework;
using OddNumbers;

#endregion

namespace Tests {
    [TestFixture]
    public class WhenPrintOddNumbers {
        [Test]
        public void Output_1_AsFistOddNumber() {
            var oddNumbersSequence = new OddNumbersSequence();

            var output = oddNumbersSequence.Print(1);

            Assert.AreEqual("1" + Environment.NewLine, output);
        }

        [Test]
        public void Output_1_2_3_AsOddNumbers() {
            var oddNumbersSequence = new OddNumbersSequence();

            var output = oddNumbersSequence.Print(5);

            Assert.AreEqual(string.Format("1{0}3{0}5{0}", Environment.NewLine), output);
        }
    }
}