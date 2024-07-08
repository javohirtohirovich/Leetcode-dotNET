namespace Leetcode_dotNET.Array;
public class Problem_2859
{
    public int SumIndicesWithKSetBits(IList<int> nums, int k)
    {
        int result = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            if (ToBinary(i) == k)
            {
                result += nums[i];
            }
        }
        return result;
    }
    public static int ToBinary(int num)
    {
        List<int> list = new List<int>();
        while (num > 0)
        {
            list.Add(num % 2);
            num /= 2;
        }

        Console.WriteLine(list.Count(x => x == 1));
        return list.Count(x => x == 1);
    }
}
