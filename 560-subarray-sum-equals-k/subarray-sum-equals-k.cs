public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        dict[0] = 1; // base case: prefix sum 0 occurs once
        int sum = 0;
        int count = 0;

        foreach (int num in nums) {
            sum += num;

            if (dict.ContainsKey(sum - k)) {
                count += dict[sum - k]; // add all subarrays ending here
            }

            if (dict.ContainsKey(sum)) {
                dict[sum]++;
            } else {
                dict[sum] = 1;
            }
        }

        return count;
    }
}