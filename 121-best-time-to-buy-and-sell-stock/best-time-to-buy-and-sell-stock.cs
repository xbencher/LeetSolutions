public class Solution {
    public int MaxProfit(int[] prices) {
        int min = prices[0];
        int profit =0;
        for(int i=1;i<prices.Length;++i)
        {
            int currentProfit = prices[i]-min;
            profit = Math.Max(profit,currentProfit);
            min = Math.Min(prices[i],min);
        }
        return profit;
    }
}