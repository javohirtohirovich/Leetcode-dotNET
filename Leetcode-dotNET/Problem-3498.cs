namespace Leetcode_dotNET;

public class Problem_3498
{
    public int ReverseDegree(string s)
    {
        int sum = 0;
        var index = 1;
        foreach (char c in s)
        {
            sum += (27 - (c - 'a' + 1)) * index;

            index++;
        }

        return sum;
    }
}
