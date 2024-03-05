namespace Coding.DataStructures.LinkedLists;

public class SinglyNode
{
    public SinglyNode() {}
    public SinglyNode(int value) => (Value) = (value);
    public SinglyNode(int value, SinglyNode next) => (Value, Next) = (value, next);

    public int Value { get; set; }
    public SinglyNode Next { get; set; }
}