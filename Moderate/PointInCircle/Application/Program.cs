#region Usings

using System;
using System.Globalization;
using System.IO;

#endregion

namespace Application {
    internal class Program {
        private static void Main(string[] args) {
            using (var reader = File.OpenText(args[0]))
                while (!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    if (null == line)
                        continue;

                    var arguments = line.Split(';');

                    var circle = new Circle(arguments[0], arguments[1]);
                    var point = new Point(arguments[2]);

                    Console.WriteLine(circle.Contains(point).ToString().ToLower());
                }
        }
    }

    public class Point {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point(string arguments) {
            ParseArguments(arguments);
        }

        private void ParseArguments(string arguments) {
            var parts = arguments.Split(',');
            var openBraceIndex = arguments.IndexOf("(", StringComparison.Ordinal);

            var xString = parts[0].Substring(openBraceIndex + 1);
            X = ParseDouble(xString);

            var yString = parts[1].Substring(1, parts[1].Length - 2);
            Y = ParseDouble(yString);
        }

        private static double ParseDouble(string input) {
            return double.Parse(input, CultureInfo.InvariantCulture);
        }
    }

    public class Circle {
        public Circle(string center, string radius) {
            Center = new Point(center);
            ParseRadius(radius);
        }

        private void ParseRadius(string radius) {
            var colonIndex = radius.IndexOf(':');
            Radius = double.Parse(radius.Substring(colonIndex + 1), CultureInfo.InvariantCulture);
        }

        public Point Center { get; private set; }
        public double Radius { get; private set; }

        public bool Contains(Point point) {
            const double tolerance = .00001;
            if (Math.Abs(point.X - Center.X) < tolerance &&
                Math.Abs(point.Y - Center.Y) < tolerance) {
                return true;
            }

            return (point.X - Center.X) * (point.X - Center.X) +
                   (point.Y - Center.Y) * (point.Y - Center.Y) <= Radius * Radius;
        }
    }
}