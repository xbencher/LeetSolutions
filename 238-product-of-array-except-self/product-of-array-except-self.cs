public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int alength = nums.Length;
        int[] ans = new int[alength]; 
        Array.Fill(ans, 1);

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

        // add suffix

        return ans;
    }



    // public int[] ProductExceptSelf(int[] nums) {
    //     int alength = nums.Length;
    //     int[] prefix = new int[alength];
    //     int[] sufixfix = new int[alength];
    //     int[] ans = new int[alength]; 
    //     int count =1;
    //     for(int i =0;i<prefix.Length;++i)
    //     {
    //         count = count*nums[i];
    //         prefix[i] = count;
    //     }

    //      count=1;

    //     for(int j=sufixfix.Length-1;j>=0;--j)
    //     {
    //         count = count*nums[j];
    //         sufixfix[j]=count;
    //     }

    //     for(int k=0;k<ans.Length;++k)
    //     {
    //         if(k==0)
    //         {
    //              ans[k] = sufixfix[k+1];
    //         }
    //         else if(k==ans.Length-1)
    //         {
    //             ans[k] = prefix[k-1];
    //         }
    //         else
    //         {
    //             ans[k] = prefix[k-1] * sufixfix[k+1];
    //         }
    //     }

    //     return ans;
    // }
}