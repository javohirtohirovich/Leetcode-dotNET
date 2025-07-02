using Leetcode_dotNET;
using Leetcode_dotNET.Arrays;

class Program
{
    public static void Main(string[] args)
    {
        var problem = new Problem_0819();
        Console.WriteLine(problem.MostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.", new string[] { "hit" }));
    }
}