public class Solution {
    public int Reverse(int x) {
        int result =0;
        int y = x;

        while(y != 0)
        {
            int num = y%10;

            if(result > int.MaxValue/10 || (result == int.MaxValue/10 && num > 7))
            {
                return 0;
            }

            if(result < int.MinValue/10 || (result == int.MinValue/10 && num < -8))
            {
                return 0;
            }

            result = result*10 + num;
           
            y= y/10;

        }


        return result;
    }
}