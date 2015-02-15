#region Usings

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

#endregion

namespace Application {
    internal class Program {
        private static void Main(string[] args) {
            var detector = new AlternateNumbersDetector();

            using (var streamReader = File.OpenText(args[0]))
                while (!streamReader.EndOfStream) {
                    var line = streamReader.ReadLine();
                    if (line == null)
                        continue;

                    Console.WriteLine(detector.GetAlternateNumbers(line));
                }
        }
    }

    public class AlternateNumbersDetector {
        private readonly StackOfIntegers stack;

        public AlternateNumbersDetector() {
            stack = new StackOfIntegers();
        }

        public string GetAlternateNumbers(string input) {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            PushItemsToStack(input);

            return PopulateEveryAlternateNumber();
        }

        private void PushItemsToStack(string input) {
            var numbers = input.Split(' ');
            foreach (var number in numbers) {
                stack.Push(int.Parse(number));
            }
        }

        private string PopulateEveryAlternateNumber() {
            var result = new StringBuilder();
            while (!stack.IsEmpty) {
                result.AppendFormat(" {0}", stack.Pop());

                if (stack.IsEmpty)
                    continue;

                stack.Pop();
            }

            return result.ToString().Trim();
        }
    }

    public class StackOfIntegers {
        private List<int> Items { get; set; }

        public bool IsEmpty {
            get { return Items.Count == 0; }
        }

        public StackOfIntegers() {
            Items = new List<int>();
        }

        public void Push(int number) {
            Items.Add(number);
        }

        public int Pop() {
            if (Items.Count == 0)
                throw new InvalidOperationException("Failed to Pop an item from empty stack.");

            var result = Items[Items.Count - 1];
            Items.RemoveAt(Items.Count - 1);

            return result;
        }
    }
}