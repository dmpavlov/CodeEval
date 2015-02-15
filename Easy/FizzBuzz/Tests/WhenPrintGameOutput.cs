#region Usings

using System;
using FizzBuzz;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class WhenPrintGameOutput {
        [Test]
        public void PrintSinglePlayerNumbers() {
            Game game = Create.Game
                              .WithNumberOfPlayers(1);

            var output = game.PrintOutput();

            Assert.AreEqual("1", output);
        }

        [Test]
        public void PrintTwoPlayerNumbers() {
            Game game = Create.Game
                              .WithNumberOfPlayers(2);

            var output = game.PrintOutput();

            Assert.AreEqual("1 2", output);
        }

        [Test]
        public void PrintAnyAmountPlayerNumbers() {
            Game game = Create.Game
                              .WithNumberOfPlayers(5);

            var output = game.PrintOutput();

            Assert.AreEqual("1 2 3 4 5", output);
        }

        [Test]
        public void PrintFizzIfPlayerNumberIsDivisibleByA() {
            Game game = Create.Game
                              .WithNumberOfPlayers(10)
                              .WithFizzDivisibleNumber(3);

            var output = game.PrintOutput();

            Assert.AreEqual("1 2 F 4 5 F 7 8 F 10", output);
        }

        [Test]
        public void PrintBuzzIfPlayerNumberIsDivisibleByB() {
            var game = Create.Game
                             .WithNumberOfPlayers(7)
                             .WithBuzzDivisibleNumber(3);

            var output = game.PrintOutput();

            Assert.AreEqual("1 2 B 4 5 B 7", output);
        }

        [Test]
        public void PrintFizzBuzzIfPlayerNumberIsDivisibleByBothAandB() {
            var game = Create.Game
                             .WithNumberOfPlayers(15)
                             .WithFizzDivisibleNumber(2)
                             .WithBuzzDivisibleNumber(7);

            var output = game.PrintOutput();

            Assert.AreEqual("1 F 3 F 5 F B F 9 F 11 F 13 FB 15", output);
        }  
        
        [Test]
        public void PrintFizzOrBuzzDependingOnThePlayerNumber() {
            var game = Create.Game
                             .WithNumberOfPlayers(10)
                             .WithFizzDivisibleNumber(3)
                             .WithBuzzDivisibleNumber(5);

            var output = game.PrintOutput();

            Assert.AreEqual("1 2 F 4 B F 7 8 F B", output);
        }
    }

    public static class Create {
        public static GameBuilder Game {
            get { return new GameBuilder(); }
        }
    }

    public class GameBuilder {
        private int numberOfPlayers;
        private int fizzDivisibleNumber;
        private int buzzDivisibleNumber;

        public GameBuilder() {
            fizzDivisibleNumber = Int32.MaxValue;
            buzzDivisibleNumber = Int32.MaxValue;
        }

        public GameBuilder WithNumberOfPlayers(int numberOfPlayers) {
            this.numberOfPlayers = numberOfPlayers;
            return this;
        }

        public GameBuilder WithFizzDivisibleNumber(int fizzDivisibleNumber) {
            this.fizzDivisibleNumber = fizzDivisibleNumber;
            return this;
        }

        public Game WithBuzzDivisibleNumber(int buzzDivisibleNumber) {
            this.buzzDivisibleNumber = buzzDivisibleNumber;
            return this;
        }

        public static implicit operator Game(GameBuilder gameBuilder) {
            return new Game(gameBuilder.numberOfPlayers, gameBuilder.fizzDivisibleNumber, gameBuilder.buzzDivisibleNumber);
        }
    }
}