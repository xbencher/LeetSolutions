public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int low =0;
        int high = nums.Length-1;

        if(high == 0) return nums[high];

        while(low <= high)
        {

                    if(nums[low] == nums[low+1] && nums[high] == nums[high-1])
                    {
                        low +=2;
                        high -=2;
                    }
                    else if(nums[low] != nums[low+1])
                    {
                        return nums[low];
                    }
                    else 
                    {
                        return nums[high];
                    }
            
           
        }

        return 0;

    }
}