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
            ? Head.Data
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
}

class Node
{
    public Node(int data) => (Data) = (data);
    public Node(int data, Node next) => (Data, Next) = (data, next);

    public int Data { get; set; }
    public Node Next { get; set; }
}