namespace Leetcode_dotNET;

public class Problem_0953
{
    public bool IsAlienSorted(string[] words, string order)
    {
        var s = words[0];
        for (int i = 1; i < words.Length; i++)
        {
            var r = 0;
            if (s.Length < words[i].Length)
            {
                r = s.Length;
            }
            else
            {
                r = words[i].Length;
            }
            for (int j = 0; j < r; j++)
            {
                if (order.IndexOf(s[j]) > order.IndexOf(words[i][j]))
                {
                    return false;
                }
                else if (order.IndexOf(s[j]) < order.IndexOf(words[i][j]))
                {
                    break;
                }
                if(j == r - 1 && s.Length > words[i].Length)
                {
                    return false;
                }
               
            }
            s = words[i];
        }

        return true;
    }
}
