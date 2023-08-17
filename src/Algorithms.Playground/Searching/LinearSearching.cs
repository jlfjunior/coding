namespace Algorithms.Playground.Searching;

public abstract class LinearSearching
{
    /// <summary>
    /// The function FindIndex search for index where the value stored be equals
    /// the value passed by parameter.
    /// </summary>
    /// <param name="list"></param>
    /// <param name="value"></param>
    /// <returns>
    /// The int represent the first index where the value was find out.
    /// If the value return is -1 it means that the value wasn't find out.
    /// </returns>
    public static int FindIndex(int[] list, int value)
    {
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] == value) 
                return i;
        }

        return -1;
    }
    
    /// <summary>
    /// The function <c>Sum</c> sum the value of all elements on the array using for
    /// Worst case complexity N
    /// </summary>
    /// <param name="list"></param>
    public static int Sum(int[] list)
    {
        var sum = 0;
        
        for (int i = 0; i < list.Length; i++)
        {
            sum += list[i];
        }

        return sum;
    }
    
    /// <summary>
    /// The function <c>Sum</c> sum the value of all elements on the array using recursion
    /// Worst case complexity N
    /// </summary>
    /// <param name="list"></param>
    /// <param name="size"></param>
    public static int Sum(int[] list, int size)
    {
        var value = list[size - 1];
        var sum = value + Sum(list, size - 1);
        
        return sum;
    }
}