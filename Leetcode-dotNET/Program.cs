using Leetcode_dotNET;
using Leetcode_dotNET.Arrays;

class Program
{
    public static void Main(string[] args)
    {
        var problem = new Problem_0748();
        Console.WriteLine(problem.ShortestCompletingWord("1s3 PSt", new string[] { "step", "steps", "stripe", "stepple" }));
    }
}