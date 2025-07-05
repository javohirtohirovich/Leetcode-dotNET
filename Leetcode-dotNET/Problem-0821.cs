namespace Leetcode_dotNET;

public class Problem_0821
{
    public int[] ShortestToChar(string s, char c)
    {
        var indexes = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == c)
            {
                indexes.Add(i);
            }
        }

        var result = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            var minIndex = int.MaxValue;
            foreach (int j in indexes)
            {
                if (Math.Abs(i - j) < minIndex)
                {
                    minIndex = Math.Abs(i - j);
                }

            }
            result[i] = minIndex;
        }

        return result;
    }
}