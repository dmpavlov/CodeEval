#region Usings

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

#endregion

namespace Application {
    internal class Program {
        private static void Main(string[] args) {
            var mixedContentSeparator = new MixedContentSeparator();
            using (var streamReader = File.OpenText(args[0])) {
                while (!streamReader.EndOfStream) {
                    var line = streamReader.ReadLine();
                    if (line == null)
                        continue;

                    Console.WriteLine(mixedContentSeparator.Separate(line));
                }
            }
        }
    }

    public class MixedContentSeparator {
        private List<int> numbers;
        private List<string> words;

        public string Separate(string input) {
            if (string.IsNullOrEmpty(input)) {
                return string.Empty;
            }

            numbers = new List<int>();
            words = new List<string>();

            foreach (var word in input.Split(',')) {
                int result;
                if (int.TryParse(word, out result)) {
                    numbers.Add(result);
                    continue;
                }

                words.Add(word);
            }

            if (!words.Any()) {
                return OnlyNumbers();
            }

            if (!numbers.Any()) {
                return OnlyWords();
            }

            return SeparatedWordsAndNumbers();
        }

        private string OnlyWords() {
            return string.Join(",", words);
        }

        private string OnlyNumbers() {
            return string.Join(",", numbers);
        }

        private string SeparatedWordsAndNumbers() {
            return string.Format("{0}|{1}", OnlyWords(), OnlyNumbers());
        }
    }
}