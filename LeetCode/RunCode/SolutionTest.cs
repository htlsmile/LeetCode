using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RunCode
{
    public class SolutionTest
    {
        private const string Testcase = nameof(Testcase);

        private dynamic instance;
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
                                 where t.Name == Testcase
                                 select t).FirstOrDefault();
            instance = Activator.CreateInstance(TestcaseType);
        }

        public bool Run()
        {
            return instance.RunTest();
        }
    }
}
