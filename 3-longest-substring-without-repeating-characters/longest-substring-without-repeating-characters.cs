public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new HashSet<char>();
        int maxSub = 0;
        int l=0;
        for(int r=0;r<s.Length;++r)
        {
            while(l<r && set.Contains(s[r]))
            {
                set.Remove(s[l]);
                ++l;
            }
            set.Add(s[r]);
            int len = r-l+1;
            maxSub = Math.Max(len, maxSub);
        }
        return maxSub;
    }
}