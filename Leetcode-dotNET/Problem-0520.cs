namespace Leetcode_dotNET;

public class Problem_0520
{
    public bool DetectCapitalUse(string word)
    {
        var uppersSum = 0;
        var lowerSum = 0;

        foreach (var letter in word)
        {
            if (char.IsLower(letter))
            {
                lowerSum++;
            }
            else
            {
                uppersSum++;
            }
        }

        if (uppersSum == 0 || lowerSum == 0)
        {
            return true;
        }

        if (uppersSum == 1)
        {
            if (char.IsUpper(word[0]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}
