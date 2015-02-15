#region Usings

using CompressedSequence;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class WhenCompressNumbersSequence {
        [Test]
        public void CompressFirstFourOccurrences() {
            var sequenceCompressor = new SequenceCompressor();

            var compressedSequence = sequenceCompressor.Compress("40 40 40 40");

            Assert.AreEqual("4 40", compressedSequence);
        }

        [Test]
        public void CompressAnyAmountOfOccurrencesOfTwoDifferentNumbers() {
            var sequenceCompressor = new SequenceCompressor();

            var compressedSequence = sequenceCompressor.Compress("40 40 40 40 29 29 29");

            Assert.AreEqual("4 40 3 29", compressedSequence);
        }


        [Test]
        public void CompressAnyAmountOfOccurrencesIfLastNumberIsNotRepeated() {
            var sequenceCompressor = new SequenceCompressor();

            var compressedSequence = sequenceCompressor.Compress("40 40 40 40 7 7 7 7 7 90");

            Assert.AreEqual("4 40 5 7 1 90", compressedSequence);
        }
    }
}