#region Usings

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

#endregion

namespace Application {
    internal class Program {
        private static void Main(string[] args) {
            using (var reader = File.OpenText(args[0]))
                while (!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    if (null == line)
                        continue;

                    var sortedNumbers = SimpleSorter.Sort(line);
                    Console.WriteLine(String.Join(" ", sortedNumbers.ConvertAll(_ => _.ToString("F3"))));
                    Console.ReadKey();
                }
        }
    }

    public static class SimpleSorter {
        private static List<double> InsertionSort(List<double> numbers) {
            for (var i = 1; i < numbers.Count; i++) {
                var currentNumberToInsert = numbers[i];

                var j = i - 1;
                while (j >= 0 && numbers[j] > currentNumberToInsert) {
                    numbers[j + 1] = numbers[j];
                    j--;
                }

                numbers[j + 1] = currentNumberToInsert;
            }

            return numbers;
        }

        public static List<double> Sort(string input) {
            var numbers = input.Split(' ')
                               .ToList()
                               .ConvertAll(_ => double.Parse(_, CultureInfo.InvariantCulture));

            QuickSort(numbers, 0, numbers.Count - 1);

            return numbers;
        }

        private static void QuickSort(List<double> numbers, int left, int right) {
            if (left < right) {
                var q = Partition(numbers, left, right);
                QuickSort(numbers, left, q - 1);
                QuickSort(numbers, q + 1, right);
            }
        }

        private static int Partition(List<double> numbers, int left, int right) {
            var pivot = numbers[right];

            var i = left - 1;
            double buffer;

            for (var j = left; j <= right - 1; j++) {
                if (numbers[j] <= pivot) {
                    i++;

                    buffer = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = buffer;
                }
            }

            buffer = numbers[i + 1];
            numbers[i + 1] = numbers[right];
            numbers[right] = buffer;

            return i + 1;
        }
    }
}