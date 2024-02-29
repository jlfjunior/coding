using System.Data;

namespace Coding.DataStructures.LinkedLists;

public class SinglyLinkedList
{
    private Node Head { get; set; }

    public bool IsEmpty() => Head is null;

    public void PushOnHead(int data)
    {
        if (Head == null)
        {
            Head = new Node(data);
            return;
        }

        var current = Head;
        Head = new Node(data, current);
    }

    /// <summary>
    /// Function Size executes in O(n) where N is the number os elements in the list
    /// </summary>
    /// <returns>
    /// </returns>
    public int Size()
    {
        var count = 0;

        if (Head == null) return count;

        var current = Head;

        while (current != null)
        {
            count++;
            current = current.Next;
        }

        return count;
    }

    public int GetHead()
        => Head is not null
            ? Head.Value
            : throw new InvalidOperationException("List does not have elements stored.");
    

    public void PushOnTail(int data)
    {
        if (Head == null)
        {
            Head = new Node(data);
            return;
        }

        var current = Head;

        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = new Node(data);
    }

    public int PopOnHead()
    {
        var current = Head;
        Head = Head.Next;

        return current.Value;
    }

    public int PopOnTail()
    {
        var current = Head;

        if (current.Next == null)
        {
            Head = null;
            return current.Value;
        }

        while (current.Next.Next != null)
        {
            current = current.Next;
        }

        
        var element = current.Next;
        current.Next = null;
        
        return element.Value;
    }
}

class Node
{
    public Node(int value) => (Value) = (value);
    public Node(int value, Node next) => (Value, Next) = (value, next);

    public int Value { get; set; }
    public Node Next { get; set; }
}