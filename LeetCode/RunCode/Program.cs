﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionModel;
using System.Collections;

namespace RunCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int ProblemID = 1;
            SolutionTest solution = new SolutionTest(ProblemID);
            solution.Run();
        }
    }
}
