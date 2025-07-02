namespace Leetcode_dotNET;

public class Problem_0806
{
    public int[] NumberOfLines(int[] widths, string s)
    {
        var lines = 1;
        int sum = 0;
        foreach (char c in s)
        {
            int width = widths[c - 'a'];
            sum += width;
            if (sum > 100)
            {
                lines++;
                sum = width;
            }

        }

        return new int[] { lines, sum };
    }
}
