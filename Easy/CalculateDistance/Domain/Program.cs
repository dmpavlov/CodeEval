#region Usings

using System;
using System.IO;

#endregion

namespace Domain {
    internal class Program {
        private static void Main(string[] args) {
            var distanceCalculator = new DistanceCalculator();

            using (var streamReader = File.OpenText(args[0]))
                while (!streamReader.EndOfStream) {
                    var line = streamReader.ReadLine();
                    if (null == line)
                        continue;

                    Console.WriteLine(distanceCalculator.CalculateDistance(line));
                }
        }
    }

    public class DistanceCalculator {
        public int CalculateDistance(string input) {
            var firstClosingBracketIndex = input.IndexOf(')');

            var firstPointInput = input.Substring(1, firstClosingBracketIndex - 1);
            var secondPointInput = input.Substring(firstClosingBracketIndex + 3).Replace(")", "");

            var firstPoint = ParsePointCoordinates(firstPointInput);
            var secondPoint = ParsePointCoordinates(secondPointInput);

            var xDistance = firstPoint.X - secondPoint.X;
            var yDistance = firstPoint.Y - secondPoint.Y;

            return (int) Math.Sqrt(xDistance * xDistance + yDistance * yDistance);
        }

        private static Point ParsePointCoordinates(string input) {
            var coordinates = input.Split(',');

            var x = int.Parse(coordinates[0]);
            var y = int.Parse(coordinates[1]);

            return new Point(x, y);
        }
    }

    public class Point {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point(int x, int y) {
            X = x;
            Y = y;
        }
    }
}