namespace Leetcode_dotNET.Arrays;

public class Problem_1920
{
    public int[] BuildArray(int[] nums)
    {
        int[] ans = new int[nums.Length];
        for(int i = 0;i < nums.Length; i++)
        {
            ans[i] = nums[nums[i]];
        }
        return ans;
    }
}
