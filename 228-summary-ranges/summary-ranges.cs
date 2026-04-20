public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> list = new List<string>();
        
        if(nums.Length == 0)
        {
            return list;
        }

        int p1 =0;
        int initialNumber =nums[0];

        
        if(nums.Length == 1)
        {
            list.Add(nums[0].ToString());
            return list;
        }

        while(p1 < nums.Length-1)
        {
          if(nums[p1]+1 == nums[p1+1])
          {
            ++p1;
          }
          else
          {
             if(initialNumber == nums[p1])
             {
                list.Add(initialNumber.ToString());
             }
             else
             {

                list.Add($"{initialNumber.ToString()}->{nums[p1].ToString()}");
             }
                initialNumber=nums[p1+1];
                ++p1;
          }
        }

        if(initialNumber == nums[nums.Length-1])
             {
                list.Add(initialNumber.ToString());
             }
             else
             {

                list.Add($"{initialNumber.ToString()}->{nums[nums.Length-1].ToString()}");
             }

        return list;
    }
}