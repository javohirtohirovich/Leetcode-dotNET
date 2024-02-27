namespace Leetcode_dotNET.Arrays;

public class Problem_2089
{
    public IList<int> TargetIndices(int[] nums, int target)
    {
        Array.Sort(nums);
        IList<int> result = new List<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target) { result.Add(i);}
        }
        return result;
    }
}
