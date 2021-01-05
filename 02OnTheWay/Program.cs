using System;
using System.Collections.Generic;
using System.Linq;

namespace _02OnTheWay
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> storeAndItems = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split("->");
            string command = input[0];

            while (command != "END")
            {
                string storeName = input[1];
                List<string> itemsInStore = new List<string>();

                if (command == "Add")
                {
                    string[] tokensItems = input[2].Split(",");
                    foreach (var item in tokensItems)
                    {
                        itemsInStore.Add(item);
                    }

                    if (!storeAndItems.ContainsKey(storeName))
                    {
                        storeAndItems.Add(storeName, itemsInStore);
                    }
                    else
                    {

                        foreach (var item in tokensItems)
                        {
                            storeAndItems[storeName].Add(item);

                        }

                    }
                }
                else if(storeAndItems.ContainsKey(storeName))
                {
                    storeAndItems.Remove(storeName);
                }

                input = Console.ReadLine().Split("->");
                command = input[0];
            }

            Console.WriteLine("Stores list:");
            foreach (var kvp in storeAndItems
                .OrderByDescending(x=>x.Value.Count)
                .ThenByDescending(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var item in storeAndItems[kvp.Key])
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}

