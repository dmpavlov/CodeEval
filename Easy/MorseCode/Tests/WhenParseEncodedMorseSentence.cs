#region Usings

using Application;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class WhenParseEncodedMorseSentence {
        [Test]
        public void CanParse_AV2() {
            var sequenceParser = new SequenceParser();

            var output = sequenceParser.Parse(".- ...- ..---");

            Assert.AreEqual("AV2", output);
        }
    }
}