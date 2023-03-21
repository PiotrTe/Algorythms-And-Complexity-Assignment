using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AlgorythmsAndComplexity
{
    internal class Roads
    {        
        static private int[] Road1_256_Unsorted = new int[256];
        static private int[] Road1_2048_Unsorted = new int[2048];
        static private int[] Road2_256_Unsorted = new int[256];
        static private int[] Road2_2048_Unsorted = new int[2048];
        static private int[] Road3_256_Unsorted = new int[256];
        static private int[] Road3_2048_Unsorted = new int[2048];
        
        static public Dictionary<string, int[]> Road1_256 = new Dictionary<string, int[]>()
        {
            {"Unsorted", Road1_256_Unsorted},
            {"Ascending", new int[256]},
            {"Descending", new int[256]},
            {"Identifier", new int[]{1, 256}}
        };
        static public Dictionary<string, int[]> Road1_2048 = new Dictionary<string, int[]>()
        {
            {"Unsorted", Road1_2048_Unsorted},
            {"Ascending", new int[2048]},
            {"Descending", new int[2048]},
            {"Identifier", new int[]{1, 2048}}
        };
        static public Dictionary<string, int[]> Road2_256 = new Dictionary<string, int[]>()
        {
            {"Unsorted", Road2_256_Unsorted},
            {"Ascending", new int[256]},
            {"Descending", new int[256]},
            {"Identifier", new int[]{2, 256}}
        };
        static public Dictionary<string, int[]> Road2_2048 = new Dictionary<string, int[]>()
        {
            {"Unsorted", Road2_2048_Unsorted},       
            {"Ascending", new int[2048]},
            {"Descending", new int[2048]},
            {"Identifier", new int[]{2, 2048}}
        };
        static public Dictionary<string, int[]> Road3_256 = new Dictionary<string, int[]>()
        {
            {"Unsorted", Road3_256_Unsorted},
            {"Ascending", new int[256]},
            {"Descending", new int[256]},            
            {"Identifier", new int[]{3, 256}}
        };
        static public Dictionary<string, int[]> Road3_2048 = new Dictionary<string, int[]>()
        {
            {"Unsorted", Road3_2048_Unsorted},
            {"Ascending", new int[2048]},
            {"Descending", new int[2048]},
            {"Identifier", new int[]{3, 2048}}

        };
        static public Dictionary<string, int[]> Road4_512 = new Dictionary<string, int[]>()
        {
            {"Unsorted", Road1_256_Unsorted.Concat(Road3_256_Unsorted).ToArray()},
            {"Ascending", new int[2048]},
            {"Descending", new int[2048]},
            {"Identifier", new int[]{3, 2048}}

        };
        public Roads()
        {
            Road1_256["Unsorted"] = CreateArray("Road_1_256.txt", 256);
            Road1_2048["Unsorted"] = CreateArray("Road_1_2048.txt", 2048);
            Road2_256["Unsorted"] = CreateArray("Road_2_256.txt", 256);
            Road2_2048["Unsorted"] = CreateArray("Road_2_2048.txt", 2048);
            Road3_256["Unsorted"] = CreateArray("Road_3_256.txt", 256);
            Road3_2048["Unsorted"] = CreateArray("Road_3_2048.txt", 2048);
        }
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