using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorythmsAndComplexity
{
    class Runtime : Validation
    {
        public Runtime()
        {
            Roads roads = new Roads();
            Sorting sorting = new Sorting();
            while (true)
            {
                int userInput = GetIntInput("Choose to sort one of the following files:\n[1] Road1-256\n[2] Road1-2048\n[3] Road2-256\n[4] Road2-2048\n[5] Road3-256\n[6] Road3-2048\n[7] Road4-512\n[0] Exit",1,6);
                if (userInput == 1)
                {
                    sorting.SortArray(Roads.Road1_256, GetIntInput("Choose one of the sorting methods:\n[1] Insertion Sort\n[2] Bubble sort\n[3] Selection Sort\n[4] Merge Sort",1,4));
                    sorting.OutputElements(Roads.Road1_256["Unsorted"],Roads.Road1_256["Identifier"], 10);
                }
                else if (userInput == 2)
                {
                    sorting.SortArray(Roads.Road1_2048, GetIntInput("Choose one of the sorting methods:\n[1] Insertion Sort\n[2] Bubble sort\n[3] Selection Sort\n[4] Merge Sort",1,4));
                    sorting.OutputElements(Roads.Road1_2048["Ascending"],Roads.Road1_2048["Identifier"], 50);
                }
                else if (userInput == 3)
                {
                    sorting.SortArray(Roads.Road2_256, GetIntInput("Choose one of the sorting methods:\n[1] Insertion Sort\n[2] Bubble sort\n[3] Selection Sort\n[4] Merge Sort",1,4));
                    sorting.OutputElements(Roads.Road2_256["Ascending"],Roads.Road2_256["Identifier"], 10);
                }
                else if (userInput == 4)
                {
                    sorting.SortArray(Roads.Road2_2048, GetIntInput("Choose one of the sorting methods:\n[1] Insertion Sort\n[2] Bubble sort\n[3] Selection Sort\n[4] Merge Sort",1,4));
                    sorting.OutputElements(Roads.Road2_2048["Ascending"],Roads.Road2_2048["Identifier"], 50);
                }
                else if (userInput == 5)
                {
                    sorting.SortArray(Roads.Road3_256, GetIntInput("Choose one of the sorting methods:\n[1] Insertion Sort\n[2] Bubble sort\n[3] Selection Sort\n[4] Merge Sort",1,4));
                    sorting.OutputElements(Roads.Road3_256["Ascending"],Roads.Road3_256["Identifier"], 10);
                }
                else if (userInput == 6)
                {
                    sorting.SortArray(Roads.Road3_2048, GetIntInput("Choose one of the sorting methods:\n[1] Insertion Sort\n[2] Bubble sort\n[3] Selection Sort\n[4] Merge Sort",1,4));
                    sorting.OutputElements(Roads.Road3_2048["Ascending"],Roads.Road3_2048["Identifier"], 50);
                }   
                else if (userInput == 7)
                {
                    sorting.SortArray(Roads.Road4_512, GetIntInput("Choose one of the sorting methods:\n[1] Insertion Sort\n[2] Bubble sort\n[3] Selection Sort\n[4] Merge Sort",1,4));
                    sorting.OutputElements(Roads.Road4_512["Ascending"],Roads.Road4_512["Identifier"], 10);
                }   
                else if (userInput == 0)
                {
                    break;
                }

            }
        }
    }
}
