public class Solution {
    public void SortColors(int[] nums) {
        int cunt0 =0;
        int cunt1=0;
        int cunt2=0;

        for(int i=0;i<nums.Length;++i)
        {
            if(nums[i]== 0) ++cunt0;
            else if(nums[i] == 1) ++cunt1;
            else ++cunt2;
        }

        for(int i=0;i<nums.Length;++i)
        {
            if(cunt0 >0)
            {
                nums[i]=0;
                --cunt0;
            }
            else if(cunt1>0)
            {
                nums[i]=1;
                --cunt1;
            }
            else
            { 
                nums[i]=2;
            }
        }
    }
}