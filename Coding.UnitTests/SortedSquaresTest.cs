using Coding.DataStructures.Arrays;

namespace Coding.UnitTests;

public class SortedSquaresTest
{
    [Theory]
    [InlineData(new int[] { -4, -1, 0, 3, 10 }, new int[] { 0, 1, 9, 16, 100 })]
    [InlineData(new int[] { -7, -3, 2, 3, 11 }, new int[] { 4, 9, 9, 49, 121 })]
    public void SortedSquares(int[] numbers, int[] expected)
    {
        var result = ArrayExtension.SortedSquares(numbers);

        Assert.Equal(expected, result);
    }
}