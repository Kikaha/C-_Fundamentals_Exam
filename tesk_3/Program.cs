using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
        {
        static void Main(string[] args)
            {
        Dictionary<string, int> users = new Dictionary<string, int>();
        string input = Console.ReadLine();
        while (input!= "exam finished")
            {
            List<string> data = input.Split(new string[] {"<>"},StringSplitOptions.RemoveEmptyEntries).ToList();
            if (data[0]=="ban")
                {
                string banedPlayerName = data[1];
                users.Remove(banedPlayerName);
                break;
                }
            string playerName = data[0];
            int score = int.Parse(data[1]);
            if (!users.ContainsKey(playerName))
                {
                users[playerName] = new int();
                users[playerName] = score;
                }
            else
                {
                //int result = users.First(x => x.Key == playerName).Value;
                if (users.First(x=>x.Key==playerName).Value<score)
                    {
                    users[playerName] = score;
                    }
                }
            input = Console.ReadLine();
            }
        Console.WriteLine("Results:");
        foreach (KeyValuePair<string,int> user in users.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
            Console.WriteLine($"{user.Key} | {user.Value}");
            }

            }
        }

