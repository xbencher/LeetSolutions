public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int low =0;
        int r = matrix.Length;
        int c = matrix[0].Length;
        int high = (r*c)-1;

        while(low <= high)
        {
            var mid = (low+high)/2;
            int j = mid/c;
            int k = mid %c;
            int element = matrix[j][k];

            if(element == target) return true;
            else if ( target < element) high = mid-1;
            else low = mid+1;
        }

        return false;
    }
}