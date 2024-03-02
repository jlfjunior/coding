using Coding.DataStructures.LinkedLists;

namespace Coding.UnitTests;

public class SinglyLinkedListTest
{
    [Theory]
    [InlineData(new int[] { 1 }, 1)]
    [InlineData(new int[] { 1, 2 }, 2)]
    [InlineData(new int[] { 1, 2, 3 }, 3)]
    public void Size(int[] numbers, int sizeExpected)
    {
        var list = new SinglyLinkedList();

        foreach (var number in numbers)
        {
            list.PushOnTail(number);
        }

        Assert.Equal(sizeExpected, list.Size());
    }

    [Theory]
    [InlineData(new int[]{1, 2}, 1)]
    [InlineData(new int[]{1, 1}, 1)]
    [InlineData(new int[]{2, 1}, 2)]
    public void PopOnHead(int[] numbers, int expectedValue)
    {
        var list = new SinglyLinkedList();
        
        foreach (var number in numbers)
        {
            list.PushOnTail(number);    
        }

        var value = list.PopOnHead();
        
        Assert.Equal(expectedValue, value);
    }
    
    [Theory]
    [InlineData(new int[]{1}, 1)]
    [InlineData(new int[]{1, 2}, 2)]
    [InlineData(new int[]{1, 2, 3}, 3)]
    public void PopOnTail(int[] numbers, int expectedValue)
    {
        var list = new SinglyLinkedList();
        
        foreach (var number in numbers)
        {
            list.PushOnTail(number);    
        }

        var value = list.PopOnTail();
        
        Assert.Equal(expectedValue, value);
    }
    
    [Theory]
    [InlineData(new int[]{3, 2, 1}, 1)]
    [InlineData(new int[]{3, 2, 1, 4}, 4)]
    public void GetTail(int[] numbers, int result)
    {
        var list = new SinglyLinkedList();
        
        foreach (var number in numbers)
        {
            list.PushOnTail(number);    
        }
        
        Assert.Equal(result, list.GetTail());
    }
    
    [Theory]
    [InlineData(new int[]{1}, 0, 1)]
    [InlineData(new int[]{3, 2, 1, 4},3, 4)]
    [InlineData(new int[]{3, 2, 1, 4},1, 2)]
    public void ValueAt(int[] numbers, int index,int result)
    {
        var list = new SinglyLinkedList();
        
        foreach (var number in numbers)
        {
            list.PushOnTail(number);    
        }
        
        Assert.Equal(result, list.ValueAt(index));
    }
    
    [Theory]
    [InlineData(new int[]{1}, 0, 2, 2)]
    [InlineData(new int[]{3, 2, 1, 4},1, 4, 5)]
    [InlineData(new int[]{},0, 2, 1)]
    public void InsertAt(int[] numbers, int index, int value,int sizeExpected)
    {
        var list = new SinglyLinkedList();
        
        foreach (var number in numbers)
        {
            list.PushOnTail(number);    
        }

        list.InsertAt(index, value);
        
        Assert.Equal(sizeExpected, list.Size());
    }

    [Fact]
    public void Reverse()
    {
        var list = new SinglyLinkedList();
        list.PushOnTail(8);
        list.PushOnTail(3);
        list.PushOnTail(7);
        list.PushOnTail(1);
        
        list.Reverse();
        
        Assert.Equal(1, list.GetHead());
        Assert.Equal(8, list.GetTail());
    }
}