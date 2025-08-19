public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var result = new List<IList<int>>();
        for(int r= 1;r<=numRows;++r)
        {
            var tempList = new List<int>();
            tempList.Add(1);
            int ans=1;
            for(int c =1;c<r;++c)
            {
                    ans=ans*(r-c);
                    ans=ans/c;
                    tempList.Add(ans);
            }
            result.Add(tempList);
        }
        return result;
    }
}