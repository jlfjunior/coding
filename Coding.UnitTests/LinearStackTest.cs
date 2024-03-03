using Coding.DataStructures.Stacks;

namespace Coding.UnitTests;

public class LinearStackTest
{
    [Fact]
    public void IsFull_ShouldBeTrue()
    {
        var stack = new LinearStack(1);

        stack.Push(1);
        
        Assert.True(stack.IsFull());
    }
    
    [Fact]
    public void IsFull_ShouldBeFalse()
    {
        var stack = new LinearStack(1);

        Assert.False(stack.IsFull());
    }
    
    [Fact]
    public void Push()
    {
        var stack = new LinearStack(1);

        stack.Push(1);
        
        Assert.Equal(1, stack.Pop());
    }
    
    [Fact]
    public void Pop()
    {
        var stack = new LinearStack(2);

        stack.Push(1);
        stack.Push(2);

        var lastIn = stack.Pop();
        Assert.Equal(2, lastIn);
        
        lastIn = stack.Pop();
        Assert.Equal(1, lastIn);
    }
}