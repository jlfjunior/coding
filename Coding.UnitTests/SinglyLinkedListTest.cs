using Coding.DataStructures.LinkedLists;

namespace Coding.UnitTests;

public class SinglyLinkedListTest
{
    [Theory]
    [InlineData(new int[]{1}, 1)]
    [InlineData(new int[]{1, 2}, 2)]
    [InlineData(new int[]{1, 2, 3}, 3)]
    public void Size(int[] numbers, int sizeExpected)
    {
        var list = new SinglyLinkedList();
        
        foreach (var number in numbers)
        {
            list.PushOnTail(number);    
        }
        
        Assert.Equal(sizeExpected, list.Size());
    }
}