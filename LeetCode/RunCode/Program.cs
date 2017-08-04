using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RunCode
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("问题编号\t测试结果");
                Console.WriteLine(new string('-', 40));
                List<int> ProblemIDList = new List<int>()
                {
                    1, 2
                };

                for (int i = 0; i < ProblemIDList.Count; i++)
                {
                    int ProblemID = ProblemIDList[i];
                    SolutionTest solution = new SolutionTest(ProblemID);
                    var result = solution.Run();
                    if (result)
                    {
                        Console.WriteLine($"{ProblemID}\t\t通过");
                    }
                    else
                    {
                        Console.WriteLine($"{ProblemID}\t\t失败");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"异常：{ex.Message}");
            }
            finally
            {
                Console.ReadKey(true);
            }
        }
    }
}
