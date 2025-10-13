namespace Leetcode_dotNET;

public class Problem_0944
{
    public int MinDeletionSize(string[] strs)
    {
        var notSortedColumsCount = 0;

        for(int i = 0; i < strs[0].Length; i++)
        {
            for(int j = 1; j<strs.Length; j++)
            {
                if (strs[j][i] < strs[j - 1][i])
                {
                    notSortedColumsCount++;
                    break;
                }
            }
        }

        return notSortedColumsCount;
    }
}
