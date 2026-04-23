namespace Leetcode_dotNET;

public class Problem_0234
{
    public bool IsPalindrome(ListNode head)
    {
        var fast = head;
        var slow = head;
        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode perv = null;
        while(slow != null)
        {
            var temp = slow.next;
            slow.next = perv;
            perv = slow;
            slow = temp;
        }

        var result = true;
        while(perv != null)
        {
            if (perv.val != head.val)
            {
                result = false;
                break;
            }
            perv = perv.next;
            head = head.next;
        }
        return result;
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
