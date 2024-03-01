namespace Coding.DataStructures.Strings;

public abstract class Anagram
{
    public static bool IsValid(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var dict = new Dictionary<char, int>();

        foreach (var letter in s)
        {
            if (dict.ContainsKey(letter))
                dict[letter]++;
            else
                dict[letter] = 1;
        }

        foreach (var letter in t)
        {
            if (!dict.ContainsKey(letter) || dict[letter] == 0) return false;

            dict[letter]--;
        }

        return true;
    }
}