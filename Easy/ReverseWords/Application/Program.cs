#region Usings

using System;
using System.IO;
using System.Text;

#endregion

namespace Application {
    internal class Program {
        private static void Main(string[] args) {
            var sequenceProcessor = new SentenceProcessor();

            using (var streamReader = File.OpenText(args[0]))
                while (!streamReader.EndOfStream) {
                    var line = streamReader.ReadLine();
                    if (null == line)
                        continue;

                    Console.WriteLine(sequenceProcessor.ReverseWords(line));
                }
        }
    }

    public class SentenceProcessor {
        public string ReverseWords(string sentence) {
            if (string.IsNullOrEmpty(sentence))
                return string.Empty;

            var words = sentence.Split(' ');
            var result = new StringBuilder();
            result.Append(words[words.Length - 1]);

            for (var i = words.Length - 2; i >= 0; i--) {
                result.AppendFormat(" {0}", words[i]);
            }

            return result.ToString();
        }
    }
}