namespace Leetcode_dotNET.Arrays;
public class Problem_1480
{
    public int[] RunningSum(int[] nums)
    {
        int[] result= new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            int s = 0;
            for(int j = 0; j <= i; j++)
            {
                s += nums[j];
            }
            result[i] = s;
        }
        return result;
    }

}
