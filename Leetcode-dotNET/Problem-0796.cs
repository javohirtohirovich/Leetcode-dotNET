namespace Leetcode_dotNET;

public class Problem_0796
{
    public bool RotateString(string s, string goal)
    {
        if (s.Length != goal.Length) return false;
        else if (s == goal) return true;

        int i = 0;
        while (i < goal.Length)
        {
            s = s.Substring(1) + s[0];
            if (s == goal) return true;
            i++;
        }

        return false;
    }
}
