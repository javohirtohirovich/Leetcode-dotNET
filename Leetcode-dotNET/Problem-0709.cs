namespace Leetcode_dotNET;

public class Problem_0709
{
    public string ToLowerCase(string s)
    {
        var res = "";
        foreach (char c in s)
        {
            if (c > 96 || !char.IsLetter(c))
            {
                res += c;
            }
            else
            {
                res += (char)(c + 32);
            }
        }

        return res;
    }
}
