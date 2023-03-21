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
        public void OutputElements(int[] roads,int[] identifier, int number)
        {
            System.Console.WriteLine($"\nDisplaying every {number}th entry in Road_{identifier[0]}_{identifier[1]} array \n--//////////////////////--");
            for (int i = 0; i < roads.Length; i += 10)
                {
                    System.Console.WriteLine($"{i / number,3}: {roads[i]}");
                }
            System.Console.WriteLine("--//////////////////////--");
        }

        public void SortArray(Dictionary<string, int[]> roads)
        {
            int n = roads["Unsorted"].Length;
            int[] unsortedArray = roads["Unsorted"];

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
            roads["Ascending"] = unsortedArray;
            roads["Descending"] = unsortedArray.Reverse().ToArray();
            Console.WriteLine($"Steps taken to sort the Road{roads["Identifier"][0]}-{roads["Identifier"][1]} array using Insertion sort: {Steps}");
            Steps = 0;
        }


    }
}
