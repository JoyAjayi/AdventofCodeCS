using System;
using System.Collections.Generic;

namespace AdventofCodeCS
{
    class Day1
    {
        static void Main(string[] args)
        {
            List<int> listOfExpenses = new List<int>()/*{1714,1960,1256,1597,1853,1609,1936,2003,1648,1903,1248,1525,1330,1281,1573,1892,1563,1500,1858,176,1802,1370,1708,1453,1342,1830,1580,1607,1848,1626,1602,1919,1640,1574,1414,766,1581,1924,1727,1949,1406,323,957,1862,1354,1427,1583,1067,1863,1553,1923,1990,691,1372,1357,1887,1485,1799,1270,1743,1601,1457,1723,1888,1272,1600,1880,1381,1413,1452,277,1866,1542,1693,1760,1637,1675,1975,1304,1327,1985,1842,1255,1915,1266,1944,1824,1770,1392,1259,1313,1547,1293,1393,1896,1828,1642,1979,1871,1502,1548,1508,710,1786,1845,1334,1362,1940,2009,1271,1448,1964,1676,1654,1804,1835,1910,1939,1298,1572,1704,1841,1399,1576,1164,1868,1035,262,1569,1639,1669,1543,1616,1658,1750,1765,1718,1861,1351,1531,1665,1771,1348,1289,875,1408,1486,1275,1625,1594,1816,704,1800,1564,1291,1234,19812006,1916,1411,1539,1963,1874,1898,1951,,1366,1912,1369,1478,1359,1859,1421,1384,1534,1283,1913,1794,1494,1860,1312,1869,1730,1510,1319,1428,1706,1432,153}*/ ; //list of converted input

            List<String> listOfInput = new List<string>(); //List of string inputs
            int entry1Two = 0;
            int entry2Two = 0;
            int entry1Three = 0;
            int entry2Three = 0;
            int entry3 = 0;
            int productTwo = 0;
            int productThree = 0;

            void expenseMult(List<int> entries) /* Fxn used to compute the report*/
            {
               //for two entries
                for (int i = 0; i < entries.Count - 1; i++)
                    {
                        entry1Two = entries[i]; ///Picks one number

                        for (int j = 1; j < entries.Count; j++)
                        {
                            int addition = entry1Two + entries[j]; //J changes as the loop goes through the list to find a match

                            if (addition == 2020)
                            {
                                entry2Two = entries[j]; //This is what entries[i] should be added to
                                productTwo = entry1Two * entry2Two; //The product E.g 1721 * 299 = 514579

                            }
                        }
                    }

                //for three entries
                for (int i = 0; i < entries.Count - 2; i++)
                {
                    entry1Three = entries[i]; //Picks one number

                    for (int j = 1; j < entries.Count - 1; j++)
                    {
                        entry2Three = entries[j]; // Picks second number

                        for (int k = 2; k < entries.Count; k++)
                        {
                            int addition = entry1Three + entry2Three + entries[k]; //J changes as the loop goes through the list to find a match

                            if (addition == 2020)
                            {
                                entry3 = entries[k]; //This is what entries[i] should be added to
                                productThree = entry1Three * entry2Three * entry3; //The product E.g 1721 * 299 = 514579

                            }
                        }
                    }
                }
            }

            Console.WriteLine("Day 1 of Advent of Code: Report Repair.\nEnter your expenses so far this Christmas"); //Start of output

            string input = Console.ReadLine();
            listOfInput.Add(input); //Add input to list

            while (!String.IsNullOrEmpty(input))
            {
                input = Console.ReadLine();
                listOfInput.Add(input); //Adding input to a list  of strings
            }

            if (String.IsNullOrEmpty(input))
            {
                for (int i = 0; i < listOfInput.Count - 1; i++)
                {
                    listOfExpenses.Add(Int32.Parse(listOfInput[i])); //changing the input from string to int
                }

                expenseMult(listOfExpenses); //Running the fxn with necessary values (e.g. 1721, 979, 366, 299, 675, 1456)

                Console.Write("The two entries that sum up to 2020 are");
                Console.WriteLine(" {0} and {1}. \nTheir product is {2}.", entry1Two, entry2Two, productTwo); //Results

                Console.Write("The three entries that sum up to 2020 are");
                Console.WriteLine(" {0}, {1} and {2}. \nTheir product is {3}.", entry1Three, entry2Three, entry3, productThree); //Results
                Console.ReadKey();

            }    
        }
    }
}
