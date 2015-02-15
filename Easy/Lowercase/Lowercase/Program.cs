#region Usings

using System;
using System.IO;

#endregion

namespace Lowercase {
    internal class Program {
        private static void Main(string[] args) {
            using (var streamReader = File.OpenText(args[0]))
                while (!streamReader.EndOfStream) {
                    var line = streamReader.ReadLine();
                    if (line == null)
                        continue;

                    Console.WriteLine(LowercaseTextConverter.Convert(line));
                }
        }
    }

    public static class LowercaseTextConverter {
        public static string Convert(string sentense) {
            return sentense.ToLowerInvariant();
        }
    }
}