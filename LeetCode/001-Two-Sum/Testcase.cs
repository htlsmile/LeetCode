using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Two_Sum
{
    public class CaseModel
    {
        public int[] Result { get; set; }
        public int[] nums { get; set; }
        public int target { get; set; }
    }

    public class Testcase
    {
        public string MainFuncName { get; set; }
        public List<CaseModel> TestcaseList { get; set; }
        private CaseModel caseModel;

        public Testcase()
        {
            MainFuncName = nameof(Solution.TwoSum);
            TestcaseList = new List<CaseModel>();

            caseModel = new CaseModel();
            caseModel.Result = new int[] { 0, 1 };
            caseModel.nums = new int[] { 2, 7, 11, 15 };
            caseModel.target = 9;
            TestcaseList.Add(caseModel);
        }
    }
}
