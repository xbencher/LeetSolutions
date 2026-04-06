public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int,int> dict = new Dictionary<int,int>();

        for(int i=0;i<nums.Length;++i)
        {
            int targetValue =  target-nums[i];
                if(dict.ContainsKey(targetValue))
                    return new int[] {i,dict[targetValue]};
            
            if(!dict.ContainsKey(nums[i]))
                dict.Add(nums[i],i);
        }

        return new int[] {0,0};
    }
}