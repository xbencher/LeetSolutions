public class Solution {
    public int MaxArea(int[] height) {
        int start = 0;
        int end = height.Length -1;
        int maxWaterHold =0;
        while(start <end)
        {
            int startIndexValue =height[start];
            int endIndexValue = height[end];
            int smaller = Math.Min(startIndexValue,endIndexValue);
            int currentWaterHold = (end-start)* (smaller);
            maxWaterHold = Math.Max(currentWaterHold,maxWaterHold);

            if(startIndexValue >= endIndexValue)
            {
                end--;
            }
            else
            {
                start++;
            }

        }

        return maxWaterHold;
    }
}