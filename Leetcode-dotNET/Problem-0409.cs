namespace Leetcode_dotNET;

public class Problem_0409
{
    public int LongestPalindrome(string s)
    {
        var lowerCaseCount = new int[26];
        var upperCaseCount = new int[26];
        foreach (var letter in s)
        {
            if (char.IsLower(letter))
            {
                lowerCaseCount[letter - 'a']++;
            }
            else if(char.IsUpper(letter))
            {
                upperCaseCount[letter - 'A']++;
            }
        }

        var toqCount = 0;
        for (int i=0;i<26;i++)
        {
            if (lowerCaseCount[i] > 0)
            {
                if (lowerCaseCount[i] % 2 == 1)
                {
                    toqCount++;
                }
                
            }
            if (upperCaseCount[i] > 0)
            {
                if (upperCaseCount[i] % 2 == 1)
                {
                    toqCount++;
                }

            }
        }

        if(toqCount > 0)
        {
            return s.Length-toqCount+1;
        }
        else
        {
            return s.Length;
        }
    }
}
