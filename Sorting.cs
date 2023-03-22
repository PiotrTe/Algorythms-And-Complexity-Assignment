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
        public void OutputElements(int[] roads,int[] identifier)
        {
            int number = 0;
            if (roads.Length > 1000) number = 50;
            else number = 10;
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
            int[] unsortedArray = roads["Unsorted"].ToArray();
            if (sortMode == 1)
            {
                InsertionSort(unsortedArray);
                Console.WriteLine($"Steps taken to sort the Road{roads["Identifier"][0]}-{roads["Identifier"][1]} array using Insertion sort: {Steps}");
            }
            else if (sortMode == 2)
            {
                BubbleSort(unsortedArray);
                Console.WriteLine($"Steps taken to sort the Road{roads["Identifier"][0]}-{roads["Identifier"][1]} array using Bubble sort: {Steps}");
            }
            else if (sortMode == 3)
            {
                QuickSort(unsortedArray, 0, unsortedArray.Length - 1);
                Console.WriteLine($"Steps taken to sort the Road{roads["Identifier"][0]}-{roads["Identifier"][1]} array using Quick sort: {Steps}");
            }
            else if (sortMode == 4)
            {
                MergeSort(unsortedArray, 0, unsortedArray.Length - 1);
                Console.WriteLine($"Steps taken to sort the Road{roads["Identifier"][0]}-{roads["Identifier"][1]} array using Merge sort: {Steps}");
            }

            roads["Ascending"] = unsortedArray;
            roads["Descending"] = unsortedArray.Reverse().ToArray();
        }
    static void InsertionSort(int[] array)
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
    }
    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        Steps++;
                    }
                }
            }
    }
    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);

            Merge(array, left, mid, right);
        }
    }
    private static void Merge(int[] array, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        int i, j, k;

        for (i = 0; i < n1; i++)
            L[i] = array[left + i];
        for (j = 0; j < n2; j++)
            R[j] = array[mid + 1 + j];

        i = 0;
        j = 0;
        k = left;

        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                array[k] = L[i];
                i++;
            }
            else
            {
                array[k] = R[j];
                j++;
            }
            k++;
            Steps++;
        }

        while (i < n1)
        {
            array[k] = L[i];
            i++;
            k++;
            Steps++;
        }

        while (j < n2)
        {
            array[k] = R[j];
            j++;
            k++;
            Steps++;
        }
    }
    static void QuickSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(array, left, right);

            if (pivot > left)
                QuickSort(array, left, pivot - 1);

            if (pivot < right)
                QuickSort(array, pivot + 1, right);
        }
    }
    private static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                Steps++;
            }
        }
        int temp2 = array[i + 1];
        array[i + 1] = array[right];
        array[right] = temp2;
        Steps++;
        return i + 1;
    }
    
    }
    
}
