namespace Leetcode_dotNET;

public class Problem_0392
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0)
        {
            return true;
        }
        var count = 0;
       
        for(var i = 0;i<t.Length;i++)
        {
            
            if (s[count] == t[i])
            {
                if (count == s.Length-1)
                {
                    return true;
                }
                count++;
            }
           
        }

        return false;
    }
}
