namespace Coding.DataStructures.Arrays;

public abstract class BestTimeToSellStocks
{
    public static int GetMaxProfit(int[] prices)
    {
        if (prices.Length is 0 or 1) return 0;

        var (maxProfit, buyValue) = (0, prices[0]);

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < buyValue)
                buyValue = prices[i];
            else
                maxProfit = int.Max(maxProfit, (prices[i] - buyValue));
        }

        return maxProfit;
    }
}