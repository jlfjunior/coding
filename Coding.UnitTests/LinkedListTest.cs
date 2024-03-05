using Coding.DataStructures.LinkedLists;

namespace Coding.UnitTests;

public class LinkedListTest
{
    [Fact]
    public void MergeSinglyList_ShouldMerge()
    {
        var r3 = new SinglyNode(4);
        var r2 = new SinglyNode(2, r3);
        var r1 = new SinglyNode(1, r2);
        
        var l3 = new SinglyNode(4);
        var l2 = new SinglyNode(3, l3);
        var l1 = new SinglyNode(1, l2);
        
        
        var list = LinkedList.MergeSinglyList(r1, l1);
    }
}