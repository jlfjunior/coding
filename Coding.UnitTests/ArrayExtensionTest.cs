using Coding.DataStructures.Arrays;

namespace Coding.UnitTests;

public class ArrayExtensionTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 1 }, true)]
    [InlineData(new int[] { 1,2,3,4 }, false)]
    [InlineData(new int[] { 1,1,1,3,3,4,3,2,4,2 }, true)]
    public void ContainsDuplicate_ShouldBeTrue(int[] numbers, bool result)
    {
        Assert.Equal(result, ArrayExtension.ContainsDuplicate(numbers));
    }
}