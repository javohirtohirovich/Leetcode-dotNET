namespace Leetcode_dotNET;

public class Problem_0459
{
    public bool RepeatedSubstringPattern(string s)
    {
        for (int i = 1; i <= s.Length / 2; i++)
        {
            if (s.Length % i == 0)
            { 
                string part = s.Substring(0, i);
                string repeated = string.Concat(Enumerable.Repeat(part, s.Length / i));

                if (repeated == s)
                {
                    return true;
                }
            }
        }

        return false;
    }
}
