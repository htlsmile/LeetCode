using System.Collections.Generic;

namespace _001_Two_Sum
{
    public class CaseModel
    {
        public int[] Result;
        public int[] nums;
        public int target;
    }

    public class Testcase
    {
        private CaseModel caseModel;
        private List<CaseModel> testcaseList = new List<CaseModel>();

        public Testcase()
        {
            #region case
            caseModel = new CaseModel();
            caseModel.Result = new int[] { 0, 1 };
            caseModel.nums = new int[] { 2, 7, 11, 15 };
            caseModel.target = 9;
            testcaseList.Add(caseModel);
            #endregion

            #region case
            caseModel = new CaseModel();
            caseModel.Result = new int[] { 28, 45 };
            caseModel.nums = new int[] { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 };
            caseModel.target = 542;
            testcaseList.Add(caseModel);
            #endregion

            #region case
            caseModel = new CaseModel();
            caseModel.Result = new int[] { 8010, 8011 };
            caseModel.nums = new int[12598];
            for (int i = 0; i < caseModel.nums.Length; i++)
            {
                caseModel.nums[i] = i * 2;
            }
            caseModel.nums[8011] = 1;
            caseModel.target = 16021;
            testcaseList.Add(caseModel);

            #endregion
        }

        public bool RunTest()
        {
            Solution solution = new Solution();
            foreach (var testcase in testcaseList)
            {
                var expect = testcase.Result;
                var actual = solution.TwoSum(testcase.nums, testcase.target);
                if (expect.Length != actual.Length)
                {
                    return false;
                }
                else
                {
                    for (int i = 0; i < expect.Length; i++)
                    {
                        if (expect[i] != actual[i])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
