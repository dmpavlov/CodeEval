#region Usings

using System;
using System.Text;

#endregion

namespace OddNumbers {
    internal class Program {
        private static void Main(string[] args) {
            Console.Write(new OddNumbersSequence().Print(99));
            Console.ReadKey();
        }
    }

    public class OddNumbersSequence {
        public string Print(int maxValue) {
            var output = new StringBuilder();

            for (var i = 1; i <= maxValue; i += 2) {
                output.Append(i + Environment.NewLine);
            }

            return output.ToString();
        }
    }
}