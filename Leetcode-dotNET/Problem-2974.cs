namespace Leetcode_dotNET;

public class Problem_2974
{
    public int[] NumberGame(int[] nums)
    {
        Array.Sort(nums);

        for(int i = 0; i < nums.Length; i += 2)
        {
            int j = nums[i];
            nums[i] = nums[i+1];
            nums[i+1] = j;
        }

        return nums;
    }
}
