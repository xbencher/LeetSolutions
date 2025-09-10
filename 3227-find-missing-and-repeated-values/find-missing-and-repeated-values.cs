public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        
     int r = grid.Length;
        int c = grid[0].Length;
        int n = r * c;

        int[] freq = new int[n];
        int[] result = new int[2]; // result[0] = repeated, result[1] = missing

        // Count occurrences
        for (int i = 0; i < n; i++) {
            int row = i / c;
            int col = i % c;
            int val = grid[row][col];
            freq[val - 1]++;
        }

        // Find repeated and missing
        for (int i = 0; i < n; i++) {
            if (freq[i] == 2) {
                result[0] = i + 1; // repeated
            } else if (freq[i] == 0) {
                result[1] = i + 1; // missing
            }
        }

        return result;
    
    }
}