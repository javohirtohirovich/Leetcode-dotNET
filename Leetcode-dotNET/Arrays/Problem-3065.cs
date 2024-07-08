namespace Leetcode_dotNET.Arrays;

public class Problem_3065
{
    public int MinOperations(int[] nums, int k)
    {
        Array.Sort(nums);
        int result = nums.Count(x => x < k);
        return result;
    }
}
