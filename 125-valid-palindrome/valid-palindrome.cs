public class Solution {
    public bool IsPalindrome(string s) {
        var strbuild = new StringBuilder();
        foreach(char c in s.ToLower())
        {
            if(char.IsLetterOrDigit(c)) strbuild.Append(c);
        }
        var clean = strbuild.ToString();
      if(clean.Length ==0 || clean.Length == 1) return true;
      
      int i=0;
      int l = clean.Length-1;

      while(i <= l)
      {
         char front = clean[i];
         char back = clean[l];
         if(front != back) return false;
         else
         ++i;--l;
      }

      return true;
    }
}