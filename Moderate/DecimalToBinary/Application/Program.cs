#region Usings

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

#endregion

namespace Application {
    internal class Program {
        private static void Main(string[] args) {
            using (var streamReader = File.OpenText(args[0]))
                while (!streamReader.EndOfStream) {
                    var line = streamReader.ReadLine();
                    if (line == null)
                        continue;

                    Console.WriteLine(DecimalToBinaryConverter.Convert(int.Parse(line)));
                }
        }
    }

    public static class DecimalToBinaryConverter {
        public static string Convert(int decimalValue) {
            if (decimalValue == 0) {
                return "0";
            }

            var reversedBits = new List<byte>();

            while (decimalValue != 0) {
                reversedBits.Add((byte) (decimalValue % 2));
                decimalValue = decimalValue / 2;
            }

            var result = new StringBuilder();
            for (var i = reversedBits.Count - 1; i >= 0; i--) {
                result.Append(reversedBits[i]);
            }

            return result.ToString();
        }
    }
}