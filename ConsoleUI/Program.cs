using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //example 1:

            List<string> firstNames = new List<string>();

            firstNames.Add("Prateek");
            firstNames.Add("John");
            firstNames.Add("Henry");

            foreach (string firstName in firstNames)
            {
                Console.WriteLine($"Hello, {firstName}");
            }

            Console.WriteLine();

            //example 2:

            Dictionary<int, string> events = new Dictionary<int, string>();

            events.Add(1991, "I was born in this year.");
            events.Add(2016, "I went to USA for my master's.");
            events.Add(2019, "I got married.");

            foreach (var year in events)
            {
                Console.WriteLine($"Year {year.Key}: {year.Value}");
            }


            Console.ReadLine();
        }
    }
}