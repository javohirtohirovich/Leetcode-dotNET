namespace Leetcode_dotNET;

public class Problem_0027
{
    public int RemoveElement(int[] nums, int val)
    {
        var newLength = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[newLength] = nums[i];
                newLength++;
            }
        }
        return newLength;
    }
}
