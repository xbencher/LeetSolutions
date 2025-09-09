public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i=0;
        int n = numbers.Length-1;
        while(i<n)
        {
            int sum =  numbers[i]+numbers[n];

            if(sum == target) return new int[]{i+1,n+1};
            else if(sum > target) --n;
            else ++i;
        }

        return new int[] {0,0};
    }
}