public class Solution {
    public int Search(int[] nums, int target) {
        int low =0;
        int high = nums.Length-1;

        while(low <= high)
        {
            var mid =  (low+high)/2;

            if(nums[mid] == target) return mid;

            if(nums[mid] < target)
            {
                low = mid+1;
            }
            else
            {
                high = mid-1;
            }
        }

        return -1;
    }
}