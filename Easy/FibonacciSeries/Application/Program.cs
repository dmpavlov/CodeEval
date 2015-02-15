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
                    if (null == line)
                        continue;

                    var length = int.Parse(line);
                    Console.WriteLine(new FibonacciSequence(length).Items[length]);
                    Console.ReadKey();
                }
        }
    }

    public class FibonacciSequence {
        private readonly int length;
        public int[] Items { get; private set; }

        public FibonacciSequence(int length) {
            if (length == 0)
                length = 1;

            this.length = length + 1;
            Items = new int[this.length];

            PopulateItems();
        }

        private void PopulateItems() {
            Items[0] = 0;
            Items[1] = 1;

            var index = 2;
            while (index < length) {
                Items[index] = Items[index - 1] + Items[index - 2];
                index++;
            }
        }
    }
}