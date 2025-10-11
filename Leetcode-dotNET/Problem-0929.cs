namespace Leetcode_dotNET;

public class Problem_0929
{

    public int NumUniqueEmails(string[] emails)
    {
        var result = new HashSet<string>();
        foreach (var email in emails)
        {
            var domainIndex = email.IndexOf('@');
            var plusIndex = email.IndexOf('+');

            var localName = "";
            if (plusIndex == -1)
            {
                localName = email.Substring(0, domainIndex).Replace(".", "");
            }
            else
            {
                localName = email.Substring(0, plusIndex).Replace(".", "");
            }

            var domainName = email.Substring(domainIndex);

            result.Add(localName +domainName);
        }

        return result.Count;
    }

    // solution 1 - 20 ms Beats 9.87%

    /*public int NumUniqueEmails(string[] emails)
    {
        var result = new HashSet<string>();
        foreach (var email in emails)
        {
            result.Add(ClearEmail(email));
        }

        return result.Count;
    }

    public string ClearEmail(string email)
    {
        var result = "";
        var f = true;
        var a = false;

        foreach (var i in email)
        {
            
            if (i == '.' && !a )
            {
                continue;
            }
            else if (i == '+'&&!a)
            {
                f = false;
            }
            else if (i == '@')
            {
                result += i;
                f = true;
                a = true;
            }
            else if (f)
            {
                result += i;
            }
        }

        return result;
    }*/
}
