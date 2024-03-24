namespace Coding.Algorithms.Searching;

public abstract class BinarySearch
{
    public static int Search(int[] elements, int target)
    {
        if (elements.Length == 0) return -1;

        var (left, right) = (0, elements.Length - 1);

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            if (elements[mid] == target) return mid;

            if (target < elements[mid])
                right = mid - 1;
            else
                left = mid + 1;
        }

        return -1;
    }
}