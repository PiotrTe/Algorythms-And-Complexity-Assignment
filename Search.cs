using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorythmsAndComplexity
{
    class Search
    {
        static public int Steps = 0;
        public static Dictionary<int, int> LinearSearch(int[] array, int target)
        {
            Steps = 0;
            int n = array.Length;
            Dictionary<int,int> positions = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (array[i] == target)
                    positions.Add(i,target);
                    Steps++;
            }
            int targetL = target;
            int targetR = target;
            if (positions.Count == 0){
                System.Console.WriteLine($"\nValue {target} not found... Looking for closest values");
                while (positions.Count == 0)
                {
                    targetL --;
                    targetR ++;
                    for (int i = 0; i < n; i++)
                    {
                        if (array[i] == targetL)
                            positions.Add(i,targetL);
                            Steps++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        if (array[i] == targetR)
                            positions.Add(i, targetR);
                            Steps++;
                    }
                }
            }
            System.Console.WriteLine($"\nLinear Search completed in {Steps} Steps");    
            return positions;

        }

        public static Dictionary<int,int> BinarySearch(int[] array, int target)
        {
            Dictionary<int,int> result = new Dictionary<int,int>();
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                Steps++;
                int mid = left + (right - left) / 2;
                if (array[mid] == target)
                {
                    result.Add(mid,target);
                    // search for other occurrences on the left side
                    int i = mid - 1;
                    while (i >= 0 && array[i] == target)
                    {
                        result.Add(i,target);
                        i--;
                        Steps++;
                    }
                    // search for other occurrences on the right side
                    i = mid + 1;
                    while (i < array.Length && array[i] == target)
                    {
                        result.Add(i,target);
                        i++;
                        Steps++;
                    }
                    break;
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            if (result.Count == 0)
            {
                // find closest values
                int targetL = target - 1;
                int targetR = target + 1;

                while (result.Count == 0 && (targetL >= array[0] || targetR <= array[array.Length - 1]))
                {
                    Steps++;

                    // search for closest value on the left side
                    if(targetL >= array[0])
                    {
                        var resL=BinarySearch(array, targetL);
                        foreach(var item in resL){
                            result.Add(item.Key,item.Value);
                        }
                    }

                    // search for closest value on the right side
                    if(targetR <= array[array.Length - 1])
                    {
                        var resR=BinarySearch(array, targetR);
                        foreach(var item in resR){
                            result.Add(item.Key,item.Value);
                        }
                    }

                    // update targets for next iteration
                    targetL--;
                    targetR++;
                }
            }
            return result;
        }
    }
}