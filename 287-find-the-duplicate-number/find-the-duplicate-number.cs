public class Solution {
    public int FindDuplicate(int[] nums) {
        
        var set = new  HashSet<int>();

        foreach(int i in nums)
        {
            if(set.Contains(i)) return i;
            else set.Add(i);
        }

        return 0; 
    }
}