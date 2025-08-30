public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        var dict = new Dictionary<int,int>();
        List<int> list = new List<int>();
        var n = (nums.Length)/3;
        foreach(int key in nums)
        {
            if(dict.ContainsKey(key))
            {
                dict[key]+=1;
            }
            else
            {
                dict.Add(key,1);
            }
        }

        foreach(var item in dict)
        {
            if(item.Value >n)
            {
                list.Add(item.Key);
            }
        }

        return list;
    }
}