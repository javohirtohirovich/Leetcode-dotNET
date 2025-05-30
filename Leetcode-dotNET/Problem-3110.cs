namespace Leetcode_dotNET;

public class Problem_3110
{
    public int ScoreOfString(string s)
    {
        int score = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            score += Math.Abs((int)s[i] - (int)s[i + 1]);
        }
        return score;
    }
}
