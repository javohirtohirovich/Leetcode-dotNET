namespace Leetcode_dotNET.Arrays;

public class Problem_2418
{
    public string[] SortPeople(string[] names, int[] heights)
    {
        var dict = new Dictionary< int,string>();
        for(int i  = 0; i < names.Length; i++)
        {
            dict[heights[i]] = names[i];
        }

        heights=heights.OrderByDescending(h => h).ToArray();

        var result =new string[heights.Length];
        for(int i = 0; i < heights.Length; i++)
        {
            result[i] = dict[heights[i]];
        }

        return result;
    }
}
