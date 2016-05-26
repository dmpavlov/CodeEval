#region Usings

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

#endregion

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var finder = new FirstNonRepeatedCharacterFinder();
            using (var reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (null == line)
                        continue;

                    Console.WriteLine(finder.Find(line));
                }
        }
    }

    public class FirstNonRepeatedCharacterFinder

    {
        public char Find(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return '\0';
            }

            var characters = new Dictionary<char, int>();
            foreach (var letter in input)
            {
                if (characters.ContainsKey(letter))
                {
                    characters[letter] += 1;
                }
                else
                {
                    characters.Add(letter, 1);
                }
            }

            return (from entry in characters
                    where entry.Value == 1
                    select entry.Key).FirstOrDefault();
        }
    }
}