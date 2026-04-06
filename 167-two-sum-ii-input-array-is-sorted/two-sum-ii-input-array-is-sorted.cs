public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int p1 = 0;
        int p2 = numbers.Length-1;

        while(p1<p2)
        {
            int val = numbers[p1]+numbers[p2];
            
            if(target == val) return new int[] {p1+1,p2+1};

            if(target > val)
            {
                p1 +=1;
            }
            else
            {
                p2 -=1;
            }

        }

        return new int[] {0,0};
    }
}