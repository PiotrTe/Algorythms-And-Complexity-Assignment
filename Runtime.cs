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
            //int userInput = GetIntInput("Choose to sort one of the following files:\n[1] Road1-256\n[2] Road1-2048\n[3] Road2-256\n[4] Road2-2048\n[5] Road3-256\n[6] Road3-2048\n[7] Road4-512\n[0] Exit",1,6);
            sorting.OutputElements(Roads.Road4_512["Ascending"],Roads.Road4_512["Identifier"],10);

            }

        }
    }
}
