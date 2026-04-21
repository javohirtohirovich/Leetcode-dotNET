namespace Leetcode_dotNET;

public class Problem_0203
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        if (head == null)
        {
            return head;
        }

        while (head != null && head.val == val)
        {
            head = head.next;
        }
        var current = head;
        while (current != null && current.next != null)
        {
            if (current.next.val == val)
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

}