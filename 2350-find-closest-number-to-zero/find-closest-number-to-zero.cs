public class Solution {
    public int FindClosestNumber(int[] nums) {
        
        int closest = nums[0];
        
        for(int i =1; i <nums.Length;++i)
        {
            int dis1 = Math.Abs(nums[i]);
            int dis2 = Math.Abs(closest);

            if(dis1 < dis2)
            {
                closest =  nums[i];
            }
            else if (dis2 == dis1)
            {
                closest = Math.Max(nums[i],closest);
            }
        }

        return closest;
    }
}