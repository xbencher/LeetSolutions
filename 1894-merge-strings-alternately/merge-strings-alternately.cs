public class Solution {
    public string MergeAlternately(string word1, string word2) {
     
     StringBuilder Sb = new StringBuilder();

     int initial1=0;
     int initial2=0;

     while(initial1 < word1.Length && initial2 < word2.Length)
     {
        Sb.Append(word1[initial1]);
        Sb.Append(word2[initial2]);
        ++initial1;
        ++initial2;
     }   
     
     while(initial1 < word1.Length)
     {
        Sb.Append(word1[initial1]);
        ++initial1;
     } 

     while(initial2 < word2.Length)
     {
        Sb.Append(word2[initial2]);
        ++initial2;
     }

     return Sb.ToString();
    }
}