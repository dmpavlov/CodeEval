using NUnit.Framework;
using Application;
using NUnit.Framework.SyntaxHelpers;

namespace Tests {
	[TestFixture]
	public class MultipleFinderShould {
		[Test]
		public void ReturnZeroIfInputIsZero() {
			var multipleFinder = new MultipleFinder();

			var result = multipleFinder.FindFor(0, 0);

			Assert.That(result, Is.EqualTo(0));
		}

		[Test]
		public void ReturnXIfNIsEqualToX() {
			var multipleFinder = new MultipleFinder();

			var result = multipleFinder.FindFor(x: 2, n: 2);

			Assert.That(result, Is.EqualTo(2));
		}

		[Test]
		public void ReturnSmallestMultipleOfNGreaterThanX() {
			var multipleFinder = new MultipleFinder();

			var result = multipleFinder.FindFor(x: 3, n: 2);

			Assert.That(result, Is.EqualTo(2 * 2));
		}

		[Test]
		public void ReturnSmallestMultipleOfNIfXIs1635() {
			var multipleFinder = new MultipleFinder();

			var result = multipleFinder.FindFor(x: 1400, n: 512);

			Assert.That(result, Is.EqualTo(512 * 3));
		}

		[Test]
		public void ReturnNIfNIsAlreadyGreaterThanX() {
			var multipleFinder = new MultipleFinder();

			var result = multipleFinder.FindFor(x: 1, n: 2);

			Assert.That(result, Is.EqualTo(2));
		}
	}
}

