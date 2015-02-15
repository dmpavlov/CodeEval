#region Usings

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

#endregion

namespace Application {
    internal class Program {
        private static void Main(string[] args) {
            var multiplier = new ListMultiplier();

            using (var reader = File.OpenText(args[0])) {
                while (!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    if (null == line)
                        continue;

                    var result = multiplier.Multiply(line);

                    Console.WriteLine(string.Join(" ", result));
                    Console.ReadKey();
                }
            }
        }
    }

    public class ListMultiplier {
        private static List<byte> PopulateListFrom(string list) {
            var items = list.Trim().Split(' ');
            return items.Select(byte.Parse).ToList();
        }

        public List<byte> FirstList { get; private set; }
        public List<byte> SecondList { get; private set; }

        public List<int> Multiply(string input) {
            var lists = input.Split('|');

            FirstList = PopulateListFrom(lists[0]);
            SecondList = PopulateListFrom(lists[1]);

            return FirstList.Select((firstItem, itemIndex) => firstItem * SecondList[itemIndex]).ToList();
        }
    }
}