#region Usings

using System;
using System.Collections.Generic;
using System.IO;

#endregion

namespace Application {
    internal class Program {
        private static void Main(string[] args) {
            var converter = new HexToDecimalConverter();

            using (var streamReader = File.OpenText(args[0]))
                while (!streamReader.EndOfStream) {
                    var line = streamReader.ReadLine();
                    if (line == null)
                        continue;

                    Console.WriteLine(converter.Convert(line));
                }
        }
    }

    public class HexToDecimalConverter {
        private readonly Dictionary<char, int> values = new Dictionary<char, int> {
                                                                                          {'0', 0},
                                                                                          {'1', 1},
                                                                                          {'2', 2},
                                                                                          {'3', 3},
                                                                                          {'4', 4},
                                                                                          {'5', 5},
                                                                                          {'6', 6},
                                                                                          {'7', 7},
                                                                                          {'8', 8},
                                                                                          {'9', 9},
                                                                                          {'a', 10},
                                                                                          {'b', 11},
                                                                                          {'c', 12},
                                                                                          {'d', 13},
                                                                                          {'e', 14},
                                                                                          {'f', 15},
                                                                                  };

        public int Convert(string hexValue) {
            var result = 0;
            var counter = hexValue.Length - 1;

            foreach (var character in hexValue) {
                result += (int) Math.Pow(16, counter) * values[character];
                counter--;
            }

            return result;
        }
    }
}