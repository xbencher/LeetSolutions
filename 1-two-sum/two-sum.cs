public class Solution {
    public int[] TwoSum(int[] nums, int target) {

     Dictionary<int,int> dict = new Dictionary<int,int>();

     for(int i = 0; i<nums.Length;++i)
     {
        int remaingVal = target-nums[i];
        if(dict.ContainsKey(remaingVal))
        {
            return new int[] {dict[remaingVal],i};
        }
        else
        {
            dict[nums[i]] =i;
            //if(!dict.ContainsKey(nums[i])) dict.Add(nums[i],i);
            
        }
     }   

     return new int[] {0,0};
    }
}