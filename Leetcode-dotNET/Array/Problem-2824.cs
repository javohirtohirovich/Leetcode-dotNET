namespace Leetcode_dotNET.Array;

public class Problem_2824
{
    public int CountPairs(IList<int> nums, int target)
    {
        int result = 0;
        for(int i = 0;i < nums.Count; i++)
        {
            for(int j = i + 1; j < nums.Count; j++)
            {
                if (nums[i] + nums[j] < target)
                {
                    result++;
                }
            }
        }
        return result;
    }
}
