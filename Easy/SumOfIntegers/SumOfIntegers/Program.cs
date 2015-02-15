#region Usings

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

#endregion

namespace SumOfIntegers {
    internal class Program {
        private static void Main(string[] args) {
            var numbers = new List<string>();

            using (var streamReader = File.OpenText(args[0])) {
                while (!streamReader.EndOfStream) {
                    var line = streamReader.ReadLine();
                    if (line == null)
                        continue;

                    numbers.Add(line);
                }
            }

            Console.WriteLine(new Summator().Calculate(numbers));
        }
    }

    public class Summator {
        public int Calculate(IEnumerable<string> numbers) {
            return numbers.Sum(_ => string.IsNullOrEmpty(_) ? 0 : int.Parse(_));
        }
    }
}