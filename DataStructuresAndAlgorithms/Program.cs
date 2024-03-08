﻿using System.Collections;

namespace DataStructuresAndAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define some strings to add to the list
            string[] comedians = {"Leo Gallagher", "Rodney Dangerfield",
                     "George Carlin", "Lenny Bruce",
                     "Eddie Murphy", "Louie Anderson"};
            // TODO: Create the list
            List<string> strList = new List<string>(10);


            // TODO: Add some elements to the list from an existing array
            strList.AddRange(comedians);


            // TODO: Add individual items
            strList.Add("Tina Fey");
            strList.Add("Amy Poehler");


            // TODO: Examine the Count and Capacity
            Console.WriteLine("Count and Capacity: {0}, {1}", strList.Count, strList.Capacity);


            // TODO: Enumerate the items in the list with a foreach loop
            // PrintList(strList);


            // TODO: Access any item by its index
            Console.WriteLine("Item value: {0}", strList[4]);


            // TODO: Remove items from the list
            strList.RemoveAt(2);
            strList.Remove("Tina Fey");


            // TODO: Sort the list content
            strList.Sort();
            // PrintList(strList);


            // ** Searching List Content **/

            // TODO: Determine if a list contains a given item
            Console.WriteLine(strList.Contains("Ron Gallagher"));


            // TODO: The Exists function gives us a more customizable way to search
            // by using a predicate function to examine each element in the list
            bool found = strList.Exists(x => x.Length > 15);
            Console.WriteLine($"Item found: {found}");


            // TODO: Use the Find function to search through items
            string item = "";
            item = strList.Find(match: x => x.StartsWith("L"));
            Console.WriteLine(item);


            // TODO: The FindAll function can find multiple items
            List<string> itemList = strList.FindAll(match: x => x.StartsWith("L"));
            PrintList(itemList);

            // TODO: Use TrueForAll to see if a given condition is true for all elements
            bool result = strList.TrueForAll(x => x.StartsWith("L"));
            Console.WriteLine($" Result: {result}");


            static void PrintList(List<string> theList)
            {
                foreach (string str in theList)
                {
                    Console.WriteLine(str);
                }
            }


            // Console.WriteLine("Hello, World!");

            // Stack ts = new Stack();
        }
    }
}