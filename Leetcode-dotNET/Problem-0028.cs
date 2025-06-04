namespace Leetcode_dotNET;

public class Problem_0028
{
    public int StrStr(string haystack, string needle)
    {
        if (string.IsNullOrEmpty(needle))
        {
            return 0;
        }
        if (haystack.Length < needle.Length)
        {
            return -1;
        }
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                if (haystack.Length - i < needle.Length)
                {
                    return -1;
                }
                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }
        }

        return -1;

    }
}
