namespace Leetcode_dotNET.Array;

public class Problem_682
{
    public int CalPoints(string[] operations)
    {
        List<int> points = new List<int>();
        for (int i = 0; i < operations.Length; i++)
        {
            if (operations[i] == "D")
            {
                points.Add( points[points.Count-1]*2) ;
            }
            else if (operations[i] == "C")
            {
                points.Remove(points[points.Count - 1]);
            }
            else if (operations[i] == "+") 
            {
                if (points.Count >= 2)
                {
                    points.Add(points[points.Count - 2] + points[points.Count-1]);
                }
            }
            else
            {
                points.Add(int.Parse(operations[i]));
            }

        }
        return points.Sum();
    }
   
    
}
