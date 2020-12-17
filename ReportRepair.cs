using System;
using System.Collections.Generic;

namespace AdventofCodeCS
{
    class Day1
    {
        static void Main(string[] args)
        {
            List<int> listOfExpenses = new List<int>(); //list of converted input
            List<String> listOfInput = new List<string>(); //List of string inputs
            int entry1;
            int entry2 = 0;
            int product = 0;

            void expenseMult(List<int> entries) /* Fxn used to compute the report*/
            {
                entry1 = entries[0]; //Assign first number (e.g 1721)

                for(int i = 1; i < entries.Count; i++)
                {
                    int addition = entry1 + entries[i]; //Add the first no to other occuring mumbers to find match

                    if(addition == 2020)
                    {
                        entry2 = entries[i]; // 299
                        product = entry1 * entry2; //The product E.g 1721 * 299 = 514579
                    }                   
                }
            }

            Console.WriteLine("Day 1 of Advent of Code: Report Repair.\nEnter your expenses so far this Christmas"); //Start of output

            string input = Console.ReadLine();
            listOfInput.Add(input); //Add input to list

            while (!String.IsNullOrEmpty(input))
            {
                input = Console.ReadLine();
                listOfInput.Add(input);
            }

            if (String.IsNullOrEmpty(input))
            {
                for(int i = 0; i < listOfInput.Count - 1; i++)
                {                     
                        listOfExpenses.Add(Int32.Parse(listOfInput[i])); //changing the input from string to int
                }

                Console.Write("The entries that sum up to 2020 are");

                expenseMult(listOfExpenses); //Running the fxn with necessary values (e.g. 1721, 979, 366, 299, 675, 1456)

                Console.WriteLine(" {0} and {1}. \nTheir product is {2}.", entry1, entry2, product); //Results
                Console.ReadKey();

            }    
        }
    }
}
