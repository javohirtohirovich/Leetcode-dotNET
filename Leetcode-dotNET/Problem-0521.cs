namespace Leetcode_dotNET;

public class Problem_0521
{
    public int FindLUSlength(string a, string b)
    {
        if (a == b) return -1;
        if (a.Length > b.Length)
        {
            return a.Length;
        }
        return b.Length;
    }
}
