public class Solution {
    public int MaxSubArray(int[] nums) {
        int max =int.MinValue;
        int sum =0;
        foreach(int i in nums)
        {
            sum+=i;
            max = Math.Max(sum,max);

            if(sum < 0)
            {
                sum=0;
            }
        }
        return max;
    }
}