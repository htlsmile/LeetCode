using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionModel;

namespace RunCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int ProblemID = 1;
            Solution solution = new Solution(ProblemID);
            solution.Run();
        }
    }
}
