using System;
using System.Text;

namespace Application {
	class MainClass {
		public static void Main(string[] args) {
			Console.WriteLine(new MultiplicationTable(12));
		}
	}

	public class MultiplicationTable {
		private readonly int size;

		public MultiplicationTable(int size) {
			this.size = size;
		}

		public override string ToString() {
			var result = new StringBuilder();

			for (int i = 1; i <= size; i++) {
				result.AppendFormat("{0}", i);

				for (int j = 2; j <= size; j++) {
					result.AppendFormat("{0,4}", i * j);
				}
				result.AppendLine();
			}

			return result.ToString();
		}
	}
}