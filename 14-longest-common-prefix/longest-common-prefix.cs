public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string sb = new string(strs[0]);
        
        if(strs.Length == 1) return sb;

        for(int i=1;i<strs.Length;++i)
        {
            sb = GetCommonString(sb,strs[i]);
        }

        return sb;
    }

    public string GetCommonString(string s1, string s2)
    {
        StringBuilder sb = new StringBuilder("");
        int s1Counter = 0;
        int s2Counter = 0;
        while(s1Counter < s1.Length && s2Counter < s2.Length)
        {
            if(s1[s1Counter] == s2[s2Counter])
            {
                sb.Append(s1[s1Counter]);
                s1Counter++;
                s2Counter++;
            }
            else
            {
                break;
            }
        }

        return sb.ToString();
    }
}