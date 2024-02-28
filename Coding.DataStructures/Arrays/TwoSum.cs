namespace Coding.DataStructures.Arrays;

/// <summary>
/// Given an array of integers nums and an integer target, return indices of the two
/// numbers such that they add up to target. You may assume that each input would have
/// exactly one solution, and you may not use the same element twice.
/// </summary>
public abstract class TwoSum
{
    public static int[] Hashing(int[] numbers, int target)
    {
        var checkedPositions = new Dictionary<int, int>();

        for (int current = 0; current < numbers.Length; current++)
        {
            var difference = target - numbers[current];

            if (checkedPositions.ContainsKey(difference))
            {
                var firstPosition = checkedPositions.GetValueOrDefault(difference);

                return new int[] { firstPosition, current };
            }
            
            checkedPositions.Add(numbers[current], current);
        }

        throw new Exception("Algorithm fail");
    }
    
    public static int[] BruteForce(int [] numbers, int target)
    {
        var indexes = new int[2];
        
        for (var i = 0; i < numbers.Length; i++)
        {
            indexes[0] = i;
            for (var j = 0; j < numbers.Length; j++)
            {
                if (i == j) continue;
                
                indexes[1] = j;

                if (numbers[i] + numbers[j] == target) return indexes;
            }
        }

        throw new Exception("Algorithm fail");
    }
}