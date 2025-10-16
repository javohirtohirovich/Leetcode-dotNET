namespace Leetcode_dotNET;

public class Problem_0069
{

    //new solution use binary solution

    public int MySqrt(int x)
    {
        if (x < 2) return x;

        var l = 1;
        var r = x / 2;

        while (l <= r)
        {
            long mid = (l + r) / 2;
            long sq = mid * mid;

            if (sq == x)
            {
                return (int)mid;
            }
            else if (sq < x)
            {
                l = (int)mid + 1;
            }
            else
            {
                r = (int)mid - 1;
            }
        }

        return r;
    }

    // old solution use linear search
    //public int MySqrt(int x)
    //{
    //    if (x == 0 || x == 1)
    //        return x;
    //    for (int i = 1; i <=x; i++)
    //    {
    //        if ((long)i * i == x)
    //            return i;
    //        if ((long)i * i > x)
    //            return i - 1;
    //    }

    //    return -1;
    //}
}
