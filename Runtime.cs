﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorythmsAndComplexity
{
    class Runtime : Validation
    {
        // The class constructor method initializes several objects, including the Roads, Sorting, and Search classes.
        // It also initializes two null variables, workingFile and workingFile2.
        // The while loop will continue to execute until the user inputs 0.
        public Runtime()
        {
            Roads roads = new Roads();
            Sorting sorting = new Sorting();
            Search search = new Search();
            Dictionary<string, int[]>? workingFile = null;
            int[]? workingFile2 = null;
            while (true)
            {
                // The user is prompted to select a file to sort.
                // Depending on the user's input, the appropriate file is assigned to the workingFile variable.
                int userInput = GetIntInput("Choose to sort one of the following files:\n[1] Road1-256\n[2] Road1-2048\n[3] Road2-256\n[4] Road2-2048\n[5] Road3-256\n[6] Road3-2048\n[7] Road4-512\n[8] Road4-4096\n[0] Exit",0,8);
                if      (userInput == 1) workingFile = Roads.Road1_256;
                else if (userInput == 2) workingFile = Roads.Road1_2048;
                else if (userInput == 3) workingFile = Roads.Road2_256;
                else if (userInput == 4) workingFile = Roads.Road2_2048;
                else if (userInput == 5) workingFile = Roads.Road3_256;
                else if (userInput == 6) workingFile = Roads.Road3_2048; 
                else if (userInput == 7) workingFile = Roads.Road4_512; 
                else if (userInput == 8) workingFile = Roads.Road4_4096;
                else if (userInput == 0) break;

                // The user is prompted to select a sorting method.
                // Depending on the user's input, the appropriate sorting method is called and applied to the workingFile.
                sorting.SortArray(workingFile, GetIntInput("Choose one of the sorting methods:\n[1] Insertion Sort\n[2] Bubble sort\n[3] Quick Sort\n[4] Merge Sort",1,4));

                // The user is prompted to select whether to show the sorted array in ascending or descending order.
                // Depending on the user's input, the sorted array in the appropriate order is assigned to the workingFile2 variable.
                // The OutputElements method is then called to display the sorted array and its corresponding identifiers.
                userInput = GetIntInput("Show Asceding [1] or Descending [2] order?",1,2);
                if (userInput == 1)
                {
                    workingFile2 = workingFile["Ascending"];
                    sorting.OutputElements(workingFile["Ascending"],workingFile["Identifier"]);
                }
                else if (userInput == 2)
                {
                    workingFile2 = workingFile["Descending"];
                    sorting.OutputElements(workingFile["Descending"],workingFile["Identifier"]);
                }
            }
        }
    }
}