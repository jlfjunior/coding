using System.Text.RegularExpressions;

namespace Coding.DataStructures.Strings;

public abstract class Palindrome
{
    public static bool IsValid(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return true;
        
        var x = Regex.Replace(s,"[^a-zA-Z0-9]", "").ToLower();
        var j = x.Length - 1;

        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] != x[j]) return false;
            j--;
        }
            
        return true;
    }
}