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
}