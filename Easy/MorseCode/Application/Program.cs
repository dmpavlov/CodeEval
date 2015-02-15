#region Usings

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

#endregion

namespace Application {
    internal class Program {
        private static void Main(string[] args) {
            var sequenceParser = new SequenceParser();

            using (var streamReader = File.OpenText(args[0]))
                while (!streamReader.EndOfStream) {
                    var line = streamReader.ReadLine();
                    if (line == null)
                        continue;

                    Console.WriteLine(sequenceParser.Parse(line));
                }
        }
    }


    public class SequenceParser {
        private readonly MorseCodesConverter morseCodesConverter = new MorseCodesConverter();

        public string Parse(string sequence) {
            var chatacters = sequence.Split(' ');

            var result = new StringBuilder();
            foreach (var chatacter in chatacters) {
                result.Append(morseCodesConverter.Convert(chatacter));
            }

            return result.ToString();
        }
    }

    public class MorseCodesConverter {
        private readonly Dictionary<string, string> codes = new Dictionary<string, string> {
                                                                                                   {".----", "1"},
                                                                                                   {"..---", "2"},
                                                                                                   {"...--", "3"},
                                                                                                   {"....-", "4"},
                                                                                                   {".....", "5"},
                                                                                                   {"-....", "6"},
                                                                                                   {"--...", "7"},
                                                                                                   {"---..", "8"},
                                                                                                   {"----.", "9"},
                                                                                                   {"-----", "0"},
                                                                                                   {".-", "A"},
                                                                                                   {"-...", "B"},
                                                                                                   {"-.-.", "C"},
                                                                                                   {"-..", "D"},
                                                                                                   {".", "E"},
                                                                                                   {"..-.", "F"},
                                                                                                   {"--.", "G"},
                                                                                                   {"....", "H"},
                                                                                                   {"..", "I"},
                                                                                                   {".---", "J"},
                                                                                                   {"-.-", "K"},
                                                                                                   {".-..", "L"},
                                                                                                   {"--", "M"},
                                                                                                   {"-.", "N"},
                                                                                                   {"---", "O"},
                                                                                                   {".--.", "P"},
                                                                                                   {"--.-", "Q"},
                                                                                                   {".-.", "R"},
                                                                                                   {"...", "S"},
                                                                                                   {"-", "T"},
                                                                                                   {"..-", "U"},
                                                                                                   {"...-", "V"},
                                                                                                   {".--", "W"},
                                                                                                   {"-..-", "X"},
                                                                                                   {"-.--", "Y"},
                                                                                                   {"--..", "Z"}
                                                                                           };

        public string Convert(string character) {
            if (string.IsNullOrEmpty(character))
                return " ";

            return codes[character];
        }
    }
}