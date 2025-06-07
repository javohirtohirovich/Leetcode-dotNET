namespace Leetcode_dotNET;

public class Problem_0434
{
    public int CountSegments(string s)
    {
        int count = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if ((i == 0 && !char.IsWhiteSpace(s[i])) ||
                (i > 0 && char.IsWhiteSpace(s[i - 1]) && !char.IsWhiteSpace(s[i])))
            {
                count++;
            }
        }

        return count;
    }

}
