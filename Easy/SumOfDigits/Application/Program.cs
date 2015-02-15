#region Usings

using System;
using System.IO;

#endregion

namespace Application {
    internal class Program {
        private static void Main(string[] args) {
            var sumOfDigitsCalculator = new SumOfDigitsCalculator();

            using (var reader = File.OpenText(args[0])) {
                while (!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    if (null == line)
                        continue;

                    Console.WriteLine(sumOfDigitsCalculator.Calculate(int.Parse(line)));
                    Console.ReadKey();
                }
            }
        }
    }

    public class SumOfDigitsCalculator {
        public int Calculate(int number) {
            var result = 0;

            while (number > 0) {
                result += number % 10;
                number = number / 10;
            }

            return result;
        }
    }
}