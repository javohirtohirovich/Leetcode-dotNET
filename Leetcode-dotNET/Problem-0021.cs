﻿using System.Security;

namespace Leetcode_dotNET;

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
public class Problem_0021
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null)
        {
            return list2;
        }
        else if (list2 == null)
        {
            return list1;
        }

        ListNode head = new ListNode(0);
        ListNode current = head;
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;

        }

        if (list1 != null)
        {
            current.next = list1;
        }
        else
        {
            current.next = list2;
        }

        return head.next;
    }
}
