public class Solution {
    public void MoveZeroes(int[] nums) {
        
        int i =0;
        int inext =1;
        int n = nums.Length;

        if(n == 1) return ;

        while(i < n && inext < n)
        {
            if(nums[i]==0 && nums[inext] != 0)
            {
                int temp = nums[i];
                nums[i]=nums[inext];
                nums[inext]=temp;
                ++i;++inext;
            }
            else if(nums[inext] != 0 && nums[i] !=0)
            {
                 ++i;++inext;
            }
            else if(nums[inext] == 0 && nums[i]!=0)
            {
                ++inext;++i;
            }
            else
            {
                ++inext;
            }
        }
    }
}