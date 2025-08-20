public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix[0].Length;

        for(int i=0;i<n;++i)
        {
            for(int j=i+1;j<n;++j)
            {
                int val = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] =val;
            }

            int m=0;
            int k=n-1;
            while(m<k)
            {
                int val = matrix[i][m];
                matrix[i][m] = matrix[i][k];
                matrix[i][k] = val;
                m++;
                k--;
            }
        }
    }
}