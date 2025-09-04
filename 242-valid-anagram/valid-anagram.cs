public class Solution {
    public bool IsAnagram(string s, string t) {

        Dictionary<char,int> dic = new Dictionary<char,int>(); 

        if(s.Length != t.Length) return false;
        
        foreach(char c in s)
        {
            if(dic.ContainsKey(c))
            {
                dic[c] += 1; 
            }
            else
            {
                dic.Add(c,1);
            }
        }

        foreach(char c in t)
        {
            if(dic.ContainsKey(c))
            {
                if(dic[c] <= 0) return false;
                else dic[c] -=1;
            }
            else
            {
                return false;
            }
        }


        return true;
    }
}