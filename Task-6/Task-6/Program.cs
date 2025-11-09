using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };
        fruits.Add("Orange");
        fruits.Remove("Banana");

        Console.WriteLine("Fruits in list:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Dictionary<int, string> fruitDict = new Dictionary<int, string>()
        {
            {1, "Apple"},
            {2, "Mango"},
            {3, "Orange"}
        };

        fruitDict.Add(4, "Grapes");

        Console.WriteLine("\nFruit Dictionary (ID : Name):");
        foreach (var kvp in fruitDict)
        {
            Console.WriteLine($"{kvp.Key} : {kvp.Value}");
        }
    }
}
