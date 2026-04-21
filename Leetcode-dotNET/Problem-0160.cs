namespace Leetcode_dotNET;

public class Problem_0160
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var pA = headA;
        var pB = headB;
        while (pA != pB)
        {
            if (pA == null)
            {
                pA = headB;
            }
            else
            {
                pA = pA.next;
            }
            if (pB == null)
            {
                pB = headA;
            }
            else
            {
                pB = pB.next;
            }
        }
        return pA;
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

}
