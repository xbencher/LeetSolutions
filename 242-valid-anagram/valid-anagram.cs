public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> map = new Dictionary<char,int>();

        if(s.Length != t.Length) return false;

        foreach(var element in s)
        {
            if(map.ContainsKey(element))
            {
                map[element] += 1;
            }
            else
            {
                 map.Add(element,1);
            }
        }

        foreach(var element in t)
        {
            if(map.ContainsKey(element))
            {
                if(map[element] == 0) return false;
                map[element] -= 1;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}