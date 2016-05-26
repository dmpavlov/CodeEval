#region Usings

using Domain;
using NUnit.Framework;

#endregion

namespace Tests
{
    [TestFixture]
    public class WhenFindFirstNonRepeatedCharacter
    {
        [Test]
        public void ReturnNullCharIfInputIsEmpty()
        {
            var finder = CreateFinder();

            var character = finder.Find(string.Empty);

            Assert.That(character, Is.EqualTo('\0'));
        }

        [Test]
        public void ReturnSingleCharIfInputIsThatSingleChar()
        {
            var finder = CreateFinder();

            var character = finder.Find("a");

            Assert.That(character, Is.EqualTo('a'));
        }

        [Test]
        public void ReturnFirstCharIfInputHasThreeSeparateChars()
        {
            var finder = CreateFinder();

            var character = finder.Find("bcd");

            Assert.That(character, Is.EqualTo('b'));
        }

        [Test]
        public void ReturnFirstCharIfItIsNonRepeated()
        {
            var finder = CreateFinder();

            var character = finder.Find("abb");

            Assert.That(character, Is.EqualTo('a'));
        }


        [Test]
        public void ReturnLastCharacterIfItIsNonRepeated()
        {
            var finder = CreateFinder();

            var character = finder.Find("aab");

            Assert.That(character, Is.EqualTo('b'));
        }

        [Test]
        public void Return_y_From_yellow()
        {
            var finder = CreateFinder();

            var character = finder.Find("yellow");

            Assert.That(character, Is.EqualTo('y'));
        }

        [Test]
        public void Return_h_From_tooth()
        {
            var finder = CreateFinder();

            var character = finder.Find("tooth");

            Assert.That(character, Is.EqualTo('h'));
        }

        private static FirstNonRepeatedCharacterFinder CreateFinder()
        {
            return new FirstNonRepeatedCharacterFinder();
        }
    }
}