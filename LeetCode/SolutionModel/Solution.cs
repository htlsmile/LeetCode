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
    public class Solution
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

        /// <summary>
        /// 方法名
        /// </summary>
        public string MainFuncName { get; set; }

        private Solution() { }

        public Solution(int id)
        {
            ProblemID = id;
            string solutionID = ProblemID.ToString().PadLeft(3, '0');
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..\\");
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] fileInfoArray = directoryInfo.GetFiles(solutionID + "*.dll", SearchOption.AllDirectories);
            if (fileInfoArray.Length < 1)
            {
                throw new ArgumentException($"未找到{solutionID}的解决方案！");
            }
            Assembly assembly = Assembly.LoadFrom(fileInfoArray[0].FullName);
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                if (type.Name == "Testcase")
                {
                    dynamic testcase = type.Assembly.CreateInstance(type.FullName);
                    MainFuncName = testcase.MainFuncName;
                }

            }
        }

        public bool Run()
        {
            return true;
        }
    }
}
