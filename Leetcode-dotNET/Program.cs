using Leetcode_dotNET;
using Leetcode_dotNET.Arrays;

class Program
{
    public static void Main(string[] args)
    {
        var problem = new Problem_0599();
        Console.WriteLine(problem.FindRestaurant(new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" }, new string[] { "KFC", "Shogun", "Burger King" }));
    }
}