using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AlgorythmsAndComplexity
{
    internal class Roads
    {
        // Define dictionaries to hold various road data
        static public Dictionary<string, int[]> Road1_256 = new Dictionary<string, int[]>()
        {
            {"Unsorted", new int[256]},        // 256 element array for unsorted
            {"Ascending", new int[256]},       // 256 element array for sorted in ascending order
            {"Descending", new int[256]},      // 256 element array for sorted in descending order
            {"Identifier", new int[]{1, 256}}  // Array to hold the road identifier and size (1, 256)
        };
        // Simmilar dictonaries for other files
        static public Dictionary<string, int[]> Road1_2048 = new Dictionary<string, int[]>()
        {
            {"Unsorted", new int[2048]},
            {"Ascending", new int[2048]},
            {"Descending", new int[2048]},
            {"Identifier", new int[]{1, 2048}}
        };
        static public Dictionary<string, int[]> Road2_256 = new Dictionary<string, int[]>()
        {
            {"Unsorted", new int[256]},
            {"Ascending", new int[256]},
            {"Descending", new int[256]},
            {"Identifier", new int[]{2, 256}}
        };
        static public Dictionary<string, int[]> Road2_2048 = new Dictionary<string, int[]>()
        {
            {"Unsorted", new int[2048]},       
            {"Ascending", new int[2048]},
            {"Descending", new int[2048]},
            {"Identifier", new int[]{2, 2048}}
        };
        static public Dictionary<string, int[]> Road3_256 = new Dictionary<string, int[]>()
        {
            {"Unsorted", new int[256]},
            {"Ascending", new int[256]},
            {"Descending", new int[256]},            
            {"Identifier", new int[]{3, 256}}
        };
        static public Dictionary<string, int[]> Road3_2048 = new Dictionary<string, int[]>()
        {
            {"Unsorted", new int[2048]},
            {"Ascending", new int[2048]},
            {"Descending", new int[2048]},
            {"Identifier", new int[]{3, 2048}}

        };
        static public Dictionary<string, int[]> Road4_512 = new Dictionary<string, int[]>()
        {
            {"Unsorted", new int[512]},
            {"Ascending", new int[512]},
            {"Descending", new int[512]},
            {"Identifier", new int[]{4, 512}}

        };

        static public Dictionary<string, int[]> Road4_4096 = new Dictionary<string, int[]>()
        {
            {"Unsorted", new int[4096]},
            {"Ascending", new int[4096]},
            {"Descending", new int[4096]},
            {"Identifier", new int[]{4, 4096}}
        };

        public Roads()
        {
            // Initialize unsorted arrays by reading data from text files
            Road1_256["Unsorted"] = CreateArray("Road_1_256.txt", 256);
            Road1_2048["Unsorted"] = CreateArray("Road_1_2048.txt", 2048);
            Road2_256["Unsorted"] = CreateArray("Road_2_256.txt", 256);
            Road2_2048["Unsorted"] = CreateArray("Road_2_2048.txt", 2048);
            Road3_256["Unsorted"] = CreateArray("Road_3_256.txt", 256);
            Road3_2048["Unsorted"] = CreateArray("Road_3_2048.txt", 2048);
            Road4_512["Unsorted"] = Road1_256["Unsorted"].Concat(Road3_256["Unsorted"]).ToArray();
            Road4_4096["Unsorted"] = Road2_2048["Unsorted"].Concat(Road3_2048["Unsorted"]).ToArray();
        }
        // Method to create an array from a given file path and size
        private int[] CreateArray(string filePath, int size)
        {
            string[] lines = File.ReadAllLines(filePath);

            int[] numbersArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                if (int.TryParse(lines[i], out int number))
                {
                    numbersArray[i] = number;
                }
                else
                {
                    Console.WriteLine($"Unable to parse '{lines[i]}' as an integer.");
                }
            }

            return numbersArray;
        }
    }
}