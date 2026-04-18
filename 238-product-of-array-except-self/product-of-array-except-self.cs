public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int alength = nums.Length;
        int[] prefix = new int[alength];
        int[] sufixfix = new int[alength];
        int[] ans = new int[alength]; 
        int count =1;
        for(int i =0;i<prefix.Length;++i)
        {
            count = count*nums[i];
            prefix[i] = count;
        }

         count=1;

        for(int j=sufixfix.Length-1;j>=0;--j)
        {
            count = count*nums[j];
            sufixfix[j]=count;
        }

        for(int k=0;k<ans.Length;++k)
        {
            if(k==0)
            {
                 ans[k] = sufixfix[k+1];
            }
            else if(k==ans.Length-1)
            {
                ans[k] = prefix[k-1];
            }
            else
            {
                ans[k] = prefix[k-1] * sufixfix[k+1];
            }
        }

        return ans;
    }
}