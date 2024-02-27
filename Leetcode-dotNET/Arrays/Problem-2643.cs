namespace Leetcode_dotNET.Arrays;

public class Problem_2643
{
    public int[] RowAndMaximumOnes(int[][] mat)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < mat.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < mat[i].Length; j++)
            {
                if (mat[i][j] == 1) { count++; }
            }
            if(result.Count>0 && result[1]<count)
            {
                result[0] = i;
                result[1] = count;
            }
            else if(result.Count==0)
            {
                result.Add(i);
                result.Add(count);
            }
        }
        return result.ToArray();

    }

}
