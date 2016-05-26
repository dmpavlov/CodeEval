#region Usings

using System.Collections.Generic;
using System.Linq;

#endregion

namespace Domain
{
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