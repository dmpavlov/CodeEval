#region Usings

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

#endregion

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (null == line)
                        continue;

                    var analyzer = new PangramsAnalyzer();
                    Console.WriteLine(analyzer.FindMissingLetters(line));
                }
        }
    }

    public class PangramsAnalyzer
    {
        private readonly Alpabet alphabet = new Alpabet();

        public string FindMissingLetters(string sentense)
        {
            if (string.IsNullOrEmpty(sentense))
            {
                return alphabet.ToString();
            }

            foreach (var letter in sentense)
            {
                alphabet.MarkAsFound(letter);
            }

            return alphabet.PrintNotFoundLetters();
        }
    }

    internal class Alpabet
    {
        private readonly Dictionary<char, bool> letters = new Dictionary<char, bool>();

        public Alpabet()
        {
            letters.Add('a', false);
            letters.Add('b', false);
            letters.Add('c', false);
            letters.Add('d', false);
            letters.Add('e', false);
            letters.Add('f', false);
            letters.Add('g', false);
            letters.Add('h', false);
            letters.Add('i', false);
            letters.Add('j', false);
            letters.Add('k', false);
            letters.Add('l', false);
            letters.Add('m', false);
            letters.Add('n', false);
            letters.Add('o', false);
            letters.Add('p', false);
            letters.Add('q', false);
            letters.Add('r', false);
            letters.Add('s', false);
            letters.Add('t', false);
            letters.Add('u', false);
            letters.Add('v', false);
            letters.Add('w', false);
            letters.Add('x', false);
            letters.Add('y', false);
            letters.Add('z', false);
        }

        public override string ToString()
        {
            return "abcdefghijklmnopqrstuvwxyz";
        }

        public void MarkAsFound(char letter)
        {
            letters[char.ToLower(letter, CultureInfo.InvariantCulture)] = true;
        }

        public string PrintNotFoundLetters()
        {
            var result = new StringBuilder();

            foreach (var letter in letters)
            {
                if (letter.Value)
                {
                    continue;
                }

                result.Append(letter.Key);
            }

            var notFoundLetters = result.ToString();
            return string.IsNullOrEmpty(notFoundLetters) ? "NULL" : notFoundLetters;
        }
    }
}