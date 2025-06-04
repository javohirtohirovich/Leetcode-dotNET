namespace Leetcode_dotNET;

public class Problem_0205
{
    public bool IsIsomorphic(string s, string t)
    {
        var arr1 = new int[26];
        var arr2 = new int[26];

        foreach(var l in s)
        {
            arr1[l - 'a']++;
        }

        foreach(var l in t)
        {
            arr2[l - 'a']++;
        }

        for(int i = 0; i < 26; i++)
        {

            if(arr1[i] != arr2[i])
            {
                return false;
            }
        }
        return true;
    }
}
