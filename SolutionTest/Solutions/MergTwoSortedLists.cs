using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Common;

namespace Solutions
{
    class _MergTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
                return null;
            ListNode result = new ListNode();
            ListNode pointer = result;
            while (!((l1 == null) && (l2 == null)))
            {

                if (l1 == null)
                {
                    AddlListNode(ref l2, ref pointer);
                    if (l2 != null)
                        pointer.next = new ListNode();
                    pointer = pointer.next;
                    continue;
                }
                if (l2 == null)
                {
                    AddlListNode(ref l1, ref pointer);
                    if (l1 != null)
                        pointer.next = new ListNode();
                    pointer = pointer.next;
                    continue;
                }
                if (l1.val <= l2.val)
                {
                    pointer.next = new ListNode();
                    AddlListNode(ref l1, ref pointer);
                    pointer = pointer.next;
                    continue;
                }
                AddlListNode(ref l2, ref pointer);
                pointer.next = new ListNode();
                pointer = pointer.next;
            }
            return result;
        }

        private void AddlListNode(ref ListNode listnode,ref ListNode pointer) {
            pointer.val = listnode.val;
            listnode = listnode.next;
        }
    }
}
