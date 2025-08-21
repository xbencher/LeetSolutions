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

        int[] currentInterVal = new int[]{intervals[0][0], intervals[0][1]};
        int initialPoint = 1;

        if(totalIntervals == 1)
        {
            res.Add(currentInterVal);
        }

        while(initialPoint<totalIntervals)
        {
            var start = intervals[initialPoint][0];
            var end  = intervals[initialPoint][1];

            if(start <= currentInterVal[1])
            {
                currentInterVal[1] = Math.Max(currentInterVal[1],end);
                ++initialPoint;

                if(initialPoint == totalIntervals)
                {
                    res.Add(currentInterVal);
                }
            }
            else
            {
                 res.Add(currentInterVal);
                ++initialPoint;
                currentInterVal = new int[]{start,end}; 

                if(initialPoint == totalIntervals)
                {
                    res.Add(currentInterVal);
                }
            }
        }


        // for(int i=0;i<totalIntervals;++i)
        // {
        //     int start = intervals[i][0];
        //     int end = intervals[i][1];
            
        //     if(res.Count!=0 && end <= res.Last()[1] )
        //     {
        //         continue;
        //     }

        //     for(int j = i+1;j<totalIntervals;++j)
        //     {
        //         if(intervals[j][0] <= end)
        //         {
        //             end = Math.Max(end,intervals[j][1]);
        //         }
        //         else break;
        //     }

        //     res.Add(new int[]{start,end});
        // }

        return res.ToArray();
    }
}