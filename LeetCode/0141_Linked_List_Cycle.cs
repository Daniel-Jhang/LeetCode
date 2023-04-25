using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // Given head, the head of a linked list, determine if the linked list has a cycle in it.
    // There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer.
    // Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.
    // Return true if there is a cycle in the linked list.Otherwise, return false.

    // Example 1:
    // Input: head = [3,2,0,-4], pos = 1
    // Output: true
    // Explanation: There is a cycle in the linked list, where the tail connects to the 1st node(0-indexed).

    // Example 2:
    // Input: head = [1,2], pos = 0
    // Output: true
    // Explanation: There is a cycle in the linked list, where the tail connects to the 0th node.

    // Example 3:
    // Input: head = [1], pos = -1
    // Output: false
    // Explanation: There is no cycle in the linked list.
    #endregion
    internal class _0141_Linked_List_Cycle
    {
        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
        public bool HasCycle_V1(ListNode head)
        {
            HashSet<ListNode> list = new HashSet<ListNode>();
            while (head != null)
            {
                if (list.Contains(head))
                {
                    return true;
                }
                else
                {
                    list.Add(head);
                }
                head = head.next;
            }
            return false;
        }

        public bool HasCycle_V2(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
