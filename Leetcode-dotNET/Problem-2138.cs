namespace Leetcode_dotNET;

public class Problem_2138
{
    public string[] DivideString(string s, int k, char fill)
    {
        int n = s.Length % k;
        if (n != 0)
        {
            for (int i = 0; i < k - n; i++) 
            { 
                s += fill; 
            }
        }

        List<string> parts = new List<string>();

        for (int i = 0; i < s.Length; i += k)
        {
            parts.Add(s.Substring(i, k));
        }
        return parts.ToArray();
    }
}
