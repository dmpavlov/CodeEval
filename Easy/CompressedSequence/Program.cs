#region Usings

using System;
using System.IO;
using System.Text;

#endregion

namespace CompressedSequence {
    internal class Program {
        private static void Main(string[] args) {
            using (var streamReader = File.OpenText(args[0]))
                while (!streamReader.EndOfStream) {
                    var line = streamReader.ReadLine();
                    if (null == line)
                        continue;

                    Console.WriteLine(new SequenceCompressor().Compress(line));
                    Console.ReadKey();
                }
        }
    }

    public class SequenceCompressor {
        private const char NumbersSeparator = ' ';

        public string Compress(string input) {
            var output = new StringBuilder();

            var numbers = input.Split(NumbersSeparator);

            var numberOfOccurences = 0;
            var repeatedNumber = numbers[0];
            foreach (var number in numbers) {
                if (number == repeatedNumber) {
                    numberOfOccurences++;
                    continue;
                }

                output.AppendFormat("{0} {1} ", numberOfOccurences, repeatedNumber);

                numberOfOccurences = 1;
                repeatedNumber = number;
            }

            output.AppendFormat("{0} {1}", numberOfOccurences, repeatedNumber);

            return output.ToString();
        }
    }
}