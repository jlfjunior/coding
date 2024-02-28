using Coding.DataStructures.Arrays;

namespace Coding.UnitTests;

public class TwoSumTest
{
    [Theory]
    [InlineData(new int[] {2,7,11,15}, 9, new int[] {0, 1})]
    [InlineData(new int[] {3, 2, 4}, 6, new int[] {1, 2})]
    [InlineData(new int[] {3, 3}, 6, new int[] {0, 1})]
    public void Execute(int[] numbers, int target, int[] expected)
    {
        var result = TwoSum.Execute(numbers, target);
        
        Assert.Equal(expected, result);
    }
}