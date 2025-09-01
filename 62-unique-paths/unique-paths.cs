public class Solution {
    private int[,] dp;
    public int UniquePaths(int m, int n) {
        dp = new int[m, n];

        for(int i=0;i<m;++i)
        {
            for(int j=0;j<n;++j)
            {
                dp[i,j] = -1;
            }
        }
        return CountPath(0,0,m,n, dp);
    }

    public int CountPath(int i, int j, int m, int n, int[,] dptable)
    {
        if(i == m-1 && j==n-1) return 1;

        if(i > m-1 || j > n-1) return 0;

        if(dptable[i,j] != -1) return dptable[i,j];

return dptable[i,j] = (CountPath(i+1, j, m, n,dptable)
+ CountPath(i, j+1, m, n,dptable));
    }
}