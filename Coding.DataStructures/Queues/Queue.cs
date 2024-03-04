namespace Coding.DataStructures.Queues;

public class Queue
{
    private Stack<int> _writer = new();
    private Stack<int> _replica = new();

    public void Push(int value)
    {
        while (_replica.Count > 0)
            _writer.Push(_replica.Pop());

        _writer.Push(value);
    }

    public int Pop()
    {
        while (_writer.Count > 0)
            _replica.Push(_writer.Pop());

        return _replica.Pop();;
    }

    public int Peek()
    {
        while (_writer.Count > 0)
            _replica.Push(_writer.Pop());

        return _replica.Peek();
    }

    public bool Empty() => _writer.Count == 0 && _replica.Count == 0;
}