using Coding.DataStructures.Strings;

namespace Coding.UnitTests;

public class ValidParenthesesTest
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("{[]}", true)]
    [InlineData("(]", false)]
    [InlineData("]", false)]
    public void Execute(string text, bool expected)
    {
        var x = ValidParentheses.IsValid(text);
        
        Assert.Equal(expected, x);
    }
}