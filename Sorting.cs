using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorythmsAndComplexity
{
    internal class Sorting
    {
        static private int Steps = 0;
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
            for (int i = 0; i < roads.Length; i += number)
                {
                    System.Console.WriteLine($"{i,3}: {roads[i]}");
                }
            System.Console.WriteLine("--//////////////////////--");
        }

        public void SortArray(Dictionary<string, int[]> roads, int sortMode) // 1 for Insertion sort, 2 for Bubble sort, 3 for Selection sort, 4 for Merge sort
        {
            Steps = 0;
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
                        Steps++;
                    }

                    unsortedArray[j + 1] = key;
                    Steps++;
                }
                Console.WriteLine($"Steps taken to sort the Road{roads["Identifier"][0]}-{roads["Identifier"][1]} array using Insertion sort: {Steps}");
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
                            Steps++;
                        }
                    }
                }
                Console.WriteLine($"Steps taken to sort the Road{roads["Identifier"][0]}-{roads["Identifier"][1]} array using Bubble sort: {Steps}");
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
                    Steps++;
                }
                Console.WriteLine($"Steps taken to sort the Road{roads["Identifier"][0]}-{roads["Identifier"][1]} array using Selection sort: {Steps}");
            }
            else if (sortMode == 4)
            {
                MergeSort(unsortedArray, 0, unsortedArray.Length - 1);
                Console.WriteLine($"Steps taken to sort the Road{roads["Identifier"][0]}-{roads["Identifier"][1]} array using Merge sort: {Steps}");
            }

            roads["Ascending"] = unsortedArray;
            roads["Descending"] = unsortedArray.Reverse().ToArray();
        }
    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        int i, j, k;

        for (i = 0; i < n1; i++)
            L[i] = arr[left + i];
        for (j = 0; j < n2; j++)
            R[j] = arr[mid + 1 + j];

        i = 0;
        j = 0;
        k = left;

        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
            Steps++;
        }

        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
            Steps++;
        }

        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
            Steps++;
        }
    }
    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            Merge(arr, left, mid, right);
        }
    }


    }
    
}
