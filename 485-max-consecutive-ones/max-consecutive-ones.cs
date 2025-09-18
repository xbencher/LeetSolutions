public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int count =0;
        int maxCount =0;

        foreach(int i in nums)
        {
            if(i == 1)
            {
                ++count ;
                maxCount = Math.Max(count,maxCount);
                
            }
            else
            {
              maxCount = Math.Max(count,maxCount);
              count =0;
            }

        }
        return maxCount;
    }
}