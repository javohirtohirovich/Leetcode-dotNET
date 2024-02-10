namespace Leetcode_dotNET.Sorting;

public class Problem_771
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        int count = 0;
        for (int i = 0; i < jewels.Length; i++)
        {
            for (int j = 0; j < stones.Length; j++)
            {
                if (jewels[i] == stones[j]) { count++; }
            }
        }
        return count;
    }
}
