namespace Leetcode_dotNET;

public class Problem_0599
{
    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        var dict1 = new Dictionary<string, int>();
        var result = new List<string>();

        for (int i = 0; i < list1.Length; i++)
        {
            dict1[list1[i]] = i;
        }

        int minIndex = int.MaxValue;

        for (int i = 0; i < list2.Length; i++)
        {
            if (dict1.TryGetValue(list2[i], out int index1))
            {
                int sumIndex = index1 + i;

                if (sumIndex < minIndex)
                {
                    result.Clear();
                    result.Add(list2[i]);
                    minIndex = sumIndex;
                }
                else if (sumIndex == minIndex)
                {
                    result.Add(list2[i]);
                }
            }
        }

        return result.ToArray();
    }

}
