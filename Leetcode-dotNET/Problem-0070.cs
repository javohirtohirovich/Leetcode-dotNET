namespace Leetcode_dotNET;

public class Problem_0070
{
    public int ClimbStairs(int n)
    {
        if(n == 1)
            return 1;
        if(n == 2)
            return 2;

        int a = 1;
        int b = 2;
        for(int i = 3; i <= n; i++)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }

        return b;
    }
}
