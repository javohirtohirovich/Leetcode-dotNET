namespace Leetcode_dotNET;

public class Problem_0831
{
    public IList<IList<int>> LargeGroupPositions(string s)
    {
        var result = new List<IList<int>>();

        var counter = 1;
        var letter = s[0];
        for (int i = 1; i < s.Length; i++)
        {
            if (letter == s[i])
            {
                counter++;
                letter = s[i];
            }
            else
            {
                if (counter > 2)
                {
                    result.Add(new List<int>() { i - counter, i-1 });
                }
                letter = s[i];
                counter = 1;
            }
        }

        if (counter > 2)
        {
            result.Add(new List<int>() { s.Length - counter, s.Length - 1 });
        }

        return result;
    }
}
