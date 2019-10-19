using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
        {
        static void Main(string[] args)
            {
        List<string> input = new List<string>();
        for (int i = 0; i < 5; i++)
            {
            input.Add(Console.ReadLine());
            }
        string destinationStar = input[0];
        int distanceFromEarth = int.Parse(input[1]);
        double budget = double.Parse(input[2]);
        double fuelConsumption = double.Parse(input[3]);
        double casPriceDolar = double.Parse(input[4]);

        double leftover = budget - distanceFromEarth* fuelConsumption/100 * casPriceDolar;

        if (budget > (distanceFromEarth / 100) * fuelConsumption * casPriceDolar)
            {
            Console.WriteLine($"Off to {destinationStar} with ${leftover:0.00} for snacks");
            }
        else
            {
            Console.WriteLine($"Maybe another time, need ${Math.Abs(leftover):0.00} more");
            }
            }
        }

