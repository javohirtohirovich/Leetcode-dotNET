namespace Leetcode_dotNET.Arrays;

public class Problem_3194
{
    public double MinimumAverage(int[] nums)
    {
        double[] averageArr = new double[nums.Length/2];
        Array.Sort(nums);
        for(int i = 0; i < nums.Length/2; i++)
        {
            averageArr[i] = (nums[i] + nums[nums.Length-(i+1)])/2.0;
        }
        return averageArr.Min();
    }
}
