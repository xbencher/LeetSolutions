public class Solution {
    public int RomanToInt(string s) {
        
        int Number =0;
        int LengthString = s.Length-1;
        char prev = s[LengthString];

        for(int i = LengthString;i>=0;--i)
        {
            char value= s[i];
            
            switch(value)
            {
                case 'I' :
                    if(prev == 'V' || prev == 'X')
                    {
                        Number -= 1;
                    }
                    else
                    {
                         Number += 1;
                    }
                    break;
                case 'V' :
                    Number += 5;
                    break;
                case 'X' :
                    if(prev == 'L' || prev == 'C')
                    {
                        Number -= 10;
                    }
                    else
                    {
                         Number += 10;
                    }
                    break;
                case 'L' :
                    Number += 50;
                    break;
                case 'C' :
                    if(prev == 'D' || prev == 'M')
                    {
                        Number -= 100;
                    }
                    else
                    {
                         Number += 100;
                    }
                    break;
                case 'D' :
                    Number += 500;
                    break;
                case 'M' :
                    Number += 1000;
                    break;
                default :
                    break;
            }

            prev = value;
        }

        return Number;
    }
}