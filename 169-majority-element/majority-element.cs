public class Solution {
    public int MajorityElement(int[] nums) {
        var dic = new Dictionary<int,int>();

        foreach(int num in nums)
        {
            if(dic.ContainsKey(num))
            {
                dic[num] = dic[num]+1;
            }
            else
            {
                dic.Add(num,1);
            }
        }

        return dic.OrderByDescending(e => e.Value).First().Key;
    }
}