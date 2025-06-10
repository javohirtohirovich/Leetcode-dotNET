namespace Leetcode_dotNET;

public class Problem_0541
{
    public string ReverseStr(string s, int k)
    {
        var sLetters = new char[s.Length];
        int j = 0;
        for (int i = k - 1; i >= 0; i--)
        {
            sLetters[j] = s[i];
            j++;
        }

        for(int i= j; i< s.Length; i++)
        {
            sLetters[i] = s[i];
        }

        return new string(sLetters);
    }
}
