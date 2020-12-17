using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCodeCS
{
    class Day1
    {
        static void Main(string[] args)
        {
            List<int> listOfExpenses = new List<int>();
            List<String> listOfInput = new List<string>(); 
            int product = 0;
            int entry1;
            int entry2 = 0;
           
            int expenseMult(List<int> entries)
            {
                entry1 = entries[0];

                for(int i = 1; i < entries.Count; i++)
                {
                    int addition = entry1 + entries[i];

                    if(addition == 2020)
                    {
                        entry2 = entries[i];
                        product = entry1 * entry2;
                        return product;
                    }                   
                }

                return 0;
            }

            Console.WriteLine("Day 1 of Advent of Code: Report Repair.\nEnter your expenses so far this Christmas");

            string input = Console.ReadLine();
            listOfInput.Add(input);

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
                expenseMult(listOfExpenses);
                Console.WriteLine(" {0} and {1}. \n Their product is {2}.", entry1, entry2, product);
                Console.ReadKey();
            }
           


            



        }
    }
}
