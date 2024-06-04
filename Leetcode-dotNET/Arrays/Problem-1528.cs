using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_dotNET.Arrays;

public class Problem_1528
{
    //1-Method
   /* public string RestoreString(string s, int[] indices)
    {
        var dict= new Dictionary<int,char>();
        for(int i = 0; i < indices.Length; i++)
        {
            dict[indices[i]] = s[i];
        }
        dict = dict.OrderBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);

        var output = "";
        foreach(int i in dict.Keys)
        {
            output += dict[i];
        }
        return output;
    }*/


    //2-Method
    public string RestoreString(string s, int[] indices)
    {
        char[] result = new char[s.Length];

        for (int i = 0; i < indices.Length; i++)
        {
            result[indices[i]] = s[i];
        }
        return new string(result);
    }
}
