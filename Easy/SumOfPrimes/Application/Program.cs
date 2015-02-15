#region Usings

using System;
using System.Linq;

#endregion

namespace Application {
    internal class Program {
        private static void Main(string[] args) {
            Console.WriteLine(new PrimeNumbersFinder(1000).Items.Sum());
        }
    }

    public class PrimeNumbersFinder {
        private readonly int length;

        public PrimeNumbersFinder(int length) {
            this.length = length;

            Items = new int[this.length];
            PopulatePrimeNumbers();
        }

        private void PopulatePrimeNumbers() {
            Items[0] = 2;
            var index = 1;
            var number = 3;

            while (index < length) {
                if (IsPrime(number)) {
                    Items[index] = number;
                    index++;
                }

                number += 2;
            }
        }

        private static bool IsPrime(int number) {
            for (var i = 3; i <= Math.Sqrt(number); i += 2) {
                if (number % i == 0) {
                    return false;
                }
            }

            return true;
        }

        public int[] Items { get; private set; }
    }
}