public class Solution {
    public int[][] Merge(int[][] intervals) {
        var res = new List<int[]>();
        var totalIntervals = intervals.Length;
        Array.Sort(intervals, (a, b) =>
        {
            int cmp = a[0].CompareTo(b[0]);
            if (cmp == 0)
                return a[1].CompareTo(b[1]); // If first elements are same,sort by 2
            return cmp;
        });

        for(int i=0;i<totalIntervals;++i)
        {
            int start = intervals[i][0];
            int end = intervals[i][1];
            
            if(res.Count!=0 && end <= res.Last()[1] )
            {
                continue;
            }

            for(int j = i+1;j<totalIntervals;++j)
            {
                if(intervals[j][0] <= end)
                {
                    end = Math.Max(end,intervals[j][1]);
                }
                else break;
            }

            res.Add(new int[]{start,end});
        }

        return res.ToArray();
    }
}