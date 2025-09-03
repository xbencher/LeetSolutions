public class Solution {
    public int LongestConsecutive(int[] nums) {
       var set = new HashSet<int>(); 
       int maxCount=1;
       if(nums.Length ==0) return 0;

       foreach(int i in nums)
       {
            if(!set.Contains(i)) set.Add(i);
       }

       foreach(int i in set)
       {
            if(!set.Contains(i-1))
            {
                int count =1;
                int key =i;
                while (set.Contains(key+1))
                {
                    ++count;
                    key +=1;
                }

                maxCount = Math.Max(count,maxCount);
            }
       }

       return maxCount;
    }
}