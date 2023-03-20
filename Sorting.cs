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
            SortArray(Roads.Road1_256, nameof(Roads.Road1_256));
            SortArray(Roads.Road1_2048, nameof(Roads.Road1_2048));
            SortArray(Roads.Road2_256, nameof(Roads.Road2_256));
            SortArray(Roads.Road2_2048, nameof(Roads.Road2_2048));
            SortArray(Roads.Road3_256, nameof(Roads.Road3_256));
            SortArray(Roads.Road3_2048, nameof(Roads.Road3_2048));
        }
        public void SortArray(int[] array, string arrayName)
        {
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                    Steps++;
                }

                array[j + 1] = key;
                Steps++;
            }


            Console.WriteLine($"Steps taken to sort the {arrayName} array using Insertion sort: {Steps}");
            Steps = 0;
        }


    }
}
