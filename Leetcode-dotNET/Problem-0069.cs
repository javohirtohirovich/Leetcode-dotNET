namespace Leetcode_dotNET;

public class Problem_0069
{
    public int MySqrt(int x)
    {
        if (x == 0 || x == 1)
            return x;
        for (int i = 1; i <=x; i++)
        {
            if ((long)i * i == x)
                return i;
            if ((long)i * i > x)
                return i - 1;
        }

        return -1;
    }
}
