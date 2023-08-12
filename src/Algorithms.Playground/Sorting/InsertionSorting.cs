namespace Algorithms.Playground.Sorting;

public abstract class InsertionSorting
{
    /// <summary>
    /// The function <c>Sorting</c> sort an array of number elements
    /// Worst case complexity Nˆ2
    /// </summary>
    /// <param name="list"></param>
    public static void Sorting(int[] list)
    {
        for (int i = 1; i < list.Length; i++)
        {
            var j = i - 1;
            var element = list[i];

            while (j >= 0 && list[j] > element)
            {
                list[j + 1] = list[j];
                j--;
            }

            list[j + 1] = element;
        }
    }
}