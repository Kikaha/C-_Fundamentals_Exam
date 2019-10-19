using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
    {
    static void Main(string[] args)
        {

        string input = Console.ReadLine();
        while (input != "stop playing")
            {
            List<int> numbers = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> sorted = new List<int>();
            sorted.AddRange(numbers);
            sorted.Sort();
            bool isUnique = true;
            for (var index = 1; index < sorted.Count; index++)
                {
                var previous = sorted[index - 1];
                var current = sorted[index];
                if (current == previous)
                    {
                    isUnique = false;
                    break;
                    }
                }
            if (isUnique)
                {
                for (int i = 0; i < sorted.Count; i++)
                    {
                    if (numbers[i] % 2 == 0)
                        {
                        numbers[i] += 2;
                        }
                    }
                numbers.Sort();
                double sum = numbers.Sum();
                double result = sum / numbers.Count;
                Console.WriteLine($"Unique list: {String.Join(",", numbers)}");
                Console.WriteLine($"Output: {result:0.00}");
                }
            else
                {
                for (int i = 0; i < sorted.Count; i++)
                    {
                    if (numbers[i] % 2 != 0)
                        {
                        numbers[i] += 3;
                        }
                    }
                numbers.Sort();
                double sum = numbers.Sum();
                double result = sum / numbers.Count;
                Console.WriteLine($"Non-unique list: {String.Join(":", numbers)}");
                Console.WriteLine($"Output: {result:0.00}");
                }
            input = Console.ReadLine();
            }
        }
    }
 


