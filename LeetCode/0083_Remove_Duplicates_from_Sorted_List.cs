using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // Given the head of a sorted linked list, delete all duplicates such that each element appears only once.
    // Return the linked list sorted as well.

    // Example 1:
    // Input: head = [1,1,2]
    // Output: [1,2]

    // Example 2:
    // Input: head = [1,1,2,3,3]
    // Output: [1,2,3]
    #endregion
    public class _0083_Remove_Duplicates_from_Sorted_List
    {
        // Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode current = head;
            while (current != null && current.next != null)
            {
                if (current.val == current.next.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
            return head;
        }
    }
}
