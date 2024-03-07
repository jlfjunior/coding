using Coding.DataStructures.Arrays;

namespace Coding.UnitTests;

public class BestTimeToSellStocksTest
{
    [Theory]
    [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new int[] { 7,6,4,3,1 }, 0)]
    [InlineData(new int[] { }, 0)]
    [InlineData(new int[] { 1 }, 0)]
    [InlineData(new int[] { 1,2,4 }, 3)]
    [InlineData(new int[] { 2,1,2,1,0,1,2 }, 2)]
    [InlineData(new int[] { 3,3,5,0,0,3,1,4 }, 4)]
    public void GetMaxProfit(int[] prices, int maxProfit)
    {
        Assert.Equal(maxProfit, BestTimeToSellStocks.GetMaxProfit(prices));        
    }
    
}