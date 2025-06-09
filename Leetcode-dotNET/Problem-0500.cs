namespace Leetcode_dotNET;

public class Problem_0500
{
    //2-yechim

    public string[] FindWords(string[] words)
    {
        Dictionary<char, int> row = new()
        {
            { 'q', 1 }, { 'w', 1 }, { 'e', 1 }, { 'r', 1 }, { 't', 1 }, { 'y', 1 }, { 'u', 1 }, { 'i', 1 }, { 'o', 1 }, { 'p', 1 },
            { 'Q', 1 }, { 'W', 1 }, { 'E', 1 }, { 'R', 1 }, { 'T', 1 }, { 'Y', 1 }, { 'U', 1 }, { 'I', 1 }, { 'O', 1 }, { 'P', 1 },
            { 'a', 2 }, { 's', 2 }, { 'd', 2 }, { 'f', 2 }, { 'g', 2 }, { 'h', 2 }, { 'j', 2 }, { 'k', 2 }, { 'l', 2 },
            { 'A', 2 }, { 'S', 2 }, { 'D', 2 }, { 'F', 2 }, { 'G', 2 }, { 'H', 2 }, { 'J', 2 }, { 'K', 2 }, { 'L', 2 },
            { 'z', 3 }, { 'x', 3 }, { 'c', 3 }, { 'v', 3 }, { 'b', 3 }, { 'n', 3 }, { 'm', 3 },
            { 'Z', 3 }, { 'X', 3 }, { 'C', 3 }, { 'V', 3 }, { 'B', 3 }, { 'N', 3 }, { 'M', 3 }
        };

        var result = new List<string>();

        foreach (var word in words)
        {
            var res = true;
            var first = row[word[0]];
            for (int i = 1; i < word.Length; i++)
            {
                if (first != row[word[i]])
                {
                    res = false; 
                    break;
                }
            }
            if (res)
            {
                result.Add(word);
            }
        }

        return result.ToArray();
    }

    //1-yechim

    //public string[] FindWords(string[] words)
    //{

    //    if (words.Length == 0)
    //    {
    //        return new string[] { };
    //    }

    //    var firstRow = new char[] { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
    //    var secondRow = new char[] { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
    //    var thirdRow = new char[] { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

    //    var result = new List<string>();

    //    foreach (var word in words)
    //    {
    //        int numberRow = 0;
    //        bool ishora = true;
    //        foreach (var l in word.ToLower())
    //        {
    //            if (firstRow.Contains(l))
    //            {
    //                if (numberRow == 0 || numberRow == 1)
    //                {
    //                    numberRow = 1;

    //                }
    //                else
    //                {
    //                    ishora = false;
    //                    break;
    //                }
    //            }
    //            else if (secondRow.Contains(l))
    //            {
    //                if (numberRow == 0 || numberRow == 2)
    //                {
    //                    numberRow = 2;

    //                }
    //                else
    //                {
    //                    ishora = false;
    //                    break;
    //                }
    //            }
    //            else if (thirdRow.Contains(l))
    //            {

    //                if (numberRow == 0 || numberRow == 3)
    //                {
    //                    numberRow = 3;

    //                }
    //                else
    //                {
    //                    ishora = false;
    //                    break;
    //                }
    //            }
    //        }
    //        if (ishora)
    //        {
    //            result.Add(word);
    //        }
    //    }

    //    return result.ToArray();
    //}
}
