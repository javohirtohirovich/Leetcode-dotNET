namespace Leetcode_dotNET;

public class Problem_0389
{
    public char FindTheDifference(string s, string t)
    {
        int[] letters = new int[26];

        foreach (char l in s)
        {
            letters[l - 'a']++;
        }

        foreach (char l in t)
        {
            letters[l - 'a']--;
            if (letters[l - 'a'] < 0)
            {
                return l;
            }
        }
        
        return ' ';
    }
}
