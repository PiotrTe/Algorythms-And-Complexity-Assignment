using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AlgorythmsAndComplexity
{
    internal class Roads
    {
        static public int[] Road1_256 = new int[256];
        static public int[] Road1_2048 = new int[2048];
        static public int[] Road2_256 = new int[256];
        static public int[] Road2_2048 = new int[2048];
        static public int[] Road3_256 = new int[256];
        static public int[] Road3_2048 = new int[2048];

        static public int[] Road1_256_Reversed = new int[256];
        static public int[] Road1_2048_Reversed = new int[2048];
        static public int[] Road2_256_Reversed = new int[256];
        static public int[] Road2_2048_Reversed = new int[2048];
        static public int[] Road3_256_Reversed = new int[256];
        static public int[] Road3_2048_Reversed = new int[2048];



        public Roads()
        {
            Road1_256 = CreateArray("Road_1_256.txt", 256);
            Road1_2048 = CreateArray("Road_1_2048.txt", 2048);
            Road2_256 = CreateArray("Road_2_256.txt", 256);
            Road2_2048 = CreateArray("Road_2_2048.txt", 2048);
            Road3_256 = CreateArray("Road_3_256.txt", 256);
            Road3_2048 = CreateArray("Road_3_2048.txt", 2048);
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