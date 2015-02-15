#region Usings

using System;
using System.IO;

#endregion

namespace Application {
    internal class Program {
        private static void Main(string[] args) {
            var evenNumbesDetector = new EvenNumbesDetector();

            using (var streamReader = File.OpenText(args[0]))
                while (!streamReader.EndOfStream) {
                    var line = streamReader.ReadLine();
                    if (line == null)
                        continue;

                    Console.WriteLine(evenNumbesDetector.IsEven(int.Parse(line)));
                }
        }
    }

    public class EvenNumbesDetector {
        public int IsEven(int number) {
            return (number % 2 == 0) ? 1 : 0;
        }
    }
}