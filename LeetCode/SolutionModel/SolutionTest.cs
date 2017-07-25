using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SolutionModel
{
    public class SolutionTest
    {
        private BaseTestcase Testcase;
        private object Solution;
        private MethodInfo methodInfo;

        private SolutionTest() { }

        public SolutionTest(int ProblemID)
        {
            if (ProblemID < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            string solutionID = ProblemID.ToString().PadLeft(3, '0');
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..\\");
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] fileInfoArray = directoryInfo.GetFiles($"{solutionID}*.dll", SearchOption.AllDirectories);
            if (fileInfoArray.Length < 1)
            {
                throw new ArgumentException($"未找到{solutionID}的解决方案！");
            }
            Assembly assembly = Assembly.LoadFrom(fileInfoArray[0].FullName);
            Type[] types = assembly.GetTypes();
            Type TestcaseType = (from t in types
                                 where t.Name == nameof(Testcase)
                                 select t).FirstOrDefault();
            Testcase = Activator.CreateInstance(TestcaseType) as BaseTestcase;
            Type SolutionType = (from t in types
                                 where t.Name == nameof(Solution)
                                 select t).FirstOrDefault();
            Solution = Activator.CreateInstance(SolutionType);
            methodInfo = SolutionType.GetMethod(Testcase.MainFuncName);
        }

        public bool Run()
        {
            if (methodInfo == null)
            {
                throw new ArgumentNullException();
            }
            foreach (var testcase in Testcase.TestcaseList)
            {
                object methodResult = methodInfo.Invoke(Solution, testcase.Parameters);
                if (!ResultEquals(methodResult, testcase.Result))
                {
                    return false;
                }
            }
            return true;
        }

        private bool ResultEquals(object obj1, object obj2)
        {
            string str1 = Convert.ToString(obj1);
            string str2 = Convert.ToString(obj2);
            if (string.IsNullOrWhiteSpace(str1))
            {
                return false;
            }
            else if (string.IsNullOrWhiteSpace(str2))
            {
                return false;
            }
            else if (str1 != str2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
