using System.Collections.Generic;

namespace _002_Add_Two_Numbers
{
    public class CaseModel
    {
        public ListNode Result;
        public ListNode l1;
        public ListNode l2;
    }

    public class Testcase
    {
        private CaseModel caseModel;
        private List<CaseModel> testcaseList = new List<CaseModel>();

        public Testcase()
        {
            #region case
            caseModel = new CaseModel();
            caseModel.Result = CreateListNodes(7, 0, 8);
            caseModel.l1 = CreateListNodes(2, 4, 3);
            caseModel.l2 = CreateListNodes(5, 6, 4);
            testcaseList.Add(caseModel);
            #endregion

            #region case
            caseModel = new CaseModel();
            caseModel.Result = CreateListNodes(1, 8);
            caseModel.l1 = CreateListNodes(1, 8);
            caseModel.l2 = CreateListNodes(0);
            testcaseList.Add(caseModel);
            #endregion

            #region case
            caseModel = new CaseModel();
            caseModel.Result = CreateListNodes(0, 1);
            caseModel.l1 = CreateListNodes(5);
            caseModel.l2 = CreateListNodes(5);
            testcaseList.Add(caseModel);
            #endregion

            #region case
            caseModel = new CaseModel();
            caseModel.Result = CreateListNodes(0, 0, 1);
            caseModel.l1 = CreateListNodes(9, 9);
            caseModel.l2 = CreateListNodes(1);
            testcaseList.Add(caseModel);
            #endregion
        }

        public bool RunTest()
        {
            Solution solution = new Solution();
            foreach (var testcase in testcaseList)
            {
                var expect = testcase.Result;
                var actual = solution.AddTwoNumbers(testcase.l1, testcase.l2);
                do
                {
                    if (expect.val != actual.val)
                    {
                        return false;
                    }
                    expect = expect.next;
                    actual = actual.next;
                } while (expect != null && actual != null);
                if (expect != null || actual != null)
                {
                    return false;
                }
            }
            return true;
        }

        private static ListNode CreateListNodes(params int[] nums)
        {
            ListNode lastNode = null;
            ListNode currentNode = null;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                currentNode = new ListNode(nums[i]);
                currentNode.next = lastNode;
                lastNode = currentNode;
            }
            return currentNode;
        }
    }
}
