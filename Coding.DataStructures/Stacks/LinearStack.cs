namespace Coding.DataStructures.Stacks;

public class LinearStack
{
    private int?[] Values;
    private int NextSlotEmpty;
    
    public LinearStack(int length)
    {
        Length = length;
        Values = new int?[Length];
        NextSlotEmpty = 0;
    }
    
    public int Length { get; }

    public void Push(int value)
    {
        Values[NextSlotEmpty] = value;
        NextSlotEmpty++;
    }

    public int Pop()
    {
        var element = Values[NextSlotEmpty - 1];
        Values[NextSlotEmpty - 1] = null;
        NextSlotEmpty--;
        return (int)element;
    }

    public bool IsFull() => NextSlotEmpty > Length;
}