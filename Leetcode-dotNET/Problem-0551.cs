namespace Leetcode_dotNET;

public class Problem_0551
{
    public bool CheckRecord(string s)
    {
        var a = 0;
        var l = 0;
        for (var i = 0; i < s.Length; i++)
        {

            if (s[i] == 'A')
            {
                a++;
                l = 0;
            }
            else if (s[i] == 'L')
            {
                l++;
            }
            else { l = 0; }

            if (a == 2 || l == 3)
            {
                return false;
            }

        }
        return true;
    }

}
