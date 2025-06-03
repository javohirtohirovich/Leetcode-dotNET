namespace Leetcode_dotNET;

public class Problem_412
{
    public IList<string> FizzBuzz(int n)
    {
        IList<string> result = new List<string>();

        result.Add("1");
        if(n == 1)
        {
            return result;
        }

        result.Add("2");
        if (n == 2)
        {
            return result;
        }
        for (int i = 3; i <= n; i++)
        {
            if(i%3==0 && i % 5 == 0)
            {
                result.Add("FizzBuzz");
            }
            else if(i % 3 == 0)
            {
                result.Add("Fizz");
            }
            else if(i % 5 == 0)
            {
                result.Add("Buzz");
            }
            else
            {
                result.Add(i.ToString());
            }
        }

        return result;
    }
}
