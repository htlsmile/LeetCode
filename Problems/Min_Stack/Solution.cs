using System;
using System.Collections.Generic;
using System.Text;

namespace Min_Stack
{
    public class MinStack
    {
        Stack<long> stack;
        long min;

        /** initialize your data structure here. */
        public MinStack()
        {
            stack = new Stack<long>();
        }

        public void Push(int x)
        {
            if (stack.Count == 0)
            {
                stack.Push(0L);
                min = x;
            }
            else
            {
                stack.Push(x - min);
                if (min > x)
                {
                    min = x;
                }
            }
        }

        public void Pop()
        {
            stack.TryPop(out long top);
            if (top < 0L)
            {
                min -= top;
            }
        }

        public int Top()
        {
            if (stack.Peek() <= 0L)
            {
                return (int)min;
            }
            return (int)(stack.Peek() + min);
        }

        public int GetMin()
        {
            return (int)min;
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(x);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
}
