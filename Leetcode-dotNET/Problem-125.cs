namespace Leetcode_dotNET;

public class Problem_125
{
    public bool IsPalindrome(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return true;
        }
        string filtered = string.Empty;
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetterOrDigit(s[i]))
            {
                filtered += char.ToLower(s[i]);
            }
        }
        if (string.IsNullOrEmpty(filtered) || filtered.Length == 1)
        {
            return true;
        }
        char[] chars = filtered.ToCharArray();
        Array.Reverse(chars);
        if (filtered == new string(chars))
        {
            return true;
        }
        return false;
    }
}
