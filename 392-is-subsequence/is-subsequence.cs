public class Solution {
    public bool IsSubsequence(string s, string t) {
        int sLength = s.Length-1;
        int tLength = t.Length-1;

        if(sLength > tLength) return false;

        if(sLength <0) return true;
        int i=0;
        int j=0;

        while(i <= sLength && j <= tLength)
        {
                if(s[i] == t[j])
                {
                    if(i ==sLength) return true;

                    ++i;++j;
                }
                else
                {
                    ++j;
                }
        }

        return false;
    }
}