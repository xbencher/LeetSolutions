public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var dict = new Dictionary<int,int>();

        for(int i=0; i< nums.Length;++i)
        {
            var com = target-nums[i];
           
            if(dict.ContainsKey(com))
            {
                return new int[] {dict[com],i};
            }

            if(!dict.ContainsKey(nums[i]))
            {
                dict[nums[i]] = i;
            }
        }

        return new int[] {-1,-1};
    }
}