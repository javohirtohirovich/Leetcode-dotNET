namespace Leetcode_dotNET.Sorting;

public class Problem_1108
{
    //1-Method
    /*public string DefangIPaddr(string address)
    {
        string result = "";
        for(int i = 0;i<address.Length;i++)
        {
            if (address[i] == '.')
            {
                result += "[.]";
            }
            else
            {
                result += address[i];
            }
        }
        return result;
    }*/

    //2-Method
    public string DefangIPaddr(string address)
    {
        address = address.Replace(".", "[.]");
        return address;
    }
    

}
