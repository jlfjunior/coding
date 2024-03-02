using Coding.DataStructures.Strings;

namespace Coding.UnitTests;

public class PalindromeTest
{
    [Theory]
    [InlineData(" ", true)]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("ace a car", false)]
    public void IsValid(string s, bool result)
    {
        Assert.Equal(result, Palindrome.IsValid(s));
    }
}