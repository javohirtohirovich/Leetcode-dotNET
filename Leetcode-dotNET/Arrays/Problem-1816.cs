namespace Leetcode_dotNET.Arrays;

public class Problem_1816
{
    public string TruncateSentence(string s, int k)
    {
        string result = "";
        int i = 0;
        int n = 0;
        while (i<s.Length) 
        {
            if (s[i]==' ')
            {
                n++;
                if (n == k) { break; }
            }
            result += s[i];
            i++;
        }
        return result;
    }
}
