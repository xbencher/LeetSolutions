public class Solution {
    public void SortColors(int[] nums) {
       int mid=0;
       int low =0;
       int high = nums.Length-1;

       while(mid <= high)
       {
            if(nums[mid] == 0)
            {
                int value = nums[low];
                nums[low] =  nums[mid];
                nums[mid] = value;
                ++low;
                if(mid <= low)
                {
                    mid++;
                }
            }
            else if(nums[mid] ==1)
            {
                    mid++;
            }
            else
            {
                int value = nums[high];
                nums[high]=nums[mid];
                nums[mid] = value;
                high--;
            }
       }
    }
}