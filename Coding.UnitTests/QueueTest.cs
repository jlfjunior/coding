using Coding.DataStructures.Queues;

namespace Coding.UnitTests;

public class QueueTest
{
    [Fact]
    public void Push()
    {
        var queue = new Queue();
        
        queue.Push(1);
        
        Assert.Equal(1, queue.Peek());
    }
    
    [Fact]
    public void Pop()
    {
        var queue = new Queue();
        
        queue.Push(1);
        queue.Push(2);

        queue.Pop();
        
        Assert.Equal(2, queue.Peek());
    }
    
    [Fact]
    public void Peek()
    {
        var queue = new Queue();
        
        queue.Push(1);
        queue.Push(2);
        queue.Push(3);

        queue.Pop();
        
        queue.Push(4);
        queue.Push(5);

        queue.Pop();
        
        Assert.Equal(3, queue.Peek());
    }
    
    [Fact]
    public void Empty()
    {
        var queue = new Queue();
        
        Assert.True(queue.Empty());
        queue.Push(1);
        
        Assert.False(queue.Empty());
        
        queue.Pop();
        
        Assert.True(queue.Empty());
    }
}