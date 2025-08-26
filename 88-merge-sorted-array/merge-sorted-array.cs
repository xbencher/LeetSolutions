public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {

        int n1 =m;
        int n2 = 0;

        while(n2<n)
        {
            nums1[n1] = nums2[n2];
            n1++;
            n2++;
        }

        Array.Sort(nums1);
    }
}