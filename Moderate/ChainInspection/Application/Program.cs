#region Usings

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

#endregion

namespace Application {
    internal class Program {
        private static void Main(string[] args) {
            var chainInspector = new ChainInspector();

            using (var streamReader = File.OpenText(args[0]))
                while (!streamReader.EndOfStream) {
                    var line = streamReader.ReadLine();
                    if (line == null)
                        continue;

                    Console.WriteLine(chainInspector.InspectChain(line));
                }
        }
    }

    public class ChainInspector {
        private readonly PathChecker pathChecker;
        private const string BadInput = "BAD";
        private const string GoodInput = "GOOD";

        private const string BeginItem = "BEGIN";
        private const string EndItem = "END";

        public ChainInspector() {
            pathChecker = new PathChecker();
        }

        public string InspectChain(string input) {
            if (IsEmpty(input)) {
                return BadInput;
            }

            if (HasNoBegin(input) || HasNoEnd(input)) {
                return BadInput;
            }

            var isPathExist = pathChecker.IsPathExist(ChainParser.Parse(input));

            return isPathExist ? GoodInput : BadInput;
        }

        private static bool IsEmpty(string input) {
            return string.IsNullOrEmpty(input);
        }

        private static bool HasNoBegin(string input) {
            return !input.Contains(BeginItem);
        }

        private static bool HasNoEnd(string input) {
            return !input.Contains(EndItem);
        }
    }

    public class PathChecker {
        private const string BeginItem = "BEGIN";
        private const string EndItem = "END";

        public bool IsPathExist(Dictionary<string, string> chainItems) {
            var numberOfVisitedItems = 1;
            var currentItem = chainItems[BeginItem];

            foreach (var item in chainItems) {
                if (IsFinalDestination(currentItem)) {
                    break;
                }

                if (HasNextItem(chainItems, currentItem)) {
                    currentItem = chainItems[currentItem];
                }
                else {
                    break;
                }

                numberOfVisitedItems++;
            }

            return AreAllItemsVisited(chainItems, numberOfVisitedItems);
        }

        private static bool AreAllItemsVisited(Dictionary<string, string> chainItems, int numberOfVisitedItems) {
            return numberOfVisitedItems == chainItems.Count;
        }

        private static bool HasNextItem(Dictionary<string, string> chainItems, string currentItem) {
            return chainItems.ContainsKey(currentItem);
        }

        private static bool IsFinalDestination(string item) {
            return item.Equals(EndItem, StringComparison.InvariantCultureIgnoreCase);
        }
    }

    public static class ChainParser {
        public static Dictionary<string, string> Parse(string input) {
            var items = input.Split(';');
            return items.Select(t => t.Split('-')).ToDictionary(chainItem => chainItem[0], chainItem => chainItem[1]);
        }
    }
}