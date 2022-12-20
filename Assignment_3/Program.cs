using System;
using System.Collections.Generic;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> coins = new List<decimal>();
            Console.Write("Please write the amount you want to get. The value should be no more than 5.00: ");
            string userIn = Console.ReadLine();
            decimal num;
            while (!decimal.TryParse(userIn, out num) || Convert.ToDecimal(userIn) > 5 || Convert.ToDecimal(userIn) <= 0)
            {
                Console.Write("The input is incorrect. The value must be integer, greater than 0 and no more than 5: ");
                userIn = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine($"Possible combinations of {userIn} are:");
            ChangeAmount(coins, 10, 0, 0, Convert.ToDecimal(userIn));
            List<decimal> minValue = LowestNumberOfCoins(Convert.ToDecimal(userIn));
            DisplayLowestAmount(minValue);
            Console.ReadLine();
        }

        static List<decimal> denominations = new List<decimal>
            {
                2.0M,
                1.0M,
                0.5M,
                0.2M,
                0.1M,
                0.05M,
                0.02M,
                0.01M
            };

        private static void ChangeAmount(List<decimal> coins, int maxCoins, decimal highest, decimal sum, decimal amountToGet)
        {
            if (sum == amountToGet)
            {
                DisplayAmount(coins);
                return;
            }

            if (sum > amountToGet || coins.Count == maxCoins)
            {
                return;
            }

            foreach (decimal value in denominations)
            {
                if (value >= highest)
                {
                    List<decimal> coinsNeeded = new List<decimal>(coins);
                    coinsNeeded.Add(value);
                    ChangeAmount(coinsNeeded, maxCoins, value, sum + value, amountToGet);
                }
            }
        }

        private static List<decimal> LowestNumberOfCoins(decimal amountToGet)
        {
            List<decimal> minValue = new List<decimal>();
            foreach (decimal value in denominations)
            {
                if ((amountToGet % value) < amountToGet)
                {
                    int numOfCoinsToAdd = (int)Math.Floor(amountToGet / value);
                    for (int i = 0; i < numOfCoinsToAdd; i++)
                    {
                        minValue.Add(value);
                    }
                    amountToGet = amountToGet % value;
                }
            }
            return minValue;
        }

        private static void DisplayAmount(List<decimal> coins)
        {
            foreach (decimal denominationNeeded in coins)
            {
                Console.Write($"{denominationNeeded}; ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void DisplayLowestAmount(List<decimal> coins)
        {
            coins.Reverse();
            Console.WriteLine();
            Console.WriteLine("Lowest number of coins:");
            foreach (decimal denomination in coins)
            {
                Console.Write($"{denomination}; ");
            }
            Console.WriteLine();
        }
    }
}
