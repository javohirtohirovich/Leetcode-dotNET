namespace Leetcode_dotNET.Arrays;

public class Problem_905
{
    public int[] SortArrayByParity(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i ; j < nums.Length; j++)
            {
                if (nums[i] % 2 != 0 && nums[j] % 2 == 0)
                {
                    int a = nums[i];
                    nums[i] = nums[j];
                    nums[j] = a;
                }
            }
        }
        return nums;
    }


}


