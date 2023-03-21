using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorythmsAndComplexity
{
    internal class Sorting
    {
        static int Steps = 0;
        public Sorting()
        {
            SortArray(Roads.Road1_256);
            SortArray(Roads.Road1_2048);
            SortArray(Roads.Road2_256);
            SortArray(Roads.Road2_2048);
            SortArray(Roads.Road3_256);
            SortArray(Roads.Road3_2048);

        }
        public void SortArray(Dictionary<string, int[]> Roads)
        {
            int n = Roads["Unsorted"].Length;
            int[] unsortedArray = Roads["Unsorted"];
            
            for (int i = 1; i < n; i++)
            {
                int key = unsortedArray[i];
                int j = i - 1;

                while (j >= 0 && unsortedArray[j] > key)
                {
                    unsortedArray[j + 1] = unsortedArray[j];
                    j = j - 1;
                    Steps++;
                }

                unsortedArray[j + 1] = key;
                Steps++;
            }
            Roads["Ascending"] = unsortedArray;
            Console.WriteLine($"Steps taken to sort the Road{Roads["Identifier"][0]}-{Roads["Identifier"][1]} array using Insertion sort: {Steps}");
            Steps = 0;
        }


    }
}
