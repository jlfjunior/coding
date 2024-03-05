namespace Coding.DataStructures.LinkedLists;

public abstract class LinkedList
{
    public static SinglyNode MergeSinglyList(SinglyNode right, SinglyNode left)
    {
        var temp = new SinglyNode();

        var currentRight = right;
        var currentLeft = left;
        var currentTemp = temp;

        while (currentRight is not null && currentLeft is not null)
        {
            if (currentRight.Value > currentLeft.Value)
            {
                var aux = new SinglyNode(currentLeft.Value);
                currentTemp.Next = aux;
                currentTemp = currentTemp.Next;
                currentLeft = currentLeft.Next;
            }
            else
            {
                currentTemp.Next = new SinglyNode(currentRight.Value);
                currentTemp = currentTemp.Next;
                currentRight = currentRight.Next;
            }
        }

        while (currentRight != null)
        {
            currentTemp.Next = new SinglyNode(currentRight.Value);
            currentTemp = currentTemp.Next;
            currentRight = currentRight.Next;
        }

        while (currentLeft != null)
        {
            var aux = new SinglyNode(currentLeft.Value);
            currentTemp.Next = aux;
            currentTemp = currentTemp.Next;
            currentLeft = currentLeft.Next;
        }

        return temp.Next;
    }
}