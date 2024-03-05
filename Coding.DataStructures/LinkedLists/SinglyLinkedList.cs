namespace Coding.DataStructures.LinkedLists;

public class SinglyLinkedList
{
    private SinglyNode Head { get; set; }

    public bool IsEmpty() => Head is null;

    public void PushOnHead(int data)
    {
        if (Head == null)
        {
            Head = new SinglyNode(data);
            return;
        }

        var current = Head;
        Head = new SinglyNode(data, current);
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
            Head = new SinglyNode(data);
            return;
        }

        var current = Head;

        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = new SinglyNode(data);
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

    public int GetTail()
    {
        var current = Head;

        while (current.Next != null)
            current = current.Next;

        return current.Value;
    }

    public int ValueAt(int index)
    {
        var current = Head;
        var count = 0;
        
        while (index > count)
        {
            current = current.Next;
            count++;
        }

        return current.Value;
    }

    public void InsertAt(int index, int value)
    {
        if (Head == null)
        {
            Head = new SinglyNode(value);
            return;
        }
        
        var current = Head;
        var currentIndex = 0;
        
        while (current != null && currentIndex < index - 1)
        {
            
            current = current.Next;
            currentIndex++;
        }

        var node = new SinglyNode(value, current.Next);
        current.Next = node;
    }

    public void Reverse()
    {
        var dummy = new SinglyLinkedList();
        var current = Head;
        
        while (current.Next != null)
        {
            dummy.PushOnHead(current.Value);
            current = current.Next;
        }

        dummy.PushOnHead(current.Value);

        Head = dummy.Head;
    }
}