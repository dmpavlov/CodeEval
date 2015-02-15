#region Usings

using System;
using System.IO;
using System.Linq;

#endregion

namespace Application {
    internal class Program {
        private static void Main(string[] args) {
            using (var streamReader = File.OpenText(args[0]))
                while (!streamReader.EndOfStream) {
                    var line = streamReader.ReadLine();
                    if (line == null)
                        continue;

                    Console.WriteLine(DuplicatesFinder.Find(line));
                }
        }
    }

    public static class DuplicatesFinder {
        public static int Find(string input) {
            var arguments = input.Split(';');
            var length = int.Parse(arguments[0]);
            var numbers = arguments[1].Split(',').ToList().ConvertAll(int.Parse);

            var sumOfAllNumbersIfNoDuplicates = length * (length - 1) / 2;
            var sumOfAllNumberSquaresIfNoDuplicates = length * (length - 1) * (2 * length - 1) / 6;

            var actualSumOfAllNumbers = 0;
            var actualSumOfAllNumberSquares = 0;
            foreach (var number in numbers) {
                actualSumOfAllNumbers += number;
                actualSumOfAllNumberSquares += number * number;
            }

            var duplicatedNumberMinusRemovedNumber = actualSumOfAllNumbers - sumOfAllNumbersIfNoDuplicates;
            var duplicatedNumberPlusRemovedNumber = (actualSumOfAllNumberSquares - sumOfAllNumberSquaresIfNoDuplicates) / duplicatedNumberMinusRemovedNumber;

            return (duplicatedNumberPlusRemovedNumber + duplicatedNumberMinusRemovedNumber) / 2;
        }
    }
}