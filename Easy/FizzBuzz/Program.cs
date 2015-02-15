#region Usings

using System;
using System.Globalization;
using System.IO;
using System.Text;

#endregion

namespace FizzBuzz {
    internal class Program {
        private static void Main(string[] args) {
            using (var streamReader = File.OpenText(args[0]))
                while (!streamReader.EndOfStream) {
                    var line = streamReader.ReadLine();
                    if (null == line)
                        continue;

                    var numbers = line.Split(' ');
                    var game = new Game(int.Parse(numbers[2]), int.Parse(numbers[0]), int.Parse(numbers[1]));

                    Console.WriteLine(game.PrintOutput());
                }
        }
    }

    public class Game {
        private readonly int numberOfPlayers;
        private readonly int fizzDivisibleNumber = Int32.MaxValue;
        private readonly int buzzDivisibleNumber = Int32.MaxValue;
        private const string FizzWord = "F";
        private const string BuzzWord = "B";
        private const string FizzBuzzWord = "FB";

        public Game(int numberOfPlayers, int fizzDivisibleNumber, int buzzDivisibleNumber) {
            this.numberOfPlayers = numberOfPlayers;
            this.fizzDivisibleNumber = fizzDivisibleNumber;
            this.buzzDivisibleNumber = buzzDivisibleNumber;
        }

        public string PrintOutput() {
            var output = new StringBuilder("1");

            for (var i = 2; i <= numberOfPlayers; i++) {
                var word = i.ToString(CultureInfo.InvariantCulture);

                var isTimeToSayFizz = i % fizzDivisibleNumber == 0;
                var isTimeToSayBuzz = i % buzzDivisibleNumber == 0;

                if (isTimeToSayFizz && isTimeToSayBuzz) {
                    word = FizzBuzzWord;
                }
                else if (isTimeToSayFizz) {
                    word = FizzWord;
                }
                else if (isTimeToSayBuzz) {
                    word = BuzzWord;
                }

                output.AppendFormat(" {0}", word);
            }

            return output.ToString();
        }
    }
}