namespace Leetcode_dotNET;

public class Problem_26
{
    public int RemoveDuplicates(int[] nums)
    {
        if(nums.Length == 0)
        {
            return 0;
        }
        var k = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] !=nums[k])
            {
                k++;
                nums[k] = nums[i];
            }
        }

        return k + 1;
    }
}
