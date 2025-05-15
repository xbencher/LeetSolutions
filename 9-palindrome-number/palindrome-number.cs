public class Solution {
    public bool IsPalindrome(int x) {
        
        int result =0;
        int originalNum = x;
        if(x<0) return false;

        if(x == 0) return true;
        
        while(x != 0)
        {
                result = result*10 + x%10;

                x = x/10;
        }

        if(result == originalNum) return true;

        return false;

    }
}