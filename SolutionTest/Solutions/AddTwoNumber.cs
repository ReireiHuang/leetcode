using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Common;

namespace Leetcode
{
    public class AddTwoNumber
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            List<int> l1list = new List<int>();
            List<int> l2list = new List<int>();

            while (l1.next != null)
            {
                l1list.Add(l1.val);
                l1 = l1.next;
            }
            l1list.Add(l1.val);

            while (l2.next != null)
            {
                l2list.Add(l2.val);
                l2 = l2.next;
            }
            l2list.Add(l2.val);

            if (l1list.Count > l2list.Count)
            {
                List<int> templist = l1list;
                l1list = l2list;
                l2list = templist;
            }

            List<int> resultValues = l1list;
            for(int i = 0;i < l2list.Count;i++)
            {
                if ((resultValues.Count - 1) >= i)
                {
                    int temp = resultValues[i] + l2list[i];
                    if (temp >= 10)
                    {
                        resultValues[i] = temp % 10;
                        if (resultValues.Count > i + 1)
                        {
                            resultValues[i + 1] += 1;
                        }
                        else
                        {
                            resultValues.Add(1);
                        }
                    }
                    else
                    {
                        resultValues[i] = temp;
                    }
                }
                else
                {
                    resultValues.Add(l2list[i]);
                }
            }

            ListNode resultNode = new ListNode(resultValues[0]);
            ListNode tempNode = resultNode;
            for (int i = 1; i <= (resultValues.Count - 1); i++)
            {
                tempNode.next = new ListNode(resultValues[i]);
                tempNode = tempNode.next;
            }
            return resultNode;
        }
    }
}
