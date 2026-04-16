public class Solution {
    public int RomanToInt(string s) {
        
        int Number =0;
        int LengthString = s.Length-1;
        int prev = 0;

        for(int i = LengthString;i>=0;--i)
        {
            int current= GetValue(s[i]);

            if(current < prev)
            {
                Number -=current;
            }
            else
            {
                Number +=current;
            }

            prev = current;
        }

        return Number;
    }


    private int GetValue(char c)
    {
        return c switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0
        };
    }
}