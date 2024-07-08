namespace Leetcode_dotNET.Arrays;

public class Problem_3190
{
    public int MinimumOperations(int[] nums)
    {
        var result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 3 != 0)
            {
                result++;
            }
        }
        return result;  
    }
}
