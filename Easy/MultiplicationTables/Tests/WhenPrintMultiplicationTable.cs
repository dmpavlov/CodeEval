using NUnit.Framework;
using Domain;

namespace Tests {
	[TestFixture]
	public class WhenPrintMultiplicationTable {
		[Test]
		public void Output_1_ForSize_1()
		{
			var table = new MultiplicationTable(1);

			var output = table.ToString();

			Assert.That(output, Is.EqualTo("1\n"));
		}

		[Test]
		public void OutputTableOfSize_2_ForSize_2() {
			var table = new MultiplicationTable(2);

			var output = table.ToString();

			Assert.That(output, Is.EqualTo("1   2\n2   4\n"));
		}

		[Test]
		public void OutputTableOfSize_3_ForSize_3() {
			var table = new MultiplicationTable(3);

			var output = table.ToString();

			Assert.That(output, Is.EqualTo("1   2   3\n2   4   6\n3   6   9\n"));
		}
	}
}

