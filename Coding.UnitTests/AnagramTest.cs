using Coding.DataStructures.Strings;

namespace Coding.UnitTests;

public class AnagramTest
{
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    [InlineData("a", "ab", false)]
    public void IsValid(string s, string t, bool result)
    {
        Assert.Equal(result, Anagram.IsValid(s, t));
    }
}