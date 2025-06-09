namespace Leetcode_dotNET;

public class Problem_0500
{
    public string[] FindWords(string[] words)
    {

        if (words.Length == 0)
        {
            return new string[] { };
        }

        var firstRow = new char[] { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
        var secondRow = new char[] { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
        var thirdRow = new char[] { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

        var result = new List<string>();

        foreach (var word in words)
        {
            int numberRow = 0;
            bool ishora = true;
            foreach (var l in word.ToLower())
            {
                if (firstRow.Contains(l))
                {
                    if (numberRow == 0 || numberRow == 1)
                    {
                        numberRow = 1;

                    }
                    else
                    {
                        ishora = false;
                        break;
                    }
                }
                else if (secondRow.Contains(l))
                {
                    if (numberRow == 0 || numberRow == 2)
                    {
                        numberRow = 2;

                    }
                    else
                    {
                        ishora = false;
                        break;
                    }
                }
                else if (thirdRow.Contains(l))
                {

                    if (numberRow == 0 || numberRow == 3)
                    {
                        numberRow = 3;

                    }
                    else
                    {
                        ishora = false;
                        break;
                    }
                }
            }
            if (ishora)
            {
                result.Add(word);
            }
        }

        return result.ToArray();
    }
}
