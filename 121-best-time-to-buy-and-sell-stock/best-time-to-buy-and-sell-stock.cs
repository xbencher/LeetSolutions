public class Solution {
    public int MaxProfit(int[] prices) {
        int min =prices[0];
        int profit =0;

        for(int i =1;i<prices.Length;++i)
        {
            if(prices[i]<=min)
            {
                min =prices[i];
            }

            int cprofit = prices[i]-min;
            profit= Math.Max(profit,cprofit);
        }

        return profit;
    }
}