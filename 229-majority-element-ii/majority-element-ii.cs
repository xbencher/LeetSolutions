public class Solution {
    public IList<int> MajorityElement(int[] nums) {
       
        List<int> list = new List<int>();
        int n = nums.Length;
        int count1 =0;
        int count2=0;
        int el1=int.MinValue;
        int el2=int.MinValue+1;

        for(int i=0;i<n;++i)
        {
            if(count1 == 0 && nums[i]!= el2)
            {
                count1 = 1;
                el1=nums[i];
            }
            else if(count2 == 0 && nums[i] != el1)
            {
                count2 = 1;
                el2=nums[i];
            }
            else if(nums[i] == el1)
            {
                ++count1;
            }
            else if(nums[i] == el2)
            {
                ++count2;
            }
            else 
            {
                --count1;
                --count2;
            }
        }

        count1=0;count2=0;

        foreach(int item in nums)
        {
            if(item == el1)++count1;
            if(item == el2)++count2;
        }

        if(count1 > n/3) list.Add(el1);
        if(count2 > n/3) list.Add(el2);

        return list;
    }
}