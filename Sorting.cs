using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorythmsAndComplexity
{
    internal class Sorting
    {
        int steps = 0;
        public Sorting()
        {
            // SortArray(Roads.Road1_256, 1);
            // SortArray(Roads.Road1_2048, 1);
            // SortArray(Roads.Road2_256, 1);
            // SortArray(Roads.Road2_2048, 1);
            // SortArray(Roads.Road3_256, 1);
            // SortArray(Roads.Road3_2048, 1);
            // SortArray(Roads.Road4_512, 1);
        }
        public void OutputElements(int[] roads,int[] identifier, int number)
        {
            System.Console.WriteLine($"\nDisplaying every {number}th entry in Road_{identifier[0]}_{identifier[1]} file \n--//////////////////////--");
            for (int i = 0; i < roads.Length; i += 10)
                {
                    System.Console.WriteLine($"{i,3}: {roads[i]}");
                }
            System.Console.WriteLine("--//////////////////////--");
        }

        public void SortArray(Dictionary<string, int[]> roads, int sortMode) // 1 for Insertion sort, 2 for Bubble sort, 3 for Selection sort, 4 for Merge sort
        {
            steps = 0;
            int n = roads["Unsorted"].Length;
            int[] unsortedArray = roads["Unsorted"].ToArray();
            if (sortMode == 1)
            {
                for (int i = 1; i < n; i++)
                {
                    int key = unsortedArray[i];
                    int j = i - 1;

                    while (j >= 0 && unsortedArray[j] > key)
                    {
                        unsortedArray[j + 1] = unsortedArray[j];
                        j = j - 1;
                        steps++;
                    }

                    unsortedArray[j + 1] = key;
                    steps++;
                }
                Console.WriteLine($"steps taken to sort the Road{roads["Identifier"][0]}-{roads["Identifier"][1]} array using Insertion sort: {steps}");
            }
            else if (sortMode == 2)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (unsortedArray[j] > unsortedArray[j + 1])
                        {
                            int temp = unsortedArray[j];
                            unsortedArray[j] = unsortedArray[j + 1];
                            unsortedArray[j + 1] = temp;
                            steps++;
                        }
                    }
                }
                Console.WriteLine($"steps taken to sort the Road{roads["Identifier"][0]}-{roads["Identifier"][1]} array using Bubble sort: {steps}");
            }
            else if (sortMode == 3)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (unsortedArray[j] < unsortedArray[minIndex])
                        {
                            minIndex = j;
                        }
                    }
                    int temp = unsortedArray[minIndex];
                    unsortedArray[minIndex] = unsortedArray[i];
                    unsortedArray[i] = temp;
                    steps++;
                }
                Console.WriteLine($"steps taken to sort the Road{roads["Identifier"][0]}-{roads["Identifier"][1]} array using Selection sort: {steps}");
            }
            else if (sortMode == 4)
            {

            }

            roads["Ascending"] = unsortedArray;
            roads["Descending"] = unsortedArray.Reverse().ToArray();
        }

    }
    
}
