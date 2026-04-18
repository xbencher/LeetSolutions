public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int alength = nums.Length;
        int[] ans = new int[alength]; 
        
        for(int i=0;i<alength;++i)
        {
            ans[i]=1;
        }
        // fill prefix in array
        for(int i=1;i<alength;++i)
        {
            ans[i]=ans[i-1]*nums[i-1];
        }

        int suffix=1;

        for(int i =alength-2;i>=0;i--)
        {
            suffix *= nums[i+1];
            ans[i] *= suffix;
        }
        return ans;
    }
}