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
        private int _problemID;
        /// <summary>
        /// 问题编号
        /// </summary>
        public int ProblemID
        {
            get
            {
                return _problemID;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _problemID = value;
            }
        }

        private dynamic Testcase;
        private dynamic CaseModel;
        private object Solution;
        private MethodInfo methodInfo;

        private SolutionTest() { }

        public SolutionTest(int id)
        {
            ProblemID = id;
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
            foreach (Type type in types)
            {
                if (type.Name == nameof(CaseModel))
                {
                    CaseModel = Activator.CreateInstance(type);
                    break;
                }
            }
            foreach (Type type in types)
            {
                if (type.Name == nameof(Testcase))
                {
                    Testcase = Activator.CreateInstance(type);
                    break;
                }
            }
            foreach (Type type in types)
            {
                if (type.Name == nameof(Solution))
                {
                    Solution = Activator.CreateInstance(type);
                    methodInfo = type.GetMethod(Testcase.MainFuncName);
                    break;
                }
            }
        }

        public bool Run()
        {
            var testResult = true;
            if (methodInfo == null)
            {
                throw new ArgumentNullException();
            }
            foreach (var testcase in Testcase.TestcaseList)
            {
                object methodResult = methodInfo.Invoke(Solution, testcase.Parameters);
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Stream stream1 = new MemoryStream();
                formatter.Serialize(stream1, methodResult);
                Stream stream2 = new MemoryStream();
                formatter.Serialize(stream2, testcase.Result);
                if (stream1 == stream2)
                {
                    //TODO 如何比较两个是否相等
                    testResult = true;
                }
                else
                {
                    testResult = false;
                    break;
                }
            }
            return testResult;
        }
    }
}
