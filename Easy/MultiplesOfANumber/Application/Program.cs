using System.IO;
using System;

namespace Application {
	class MainClass {
		public static void Main(string[] args) {
			var multipleFinder = new MultipleFinder();
			using (var reader = File.OpenText(args[0]))
				while (!reader.EndOfStream) {
					var line = reader.ReadLine();
					if (line == null) continue;

					var numbers = line.Split(',');
					Console.WriteLine(multipleFinder.FindFor(int.Parse(numbers[0]), 
					                                         int.Parse(numbers[1])));
				}
		}
	}

	public class MultipleFinder {
		public int FindFor(int x, int n) {
			if (x <= n) {
				return n;
			}

			var result = n;
			do {
				result += n;
			}
			while (result < x);

			return result;
		}
	}
}