#region Usings

using System;
using System.IO;

#endregion

namespace Application {
    internal class Program {
        private static void Main(string[] args) {
            using (var streamReader = File.OpenText(args[0]))
                while (!streamReader.EndOfStream) {
                    var line = streamReader.ReadLine();
                    if (line == null)
                        continue;

                    Console.WriteLine(NumberParser.GetNumberOfOnesIn(int.Parse(line)));
                }
        }
    }

    public static class NumberParser {
        public static int GetNumberOfOnesIn(int number) {
            var counter = 0;

            while (number > 0) {
                if ((number & 1) != 0)
                    counter++;

                number = number >> 1;
            }

            return counter;
        }
    }
}