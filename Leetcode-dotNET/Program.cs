using Leetcode_dotNET;
using Leetcode_dotNET.Arrays;

class Program
{
    public static void Main(string[] args)
    {
        var problem = new Problem_0929();
        Console.WriteLine(problem.NumUniqueEmails(
            new string[] {
               "a@e+c.com", "a@e+c+f.com"
            }
        ));
    }
}