using Coding.Algorithms.Searching;

namespace Coding.UnitTests;

public class BinarySearchTest
{
     [Theory]
     [InlineData(new int[] { }, 1, -1)]
     [InlineData(new int[] { 1 }, 2, -1)]
     [InlineData(new int[] { -1,0,3,5,9,12 }, 9, 4)]
     [InlineData(new int[] { -1,0,3,5,9,12 }, 2, -1)]
     public void Search(int[] elements, int target, int result)
     {
          Assert.Equal(result, BinarySearch.Search(elements, target));    
     }
}