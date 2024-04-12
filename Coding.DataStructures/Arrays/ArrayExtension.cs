using System.Collections;

namespace Coding.DataStructures.Arrays;

public abstract class ArrayExtension
{
    public static bool ContainsDuplicate(int[] numbers)
    {
        var map = new Hashtable();
        
        for (var i = 0; i < numbers.Length; i++)
        {
            if (map.ContainsKey(numbers[i])) return true;
            
            map.Add(numbers[i], 1);
        }
        
        return false;
    }

    public static int[] SortedSquares(int[] numbers)
    {
        for (var i = 0; i < numbers.Length; i++)
            numbers[i] = numbers[i] * numbers[i];
        
        Array.Sort(numbers);
        
        return numbers;
    }
}